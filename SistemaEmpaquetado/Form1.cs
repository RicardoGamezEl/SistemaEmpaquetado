using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace SistemaEmpaquetado;

public partial class Form1 : Form
{
    private SerialPort brazoPort;
    private SerialPort bandaPort;

    private int cajasProcesadas = 0;

    private bool sistemaActivo = false;
    private bool brazoOcupado = false;
    public Form1()
    {
        InitializeComponent();
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
        try
        {
            brazoPort = new SerialPort(
                cmbBrazo.Text,
                9600
                );
            brazoPort.Open();
            brazoPort.DataReceived += Brazo_DataReceived;
            lblBrazo.Text = "Brazo: Conectado";

            RegistrarEvento("Brazo conectado");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnConectarBanda_Click(object sender, EventArgs e)
    {
        try
        {
            bandaPort = new SerialPort(
                cmbBanda.Text,
                9600
                );
            bandaPort.Open();
            lblBanda.Text = "Banda: Conectada";
            RegistrarEvento("Banda conectada");

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void Brazo_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        string mensaje =
            brazoPort.ReadLine();
        BeginInvoke(new Action(() =>
            {
                ProcesarMensajeBrazo(mensaje.Trim());
            }));
    }
    private void ProcesarMensajeBrazo(string mensaje)
    {
        RegistrarEvento(
            $"Brazo:{mensaje}");
        switch (mensaje)
        {
            case "INICIO":
                lblEstado.Text = "Estado: Brazo Trabajando";
                brazoOcupado = true;
                break;
            case "FIN":
                cajasProcesadas++;
                lblContador.Text = $"Cajas Procesadas: {cajasProcesadas}";
                lblEstado.Text = "Estado: Rutina Completa";
                brazoOcupado = false;
                RegistrarEvento("Caja procesada");
                break;
        }
    }

    private void btnPruebaBrazo_Click(object sender, EventArgs e)
    {
        if (brazoOcupado)
        {
            MessageBox.Show(
            "El brazo está ocupado."
        );
        return;
        }
        if (brazoPort == null)
            return;
        if(!brazoPort.IsOpen)
            return;
        brazoPort.Write("P");
        RegistrarEvento("Comando de prueba enviado al brazo");
    }
}
