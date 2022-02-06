namespace DesignPatterns.Structural.Adpter;

public class DownloadApp
{
    public byte[] DownloadResume(string fileName)
    {
        var downloader = GetInstance<IDownloder>();
        return downloader.Download(fileName);
    }

    private IDownloder GetInstance<T>()
    {
        return new GoogleAdapter();
    }
}
