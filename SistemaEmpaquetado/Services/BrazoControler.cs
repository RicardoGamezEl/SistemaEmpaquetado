using System.IO.Ports;

namespace SistemaEmpaquetado.Services
{
    public class BrazoController
    {
        private SerialPort? puerto;

        public event Action<string>? MensajeRecibido;

        public bool Conectado =>
            puerto != null &&
            puerto.IsOpen;

        public void Conectar(string puertoCom)
        {
            puerto = new SerialPort(
                puertoCom,
                9600
            );

            puerto.DtrEnable = true;

            puerto.DataReceived +=
                Puerto_DataReceived;

            puerto.Open();
        }

        private void Puerto_DataReceived(
            object? sender,
            SerialDataReceivedEventArgs e)
        {
            if (puerto == null)
                return;

            string mensaje =
                puerto.ReadLine();

            MensajeRecibido?.Invoke(
                mensaje.Trim()
            );
        }

        public void EjecutarRutina()
        {
            if (!Conectado)
                return;

            puerto!.Write("P");
        }

        public void Desconectar()
        {
            if (puerto != null &&
                puerto.IsOpen)
            {
                puerto.Close();
            }
        }
    }
}