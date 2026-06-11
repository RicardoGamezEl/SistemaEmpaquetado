using System;
using System.Windows.Forms;
using System.IO.Ports;
using SistemaEmpaquetado.Models;
using SistemaEmpaquetado.Services;

namespace SistemaEmpaquetado;

public partial class Form1 : Form
{
    private BrazoController brazo;
    private BandaController banda;

    private int cajasProcesadas = 0;

    private bool brazoOcupado = false;

    private EstadoSistema estadoActual = EstadoSistema.Detenido;

    public Form1()
    {
        InitializeComponent();
        brazo = new BrazoController();
        banda = new BandaController();
        brazo.MensajeRecibido += Brazo_MensajeRecibido;
        banda.MensajeRecibido += Banda_MensajeRecibido;
    }
    private void Brazo_MensajeRecibido(string mensaje)
    {
        BeginInvoke(async () =>
        {
            await ProcesarMensajeBrazo(mensaje);
        });
    }
    private void Banda_MensajeRecibido(string mensaje)
    {
        BeginInvoke(async () =>
        {
            await ProcesarMensajeBanda(mensaje);
        });
    }
    private void RegistrarEvento(string mensaje)
    {
        lstEventos.Items.Add(
            $"{DateTime.Now:HH:mm:ss} - {mensaje}"
        );

        lstEventos.TopIndex =
            lstEventos.Items.Count - 1;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void lstEventos_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
        cmbBrazo.Items.Clear();
        cmbBanda.Items.Clear();

        string[] puertos = SerialPort.GetPortNames();

        cmbBrazo.Items.AddRange(puertos);
        cmbBanda.Items.AddRange(puertos);

        RegistrarEvento("Puertos actualizados");
    }

    private void btnConectarBrazo_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(cmbBrazo.Text))
        {
            MessageBox.Show("Seleccione el puerto del Brazo");
            return;
        }
        try
        {
            brazo.Conectar(cmbBrazo.Text);
            lblBrazo.Text = "Brazo: Conectado";
            panelBrazo.BackColor = Color.Lime;
            RegistrarEvento("Brazo conectado");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private async void btnConectarBanda_Click(object sender, EventArgs e)
    {
        try
        {
            lblEstado.Text = "Estado: Conectando a la banda...";
            bool conectado = await banda.ConectarAsync();
            if (!conectado)
            {
                MessageBox.Show("No se pudo conectar a la banda");
                return;
            }
            panelBanda.BackColor = Color.Lime;
            lblBanda.Text = "Banda: Conectada";
            lblEstado.Text = "Estado: Listo";
            RegistrarEvento("Banda conectada");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private async Task ProcesarMensajeBrazo(string mensaje)
    {
        RegistrarEvento(
            $"Brazo:{mensaje}");
        switch (mensaje)
        {
            case "INICIO":

                brazoOcupado = true;

                lblEstado.Text =
                    "Estado: Brazo Trabajando";

                break;

            case "FIN":

                brazoOcupado = false;

                cajasProcesadas++;

                lblContador.Text =
                    $"Cajas Procesadas: {cajasProcesadas}";

                RegistrarEvento(
                    "Caja procesada");

                if (estadoActual != EstadoSistema.Detenido)
                {
                    estadoActual =
                        EstadoSistema.EsperandoCaja;

                    lblEstado.Text =
                        "Estado: Esperando Caja";

                    await banda.IniciarAsync();
                }

                break;
        }
    }
    private void btnPruebaBrazo_Click(object sender, EventArgs e)
    {
        if (!brazo.Conectado)
        {
            MessageBox.Show(
                "El brazo no está conectado");

            return;
        }

        if (brazoOcupado)
        {
            MessageBox.Show(
                "Brazo ocupado");

            return;
        }

        brazo.EjecutarRutina();

        RegistrarEvento(
            "Rutina del brazo iniciada");
    }
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        brazo.Desconectar();
        banda.Desconectar();
        panelBrazo.BackColor = Color.Red;
        panelBanda.BackColor = Color.Red;
        base.OnFormClosing(e);
    }

    private async Task ProcesarMensajeBanda(string mensaje)
    {
        RegistrarEvento(
            $"Banda:{mensaje}");
        switch (mensaje)
        {
            case "CAJA":
                if (brazoOcupado)
                    return;
                if (estadoActual == EstadoSistema.Detenido)
                    return;

                if (estadoActual != EstadoSistema.EsperandoCaja)
                    return;

                estadoActual = EstadoSistema.Empaquetando;

                lblEstado.Text =
                    "Estado: Empaquetando";

                await banda.DetenerAsync();

                brazo.EjecutarRutina();

                break;

            case "BANDA_ON":

                lblEstado.Text =
                    "Estado: Esperando Caja";

                break;

            case "BANDA_OFF":

                lblEstado.Text =
                    "Estado: Banda Detenida";

                break;

            case "ERROR":

                estadoActual =
                    EstadoSistema.Error;

                lblEstado.Text =
                    "Estado: ERROR";

                break;
        }
    }

    private async void btnIniciar_Click(object sender, EventArgs e)
    {
        if (!banda.Conectado)
        {
            MessageBox.Show(
                "La banda no está conectada");
            return;
        }
        if (!brazo.Conectado)
        {
            MessageBox.Show(
                "El brazo no está conectado");
            return;
        }
        estadoActual = EstadoSistema.EsperandoCaja;

        lblEstado.Text =
            "Estado: Esperando Caja";
        RegistrarEvento(
            "Sistema iniciado");

        await banda.IniciarAsync();
    }

    private async void btnDetener_Click(object sender, EventArgs e)
    {
        estadoActual =
        EstadoSistema.Detenido;

        await banda.DetenerAsync();

        lblEstado.Text =
            "Estado: Detenido";

        RegistrarEvento(
            "Sistema detenido");
    }

    private void lblEstado_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void Estado_Enter(object sender, EventArgs e)
    {

    }

    private void lblBanda_Click(object sender, EventArgs e)
    {

    }

    private void lblContador_Click(object sender, EventArgs e)
    {

    }

    private void Control_Enter(object sender, EventArgs e)
    {

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void panel1_Paint_1(object sender, PaintEventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
}
