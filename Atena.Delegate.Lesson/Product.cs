namespace Atena.Delegate.Lesson
{
    public abstract class Product
    {
        public abstract string Name { get; }
        public abstract string Ticker { get; }
    }
    public class Stock : Product
    {
        string _name;
        string _ticker;
        public override string Name { get { return _name; } }
        public override string Ticker { get { return _ticker; } }
    }
    public class Cash : Product
    {
        string _name;
        string _ticker;
        public override string Name { get { return _name; } }
        public override string Ticker { get { return _ticker; } }
    }
    public class Crypto : Product
    {
        string _name;
        string _ticker;
        public override string Name { get { return _name; } }
        public override string Ticker { get { return _ticker; } }
    }
}
