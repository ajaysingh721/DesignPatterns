namespace DesignPatterns.Creational.Factory.SimpleFactory;

public class DeviceFactory
{
    private DeviceType _deviceType;
    public DeviceFactory(DeviceType deviceType)
    {
        _deviceType = deviceType;
    }
    public IDevice Create()
    {
        switch (_deviceType)
        {
            case DeviceType.Alexa:
                return new Alexa();
            case DeviceType.Cortana:
                return new Cortana();
            case DeviceType.GoogleAssistant:
                return new GoogleAssistant();
            default:
                return new Alexa();
        }
    }
}
