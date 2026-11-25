namespace Inheritance_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Male o1 = new Male();
            o1.Eat();
            o1.Work();
            o1.Sleep();

            Console.WriteLine("----------------------------");
            Female o2 = new Female();
            o2.Eat();
            o2.Cook();
            o2.Sleep();
        }
        //In this Example Interface is inheriting another interface
        //like Man and Woman is inherithng Human interface

        //and Class Male and Female is implementing Man and Woman interface respectively
    }

    public interface Human
    {
        void Eat();
        void Sleep();
    }

    public interface Man : Human
    {
        void Work();
    }

    public interface Woman : Human
    {
        void Cook();
    }
    public interface Ileabian : Human
    {

    }

    public class Male : Man
    {
        public void Eat()
        {
            Console.WriteLine("Male is Eating");
        }
        public void Sleep()
        {
            Console.WriteLine("Male is Sleeping");
        }
        public void Work()
        {
            Console.WriteLine("Male is Working");
        }
    }
    public class Female : Woman
    {
        public void Eat()
        {
            Console.WriteLine("Female is Eating");
        }
        public void Sleep()
        {
            Console.WriteLine("Female is Sleeping");
        }
        public void Cook()
        {
            Console.WriteLine("Female is Cooking");
        }
    }
}
