using DesignPatterns.Behavioural.Observer.Publisher;

namespace DesignPatterns.Behavioural.Observer.Publisher;
public class VideoEncoder
{

    public delegate void VideoEncoderEventHandler(object source, VideoEncoderEventArgs e);
    public event VideoEncoderEventHandler? VideoEncoded;
    public Video Encode(Video video)
    {
        System.Console.WriteLine("Video encoding...");
        OnVideoEncoded(video);

        return video;
    }

    protected virtual void OnVideoEncoded(Video video)
    {
        if (VideoEncoded != null)
            VideoEncoded(this, new VideoEncoderEventArgs() { Video = video });
    }
}
