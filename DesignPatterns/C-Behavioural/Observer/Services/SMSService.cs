using DesignPatterns.Behavioural.Observer.Publisher;

namespace DesignPatterns.Behavioural.Observer.Services;

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