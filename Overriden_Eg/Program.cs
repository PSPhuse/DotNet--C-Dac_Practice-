namespace Overriden_Eg
{
    //------------>1.Overloading 2.Hidding 3.Overriding <----------------//
    internal class Program
    {
        static void Main(string[] args)
        {
            //DerivedClass o1 = new DerivedClass();
            //o1.Display1();                //----->Available From both classes Base & Derived
            //o1.Display1("param");

            BaseClass o2;      //------>Creating an reference
            o2 = new BaseClass();  //------>Creating an object

            o2.Display2();                //------>it called method Depends how the reference is declared    -->it called as early binding
            o2.Display3();              //------>it called method depends on what object is reference is pointing to  -->it called as late binding

            o2 = new DerivedClass();  //------>Creating an object of derived class
            o2.Display2();        //----->Call base class method Display2
            o2.Display3();        //----->Call derived class method Display3

            o2 = new SubDerivedClass();  //------>Creating an object of subderived class
            o2.Display2();
            o2.Display3();       //----->Call subderived class method Display3 

            o2 = new subsubDerivedClass();
            o2.Display2();
            o2.Display3();        //----->Call form Subderived Class because method is stoped form overriden
        }
    }
    public class BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("This is Base Class Display1 Method");
        }
        public void Display2()
        {
            Console.WriteLine("Base Class Method Display2");
        }
        public virtual void Display3()        //------>this is virtual function can be override in derived class
        {
            Console.WriteLine("Base Class Method Display3");
        }
    }
    public class DerivedClass : BaseClass
    {
        public void Display1(string s1)  //------>Method Overloading
        {
            Console.WriteLine($"Derived Overloaded Method:{s1}");
        }

        public void Display2()  //------>Method Hidding is achived by new keyword but we can do without new keyword also (but it will give warning)
        {                         //----->any method will be hidden either it is virtual or not virtual in base class
                                   //----->it also called as early binding
            Console.WriteLine("Derived Class Method Display2");
        }
        /*
        public new void Display2() ------->is also method hidding

        public new void Display3()  //------>Virtual method hidding
        {
            Console.WriteLine("Derived Class Method Display3");
        }
        */
        public override void Display3()  //------>Virtual method overriding
        {                                //------>it is also called as late binding
            Console.WriteLine("Derived Class Method Display3");
        }
    }
    public class SubDerivedClass : DerivedClass
    {
        public new void Display2()
        {
            Console.WriteLine("This is Sub Derived Class Hidden Method");
        }
        public sealed override void Display3()  //------> sealed keyword is use to stop Virtual method overriding 
        {                                       //------>sealed keyword is only use with override keyword
            Console.WriteLine("Sub Derived Class Method Display3");
        }
    }
    public class subsubDerivedClass : SubDerivedClass
    {
       public void Dispaly2()
       {

       }
        public void Dispaly3()
        {

        }
    }
}
