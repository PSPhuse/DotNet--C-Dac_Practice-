namespace Delegates_Eg_Day_4
{
    //Step 1: Create an Delegate Class with same signiture of function to call
    public delegate void Del1();
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Step 2:Create an Delegate Reference 
            //Create an deleget object and pass Function name to call
            Del1 delReference = new Del1(Display);
            //Step 3:Call the Deleget reference
            delReference();
            Console.WriteLine("........................Method1");

            //Insted of passing Function name as parameter we can assign Function name to reference of deleget
            Del1 delReference2 = Display;
            delReference();
            Console.WriteLine("........................Method2");

            //if we directly assign second it will replace the first object pointer with second pointer
            delReference = Show;
            delReference();
            Console.WriteLine("........................Check3");
            //Multycast Delegets can be refer to more than one Objects At a time
            delReference2 += Show;
            delReference2();
            Console.WriteLine("........................Method3");
        }
        static void Display()
        {
            Console.WriteLine("This is Display.....");
        }
        static void Show()
        {
            Console.WriteLine("This is Show....");
        }
        public delegate int delAdd(int a, int b);
        public static void Main()
        {
            delAdd delAddRef = Add;
            Console.WriteLine("Addition:" + delAddRef(10, 20));
            delAdd delSubRef = Subtract;
            Console.WriteLine("Substraction:" + delSubRef(20, 10));

            delSubRef += Add;           //+= operator is only work with non returning function delegate
            Console.WriteLine("Addition:" + delAddRef(20, 20));


            //Calling the Delegets Via passing function as parameter
            Console.WriteLine("Called by Function:" + functionCall(Add));
            Console.WriteLine("One parameter:"+functionCall(Subtract));
                       
            Console.WriteLine("3 parameter:"+FunctionCall2(Add,89,10));
            Console.WriteLine("3 parameter:" + FunctionCall2(Subtract, 89, 10));

        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int functionCall(delAdd refAdd)
        {
            return refAdd(10, 20);
        }
        public static int FunctionCall2(delAdd refAdd, int a, int b)
        {
            return refAdd(a, b);
        }
    }
    
}
