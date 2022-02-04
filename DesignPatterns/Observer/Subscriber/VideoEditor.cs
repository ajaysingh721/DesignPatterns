using DesignPatterns.Observer.Publisher;
using DesignPatterns.Observer.Services;

namespace DesignPatterns.Observer.Subscriber;

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