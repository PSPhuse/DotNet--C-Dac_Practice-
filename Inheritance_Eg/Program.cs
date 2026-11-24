namespace Inheritance_Eg
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            DerivedClass o1 = new DerivedClass();
            o1.A = 1;
            Console.WriteLine(o1.B);
            Console.WriteLine(o1.A);
            
        }
    }
    public class BaseClass:Object  //:Object ----------->this class by default inherite the object class
    {
        public int A { get; set; }
        public int B { get; set; }  
    }
    public class DerivedClass : BaseClass   
    {
        public string C { get; set; }
        public string D { get; set; }
    }
}

namespace ConstructorInnheritance
{
    class Program
    {
        public static void Main()
        {
            DerivedClass o1 = new DerivedClass();         //--------->Calling no parametrise const
            DerivedClass o2 = new DerivedClass(12,25);    //----->this call parametrise of derived class and no parametrise of base class const
            Console.WriteLine(o2.i);
            Console.WriteLine(o2.j);
            //------>To call parametrise constructor of base class we need to specify while writing the constructor
            DerivedClass o3 = new DerivedClass(121, 13, 14);
            Console.WriteLine(o3.i);
            Console.WriteLine(o3.j);

            //o1 = null;
            //o2 = null;

            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //Console.WriteLine("Called Finally.............->");
        }
    }
    public class BaseClass
    {
        public int i;
        public BaseClass()
        {
            Console.WriteLine("This is No Paramaterise Constructor of Base Class");
            i = 100;
        }
        public BaseClass(int i)
        {
            Console.WriteLine("This is Parametrise Const of Base Class");
            this.i = i;
        }

    }
    public class DerivedClass : BaseClass
    {
        public int j;
         public DerivedClass()
         {
            Console.WriteLine("This is Derived Class Const with no Parameter");
            j = 500;
         }
        public DerivedClass(int i,int j)
        {
            Console.WriteLine("This is Derived Class Const with Parameter");
            this.j = j;
        }
        public DerivedClass(int i, int j,int k) : base(i)          //----->Calling Base class Parametrise Constructor using [base(i)]Keyword
        {
            Console.WriteLine("This is Derived Class Const with Parameter");
            this.j = j;
        }

        ~DerivedClass()
        {
            Console.WriteLine("Called desc");
        }
    }
}