using DesignPatterns.Observer.Publisher;

namespace DesignPatterns.Observer.Services;
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