public class Handler4 : BaseHandler {
  public Handler4() {
    PrivateEvent = new Event4();
    Next = new Handler5();
  }
}