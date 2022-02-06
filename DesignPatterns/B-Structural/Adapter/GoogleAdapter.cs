namespace DesignPatterns.Structural.Adpter;

public class GoogleAdapter : IDownloder
{
    public byte[] Download(string fileName)
    {
        var drive = new GoogleDrive();
        var clientSecret = drive.Signin("client_secret");
        var stream = drive.Download(clientSecret, fileName);

        return (stream as MemoryStream).ToArray();
    }
}

