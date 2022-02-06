namespace DesignPatterns.Behavioural.Observer.Publisher;
public class VideoEncoderEventArgs : EventArgs
{
    public Video? Video { get; set; }
}