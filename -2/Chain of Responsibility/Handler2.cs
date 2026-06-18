using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

public class Handler2 : BaseHandler
{
    public Handler2()
    {
        PrivateEvent = new Event2();
        Next = new Handler3();
    }
}