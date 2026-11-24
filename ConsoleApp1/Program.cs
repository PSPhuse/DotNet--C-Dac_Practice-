namespace AccessSpecifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------> Access in Assembly is accessible [Public, internal,protected-internal]
            BaseClass o1 = new BaseClass();
            o1.PUBLIC = 10;
            o1.PROTECTED_INTERNAL = 20;
            Console.WriteLine($"This is Public Variable:{o1.PUBLIC}");
            Console.WriteLine($"This is Protected Internal:{o1.PROTECTED_INTERNAL}");

            //-------->Access in Derived class Accessible is [Public,Protected,Protected-internal]
            DerivedClass o2 = new DerivedClass();
            o2.getProtectedVal();
        }
    }
    public class BaseClass
    {
        public int PUBLIC;    // Access anywhere
        private static int PRIVATE;   //------>Within the same class only
        protected static int PROTECTED;  //------>same class & derived class
        internal int INTERNAL;        //-------->same class & same Assembly
        protected internal int PROTECTED_INTERNAL;        //------->same class , derived class , same Assembly
        private protected int PRIVATE_PROTECTED;        //--------->same class , derived class within same Assembly\

        /*------>1.Assembly is nothing but the byte code generated when code is compiled
          ------>2.only one Assembly is available for one project 
         */
    }

    public class DerivedClass : BaseClass
    {
        public void getProtectedVal()
        {
            Console.WriteLine(PROTECTED);
        }
    }
}
