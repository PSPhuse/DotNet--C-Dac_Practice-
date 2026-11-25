using System.Net;

namespace Inheritance_Assignment
{
    internal class Program
    {
        static void Main1()
        {

            Car c1 = new Car(1234,"Toyota","Laxus",250,4);
            c1.DisplayDetails();

            Bike b1 = new Bike(6789, "Royal Infild", "Bullet-360", 250, "Clasic-Bike");
            b1.DisplayDetails();
        }
    }

    public class Vehicale
    {
        public int ResistrationNumber { get; set; }       //--------> auto type propertys
        public string? Brand { get;set; }             //-------> ? operator to make string nullable
        public string? Model { get; set; }
        public decimal Speed { get; set; }

        public Vehicale(int rn, string b, string m, decimal s)
        {
            ResistrationNumber = rn;
            Brand = b;
            Model = m;
            Speed = s;
        }
        public void Start()
        {
            Console.WriteLine("Vehicale has Started");
        }
        public void Stop()
        {
            Console.WriteLine("Vehicale has Stopped");
        }
        public virtual void DisplayDetails()                    //----------->to override into derived class
        {
            Console.WriteLine("------->Vehicale Details<---------");
            Console.WriteLine($"Resistration Number:{ResistrationNumber}");
            Console.WriteLine($"Brand:{Brand}");
            Console.WriteLine($"Model:{Model}");
            Console.WriteLine($"Speed:{Speed}");
        }
    }
    public class Car : Vehicale
    {
        public int NumberOfDoors { get; set;}

        public Car(int rn,string b,string m,decimal s,int nd) : base(rn,b,m,s)
        {
            NumberOfDoors = nd; 
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Numbers of Doores:{NumberOfDoors}");
        }
    }
    public class Bike : Vehicale
    {
        public string? BikeType { get; set; }

        public Bike(int rn, string b, string m, decimal s,string bt) : base(rn,b,m,s)
        {
            BikeType = bt;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Bike Type:{BikeType}");
        }
    }
}

namespace HirerchialInheritance_Assignment_2
{
    public class Program
    {
        public static void Main2()
        {
            Employee o1 = new PermanentEmployee(123,"Parshuram",50000);
            double sal = o1.CalculateSalary();
            Console.WriteLine($"Permanent Emp Salary is:{sal}");

            Employee o2 = new ContractEmployee(456, "asd", 25000);
            Console.WriteLine($"Contract Employee Salary:{o2.CalculateSalary()}");

            Employee o3 = new PartTimeEmployee(789, "zxc", 15000, 10, 250);
            Console.WriteLine($"Contract Employee Salary:{o3.CalculateSalary()}");
        }

    }
    //EmployeeID,EmployeeName,BasicSalary
    public abstract class Employee
    {
        protected int EmployeeID { get; set; }
        protected string? EmployeeName { get; set; }
        protected double BasicSalary { get; set; }

        public Employee(int id,string name, double salary)
        {
            EmployeeID = id;
            EmployeeName = name;
            BasicSalary = salary;
        }
        public abstract double CalculateSalary();
    }
    //PermanentEmployee
//- ContractEmployee
//- PartTimeEmployee

    public class PermanentEmployee : Employee
    {
        private double hra;
        private double da;

        public PermanentEmployee(int id, string name, double salary) : base(id,name,salary)
        {
            
        }
        public override double CalculateSalary()
        {
            hra = BasicSalary * 0.20;
            da = BasicSalary * 0.10;

            return BasicSalary + hra + da;
        }
    }
    public class ContractEmployee : Employee
    {
        private double hra;

        public ContractEmployee(int id, string name, double salary) : base(id, name, salary)
        {

        }
        public override double CalculateSalary()
        {
            hra = BasicSalary * 0.10;
            return BasicSalary + hra;
        }

    }
    public class PartTimeEmployee : Employee
    {
        int hw;
        double rate;

        public PartTimeEmployee(int id, string name, double salary,int hw, double rate) : base(id,name, salary)
        {
            this.hw = hw;
            this.rate = rate;
        }
        public override double CalculateSalary()
        {
            return BasicSalary + hw * rate;
        }
    }
}


namespace Interfaces_Assignment_3
{
    public class Program
    {
        public static int? Id { get; set; }
        public static string? Name { get; set; }
        public static double Amount { get; set; }
        public static void Main()
        {
            //Console.WriteLine("Enter Order Id");
            //id = Console.ReadLine();

            Order o1 = new Order(111,"Biryani",250);

            UPI o2 = new UPI();
            CreditCard o3 = new CreditCard();
            NetBanking o4 = new NetBanking();
            //o2.DispalyPaymentDetails();
            //o2.MakePayment(2500);

            o1.Checkout(o3);

            o1.Checkout(o2);
            o2.ProcessRefund(500);
            
            o1.Checkout(o4);
            o4.ProcessRefund(100);

            //Id = Convert.ToInt32(Console.ReadLine());
        }
    }
    //MakePayment(double amount)
    //- DisplayPaymentDetails()
    public interface IPayment
    {
        void MakePayment(double amount);
        void DispalyPaymentDetails();
    }
    public interface IRefund
    {
        void ProcessRefund(double amount);
    }

    /*
    - CreditCard
    - UPI
    - NetBanking
    */

    public class CreditCard : IPayment
    {
        public void DispalyPaymentDetails()
        {
            Console.WriteLine("Bill is Paid Using CreditCard");
        }

        public void MakePayment(double amount)
        {
            Console.WriteLine($"Total amount of Bill is:{amount}");
        }
    }
    public class UPI : IPayment, IRefund
    {
        public void DispalyPaymentDetails()
        {
            Console.WriteLine("Bill is Paid Using UPI");
        }

        public void MakePayment(double amount)
        {
            Console.WriteLine($"Total amount of Bill is:{amount}");
        }

        public void ProcessRefund(double amount)
        {
            Console.WriteLine("Amount is Refunded into next 24 hours");
        }
    }
    public class NetBanking : IPayment, IRefund
    {
        public void DispalyPaymentDetails()
        {
            Console.WriteLine("Bill is Paid Using NetBanking");
        }

        public void MakePayment(double amount)
        {
            Console.WriteLine($"Total amount of Bill is:{amount}");
        }

        public void ProcessRefund(double amount)
        {
            Console.WriteLine("Amount is Refunded into next 24 hours");
        }
    }
    /*
        - OrderId
        - CustomerName
        - OrderAmount
    */
    public class Order
    {
        public int OrderId { get; set; }
        public string? CustomerName { get; set; }
        public double OrderAmount { get; set; }

        public Order(int id,string name,double amount)
        {
            OrderId = id;
            CustomerName = name;
            OrderAmount = amount;
        }
        public void Checkout(IPayment payment)
        {
            Console.WriteLine("------------>Order Details<-----------------");
            Console.WriteLine($"Order Id:{OrderId}");
            Console.WriteLine($"Customer Name:{CustomerName}");
            Console.WriteLine($"Order Amount:{OrderAmount}");
            payment.DispalyPaymentDetails();
            payment.MakePayment(OrderAmount);
            
            Console.WriteLine("Thank You........Visite Again");
        }
    }
}