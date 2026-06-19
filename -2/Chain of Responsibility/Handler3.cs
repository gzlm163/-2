public class Handler3 : BaseHandler {
  public Handler3() {
    PrivateEvent = new Event3();
    Next = new Handler4();
  }
}
