using static System.Net.Mime.MediaTypeNames;

public class Handler5 : BaseHandler
{
    public Handler5()
    {
        PrivateEvent = new Event5();
        Next = null;
    }
}