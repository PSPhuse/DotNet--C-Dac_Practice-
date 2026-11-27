namespace EventHandling_Day_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o1 = new Class1();        //-------->User Area
            o1.InValidP1 += obj_EventHandlerFunction;           //---------->Assign the Event Handling Function reference to event
            o1.P1 = 10;
            Console.WriteLine(o1.P1+"\n");

            Class2 o2 = new Class2();
            o2.PrimeNo += PrimeEventHandler;
            //o2.PrimeNo += obj_EventHandlerFunction;
            o2.Num = -4;
            Console.WriteLine(o2.Num);
        }
        private static void obj_EventHandlerFunction()              //-------->Function to Handle Event
        {
            Console.WriteLine("Event Handle Here...");
        }

        private static void PrimeEventHandler(int InvalidValue)
        {
            Console.WriteLine("This is Parametrise Event Handler:"+InvalidValue);
        }
    }
    //Step 1 : Create the delegate class with same signiture of the related event
    public delegate void InvalidP1Event();
    public class Class1
    {
        //Step 2: declare the event of the delegate type
        public event InvalidP1Event InValidP1;
        private int p1;
        public int P1 
        { 
            get
            {
                return p1;
            }
            set
            {
                if(value > 100)
                    p1 = value;
                else
                {
                    //Step :3 raise an event
                    if(InValidP1 != null)
                        InValidP1();
                }
            }
        }
    }
    //Create the delegate class of same signature of event
    public delegate void CheckEvent(int InvalidValue);
    public class Class2
    {
        //Create the reference of event
        public event CheckEvent PrimeNo;
        private int num;
        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                if (value > 0)
                    num = value;
                else
                {
                    if(PrimeNo != null)
                    {
                        //raise the event
                        PrimeNo(value);
                    }
                }
            }
        }
    }
}
