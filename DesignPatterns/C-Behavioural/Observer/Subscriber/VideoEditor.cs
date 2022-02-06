using DesignPatterns.Behavioural.Observer.Publisher;
using DesignPatterns.Behavioural.Observer.Services;

namespace DesignPatterns.Behavioural.Observer.Subscriber;

public class VideoEditor
{
    private readonly Video video;

    public VideoEditor(Video video)
    {
        this.video = video;
    }

    public Video EncodeVideo(IServices services)
    {
        var videoEncoder = new VideoEncoder();

        videoEncoder.VideoEncoded += services.OnVideoEncoded;
        return videoEncoder.Encode(video);
    }
}