namespace SistemaEmpaquetado.Services;

public class BandaController
{
    private readonly BluetoothManager bluetooth;

    public event Action<string>? MensajeRecibido;

    public bool Conectado =>
        bluetooth.Conectado;

    public BandaController()
    {
        bluetooth =
            new BluetoothManager();

        bluetooth.MensajeRecibido +=
            mensaje =>
            {
                MensajeRecibido?.Invoke(
                    mensaje);
            };
    }

    public async Task<bool> ConectarAsync()
    {
        return await bluetooth
            .ConectarJDY16Async();
    }

    public async Task IniciarAsync()
    {
        await bluetooth
            .EnviarAsync(
                "START");
    }

    public async Task DetenerAsync()
    {
        await bluetooth
            .EnviarAsync(
                "STOP");
    }

    public void Desconectar()
    {
        bluetooth.Desconectar();
    }
}