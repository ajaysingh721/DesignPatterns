using DesignPatterns.Observer.Publisher;

namespace DesignPatterns.Observer.Services;

public class SMSService : IServices
{
    public void OnVideoEncoded(object source, VideoEncoderEventArgs e)
    {
        this.Send(e.Video?.Title ?? "");
    }

    public virtual string Send(string text)
    {
        System.Console.WriteLine($"Text Sending ... {text}");

        return "SMS Sent";
    }
}