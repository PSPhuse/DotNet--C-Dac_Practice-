namespace ExtensionMethod_Day_5
{
    //When method is Extend to Base class Extended method should be available to all Derived class
    //When Method is Exthended to any Interface it should be available for the all implementing class
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Extension Method in PreDefine Class-----------");
            int i = 10;
            i.Add(20);
            i.Display();

            string s = "Hi";
            s.Show();
            s.Show1(s);
            Console.WriteLine();

            Console.WriteLine("----------Extended to Classes--------------");
            Program p1 = new Program();
            p1.ObjExtension("Bhag Lavde");

            ClsMath obj = new ClsMath();
            obj.GenerateN(5);

            Console.WriteLine();
            Console.WriteLine("-----------Extension Method in Interface-----------------");
            ClsMath obj1 = new ClsMath();
            Console.WriteLine("Method form Class:"+obj1.Add(12, 30));

            Console.WriteLine("Extension Method to Interface :"+obj1.Substract(21, 12));
            Console.WriteLine("Extension Division Method :"+obj1.Division(10,0));

            Console.WriteLine("Method From CLass :"+obj1.Mul(12,30));
        }
    }
    //create a static method in static class
    public static class ExtensionClass
    {
        //Extension Means add user method to specific class
        //Here we can add Method name [ADD & Display] to int Class

        //To add method First parameter should be Type you want to extend,
        //preceded by 'this' Keyword
        public static int Add(this int i,int j)
        {
            Console.WriteLine("Method Called..");
            return i + j;
        }
        public static void Display(this int i)
        {
            Console.WriteLine("Value of i :"+i);
        }
        public static void Show(this string s)
        {
            Console.WriteLine("Method Extend to String Class");
        }
        public static void Show1(this string s,string s1)
        {
            Console.WriteLine("S1 Method Msg is:"+s1);
        }
        //Method Extension to Object Class
        public static void ObjExtension(this object ob,string msg)
        {
            Console.WriteLine($"Method Extended to Object Class: {msg}");
        }

        //Extension Method to Program Class
        public static void GenerateN(this ClsMath p1,int n)
        {
            Console.WriteLine("This is Extended Method Generate the Table of Number");
            for(int i = 1;i<=10;i++)
                Console.WriteLine($"{n}*{i}={n*i}");
        }

        //Method Extension in Interface
        public static int Substract(this IMathOperation op,int a,int b)
        {
            return a - b;
        }
        public static int Division(this IMathOperation op,int a,int b)
        {
            try
            {
                return a / b;
            }
            catch(ArithmeticException)
            {
                Console.WriteLine("Please enter Non Zero Value");
                return 0;
            }
        }
    }

    public interface IMathOperation
    {
        int Add(int a, int b);
        int Mul(int a, int b);
    }
    public class ClsMath : IMathOperation
    {
        public int Add(int a,int b)
        {
            return a + b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
}
