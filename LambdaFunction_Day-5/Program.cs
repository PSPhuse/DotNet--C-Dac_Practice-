namespace LambdaFunction_Day_5
{
    /*
    Lambda is an Anonimous Function  
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Action Lambda0 = () => Console.WriteLine("This is Non Parameterise Lambda Function");
            Lambda0();

            Action<string, int> LambdaPara = (s, i) => Console.WriteLine("This is Parameterise lambda Function:"+s + i);
            LambdaPara("Hello", 65);

            Func<int, int, int> Lambda1 = (a, b) => (a + b);
            Console.WriteLine("This is Addition :"+Lambda1(2,3));

            Func<string> getDate = () => (DateTime.Now.ToString());
            Console.WriteLine("Current Date and Time: " + getDate());


        }

    }
}
