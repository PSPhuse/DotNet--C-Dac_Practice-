namespace LanguageFeature_Day_5
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //'Var' is Implicit Data Type Declaration
            // Used only for local Variable
            // cant be use as Class level vars, function parameter and return type
            var a = 20;
           
            a = 500;                     //we can reassign the same datatype value only it assign when it declare
            
            //a = "aaa"; Different type of value is not 
            Console.WriteLine("Initial Value :" + a);
            Console.WriteLine("Type of Variable: "+a.GetType());

            var s = "asd";
            Console.WriteLine("Second Variable :"+s);

            //s = 44;        Error
            s = "zxc";
            Console.WriteLine("Type of Var :"+s.GetType());
        }
    }
}

namespace AnonymousType
{
    //Anonymous Class is nothing but it does not have any name
    //Class with no Name is called anonymous class
    public class Program
    {
        public static void Main2()
        {
            var obj = new { a = 20, b = "asd", c = true };  //this is anonymous Class

            Console.WriteLine("Anonymous Class :"+obj.GetType());
            Console.WriteLine("Type of Variable a :"+obj.a.GetType());
            Console.WriteLine("A :"+obj.a);
            Console.WriteLine("B :"+obj.b);
            Console.WriteLine("C :"+obj.c);
            Console.WriteLine();
            var obj2 = new { a = "zxc", b = true, c = 5.5 };
            Console.WriteLine("Anonymous Class: "+obj2.GetType());

            Console.WriteLine(obj.GetType() == obj2.GetType());

            var obj3 = new { a = 23,b = true,c = "abd", d = 5.5 };
            Console.WriteLine("\nAnonymous Class :"+obj3.GetType());
        }
    }
}

namespace PartialClass
{
    public class Program
    {
        public static void Main1()
        {
            Class1 obj = new Class1();

            obj.i = 25;
            obj.j = 25;
            obj.k = 45;
            obj.MethodFrom();

        }
    }
    //Partial Class is part of the class which is defined in multiple files
    //Partial Class must be in same Assembly
    //Partial Class must be in same nameSpace
    //Partial Class must have same name;
    public partial class Class1
    {
        public int i;
    }
    public partial class Class1
    {
        public int j;
    }
}

namespace PartialMethods
{
    public class Program
    {
        public static void Main()
        {
            PartialClass obj = new PartialClass();
            Console.WriteLine(obj.Chack());
        }
    }
    //Partial Method can only be define within a partial classes
    //Partial Method Must be return a Void
    //partial Method can be static or instance lavel
    //Partial Methood Can not have 'out' parameter
    //Partial Method are always implicitly private

    public partial class PartialClass
    {
        private bool isValid = false;
        partial void Validate();
        partial void anotherFile();
        public bool Chack()
        {
            Validate();
            anotherFile();
            return isValid;
        }
    }
    public partial class PartialClass
    {
        partial void Validate()
        {
            isValid = true;
        }
    }
}