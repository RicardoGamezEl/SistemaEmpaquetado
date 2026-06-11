using System.Text;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Storage.Streams;

namespace SistemaEmpaquetado.Services;

public class BluetoothManager
{
    private BluetoothLEDevice? device;
    private GattCharacteristic? uartCharacteristic;

    public event Action<string>? MensajeRecibido;

    public bool Conectado =>
        device != null &&
        uartCharacteristic != null;

    private readonly Guid SERVICE_UUID =
    Guid.Parse(
        "0000FFE0-0000-1000-8000-00805F9B34FB");

    private readonly Guid CHARACTERISTIC_UUID =
        Guid.Parse(
            "0000FFE1-0000-1000-8000-00805F9B34FB");

    public async Task<bool> ConectarAsync(
    ulong bluetoothAddress)
    {
        device =
            await BluetoothLEDevice
                .FromBluetoothAddressAsync(
                    bluetoothAddress);

        if (device == null)
            return false;

        var servicesResult =
            await device.GetGattServicesAsync();

        var service =
            servicesResult.Services
                .FirstOrDefault(
                    s => s.Uuid ==
                         SERVICE_UUID);

        if (service == null)
            return false;

        var charsResult =
            await service
                .GetCharacteristicsAsync();

        uartCharacteristic =
            charsResult.Characteristics
                .FirstOrDefault(
                    c => c.Uuid ==
                         CHARACTERISTIC_UUID);

        if (uartCharacteristic == null)
            return false;

        uartCharacteristic.ValueChanged +=
            Characteristic_ValueChanged;

        await uartCharacteristic
            .WriteClientCharacteristicConfigurationDescriptorAsync(
                GattClientCharacteristicConfigurationDescriptorValue.Notify);

        return true;
    }
    private void Characteristic_ValueChanged(
    GattCharacteristic sender,
    GattValueChangedEventArgs args)
    {
        var reader =
            DataReader.FromBuffer(
                args.CharacteristicValue);

        byte[] bytes =
            new byte[
                reader.UnconsumedBufferLength];

        reader.ReadBytes(bytes);

        string mensaje =
            Encoding.UTF8.GetString(
                bytes);

        MensajeRecibido?.Invoke(
            mensaje.Trim());
    }
    public async Task EnviarAsync(
    string mensaje)
    {
        if (uartCharacteristic == null)
            return;

        var writer =
            new DataWriter();

        writer.WriteString(
            mensaje + "\n");

        await uartCharacteristic
            .WriteValueAsync(
                writer.DetachBuffer(),
                GattWriteOption
                    .WriteWithoutResponse);
    }
    public void Desconectar()
    {
        device?.Dispose();

        device = null;

        uartCharacteristic = null;
    }
    public async Task<ulong?> BuscarJDY16Async()
    {
        ulong? direccion = null;

        var watcher =
            new BluetoothLEAdvertisementWatcher();

        var tcs =
            new TaskCompletionSource<ulong?>();

        watcher.Received +=
            (sender, args) =>
            {
                string nombre =
                    args.Advertisement.LocalName;

                if (nombre == "JDY-16")
                {
                    direccion =
                        args.BluetoothAddress;

                    tcs.TrySetResult(
                        direccion);

                    watcher.Stop();
                }
            };

        watcher.Start();

        var completedTask =
            await Task.WhenAny(
                tcs.Task,
                Task.Delay(10000));

        watcher.Stop();

        if (completedTask == tcs.Task)
            return await tcs.Task;

        return null;
    }
    public async Task<bool> ConectarJDY16Async()
    {
        ulong? direccion =
            await BuscarJDY16Async();

        if (direccion == null)
            return false;

        return await ConectarAsync(
            direccion.Value);
    }
}