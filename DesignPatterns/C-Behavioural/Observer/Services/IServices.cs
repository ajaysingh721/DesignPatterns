using DesignPatterns.Behavioural.Observer.Publisher;

namespace DesignPatterns.Behavioural.Observer.Services
{
    public interface IServices
    {
        string Send(string text);
        void OnVideoEncoded(object source, VideoEncoderEventArgs e);
    }
}