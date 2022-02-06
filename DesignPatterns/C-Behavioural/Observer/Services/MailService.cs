using DesignPatterns.Behavioural.Observer.Publisher;

namespace DesignPatterns.Behavioural.Observer.Services;
public class EmailService : IServices
{
    public void OnVideoEncoded(object source, VideoEncoderEventArgs e)
    {
        this.Send(e.Video?.Title ?? "");
    }

    public virtual string Send(string text)
    {
        System.Console.WriteLine($"Email Sending ... {text}");

        return "Email Sent";
    }
}