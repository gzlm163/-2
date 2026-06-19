public interface IIterator {
  object Next();
  object First();
  bool Finished();
  object Current();
}