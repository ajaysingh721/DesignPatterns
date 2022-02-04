using DesignPatterns.Observer.Publisher;

namespace DesignPatterns.Observer.Services
{
    public interface IServices
    {
        string Send(string text);
        void OnVideoEncoded(object source, VideoEncoderEventArgs e);
    }
}