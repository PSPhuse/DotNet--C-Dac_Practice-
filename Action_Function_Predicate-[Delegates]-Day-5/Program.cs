namespace Action_Function_Predicate__Delegates__Day_5
{
    //Step 1: Create an Delegate Class having same signiture of calling function
    
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            There is preDefine Delegets Created to call the method through delegates
            Three types of Inbuilt Delegets
            1.Action------->Called the void return type Function
            2.func -------->Called the non void return Function with the parameter
            3.Predicate ------>Called the Boolean return typr Function
            */

            Action deleDispaly = Display;       //to call non parameters function
            deleDispaly();

            Action<string> delewithPara = Display;       //Action<parameter type>--->to accept parameter
            delewithPara("Msg form User");               //it accept 0-16 parameter with no return type

            Func<String> funcMsg = DispMessage;            //Func<string> --->Use to call non void return type with no parameter 
            Console.WriteLine("Func With No Parameter:"+funcMsg());

            Func<int, int> funcDelegate = MakeDouble;       //Func<int,int> use to return specific value with 0-16 parameters
            Console.WriteLine("Func With 1 Parameter:" + funcDelegate(25));

            Func<int, int, int> funcAdd = Add;
            Console.WriteLine("Func With 2 Parameter:" + funcAdd(2, 3));

            Predicate<int> PreDelegate = isEven;            //Predicate<> use to return Boolean value with one Parameter
            Console.WriteLine("Predicate with 1 parameter & return always Boolen Value :"+PreDelegate(25));

            Func<int, bool> PreDelegate1 = isEven;          //We can also call boolean Returning function with the help of FUNC delegate
            Console.WriteLine("We can also call boolean returning function With FUNC :"+PreDelegate1(24));

            Predicate<Employee> emp = isGreaterBasic;
            Console.WriteLine("Employee Class: "+emp(new Employee { Basic = 50000}));
            Console.WriteLine("Employee Class: " + emp(new Employee { Basic = 5000 }));

        }
        public static void Display()
        {
            Console.WriteLine("This is Display form Action Delegates..");
        }
        public static void Display(string msg)
        {
            Console.WriteLine($"Method with Parameter:{msg}");
        }
        public static string DispMessage()
        {
            return "This is Func Delegate Use to Call Specific return Type";
        }
        public static int MakeDouble(int a)
        {
            return a*2;
        }
        public static int Add(int a,int b)
        {
            return a + b;
        }
        public static bool isEven(int num)
        {
            return (num % 2 == 0);
        }

        //Employee Class
        static bool isGreaterBasic(Employee e)
        {
            return (e.Basic > 10000);
        }

    }

    //Q.Create the delegate to call the isBasic(Employee e) which can return the boolean vaue if the (basic salary > 10000) true

    public class Employee
    {
        public int EmpId { get; set; }
        public double Basic { get; set; }

        //public bool isBasic(Employee e)
        //{
        //    return (e.basic > 10000);
        //}
    }

}
