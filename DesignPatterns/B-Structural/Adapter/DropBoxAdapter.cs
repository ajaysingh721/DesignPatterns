namespace DesignPatterns.Structural.Adpter;

public class DropBoxAdapter : IDownloder
{
    public byte[] Download(string fileName)
    {
        var dropBox = new DropBox();
        var credentials = dropBox.Signin("username", "password");
        var file = dropBox.Download(credentials, fileName);

        return file;
    }
}

