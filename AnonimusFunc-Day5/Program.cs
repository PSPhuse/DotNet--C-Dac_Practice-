namespace AnonimusFunc_Day5
{
    /*
        -To create Anonimus function we need Deledate
        -With the help of Delegate we call the Anonimous Function
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Action AnonFunction = delegate ()         //Creating Anonimus Function with no parameter
            {
                Console.WriteLine("this is Anonimus Function");
            };

            AnonFunction();             //Calling Anonimus Function
            
            Action<string> AnonParameter = delegate(string msg)
            {
                Console.WriteLine($"Msg From User :"+msg);
            };
            AnonParameter("Hii....");

            Func<string,int, string> AnonFunction1 = delegate (string num,int msg)
            {

                return num+msg;
            };
            Console.WriteLine("This is FUNC Delegate:"+AnonFunction1("Hii",111));
        }
        
        
    }
}
