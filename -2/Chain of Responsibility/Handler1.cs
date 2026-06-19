public class Handler1 : BaseHandler {
  public Handler1() {
    PrivateEvent = new Event1();
    Next = new Handler2();
  }
}