namespace Atena.Delegate.Lesson
{
    public class Person
    {
        public string _CF;
        public Person(string CF)
        {
            _CF = CF;
        }
    }
    public class Client : Person
    {

        public int _AccountNumber;

        public Client(Person p) : base(p._CF)
        {

        }
    }
}
