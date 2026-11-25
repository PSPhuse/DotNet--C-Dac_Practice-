using Interfaces1;
using System.Security.Cryptography.X509Certificates;

namespace Interfaces1
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Class1 o = new Class1();

            //Method 1 of calline interface methods
            Console.WriteLine("-----------Method 1-----------");
            o.Insert();
            o.Update();
            o.Delete();
            o.Display();                 //----------->In this technique all the method od interface and class are available to call

            //Method 2 of calling interface methods
            IDBInterface oIDB;
            oIDB = o;
                                        //----------->In Method 2,3,4 only the method of interface are available to call
            Console.WriteLine("-----------Method 2-----------");
            oIDB.Insert();
            oIDB.Delete();
            //oIDB.Display();                //------>Class method is not available

            //Methof 3 of calling interface methods
            Console.WriteLine("-----------Method 3-----------");
            ((IDBInterface)o).Insert();

            Console.WriteLine("-----------Method 4-----------");
            (o as IDBInterface).Insert();
        }
    }
    public interface IDBInterface
    {
        void Insert();
        void Update();
        void Delete();
    }
    public class Class1 : IDBInterface
    {
        public void Display()
        {
            Console.WriteLine("This is Class1.Display");
        }
        public void Insert()
        {
            Console.WriteLine("This is IDB.Insert");
        }
        public void Update()
        {
            Console.WriteLine("This is IDB.Update");
        }
        public void Delete()
        {
            Console.WriteLine("This is IDB.Delete");
        }
    }
   
}

namespace Interfaces2
{
    public class Program
    {
        static void Main1()
        {
            
            Class2 o = new Class2();
            //methood 1
            o.Display();
            o.Insert();
            //o.Delete();

            //method 2
            IFileFunctions oIFile;
            oIFile = o;

            Console.WriteLine("----------------Method 2------------------");
            oIFile.Delete();

            //method 3
            Console.WriteLine("----------------Method 3------------------");
            ((IFileFunctions)o).Delete();

            //method 4
            Console.WriteLine("----------------Method 4------------------");
            (o as IDBFunctions).Delete();

            //here Method 3 & 4 is used when we call the method once but if you need to call the method continuasly must use method 2
        }
    }
    public interface IDBFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }

    public interface IFileFunctions
    {
        void Open();
        void Close();
        void Delete();
    }

    public class Class2 : IDBFunctions, IFileFunctions
    {
        /*
         In this Class we implemented two interfaces IDBFunctions and IFileFunctions. 
         Both interfaces have Delete method. 
         So we have to implement both Delete methods in Class2. 
         using explicit interface implementation we can implement both Delete methods in Class2. 
        */


        //-------------------> To avoid confusion we can use explicit interface implementation to implement both Delete methods in Class2. <------------------//
        public void Display()
        {
            Console.WriteLine("This is Class2.Display");
        }
        void IDBFunctions.Delete()
        {
            Console.WriteLine("IDB.Delete form Class2");
        }

        public void Insert()
        {
            Console.WriteLine("IDB.Insert form Class2");
        }

        public void Update()
        {
            Console.WriteLine("IDB.Update form Class2");
        }

        void IFileFunctions.Delete()
        {
            Console.WriteLine("IFile.Delete form Class2");
        }
        public void Open()
        {
            Console.WriteLine("IFile.Open form Class2");
        }
        public void Close()
        {
            Console.WriteLine("IFile.Close form Class2");
        }
    }
}

namespace Interfaces3
{
    public class Program
    {
        public static void Main()
        {
            Class3 o1 = new Class3();
            Class4 o2 = new Class4();

            IDBFunction oIDB;
            oIDB = o1;
            oIDB.Insert();

            oIDB = o2;
            oIDB.Insert();

            //Insted of calling individual method we can create one method which will take
            //interface reference as parameter and call the method of interface

            //Console.WriteLine("----------Calling method using interface reference as parameter----------------");
            static void InsertObject(IDBFunction oIDB)
            {
                Console.WriteLine("Calling Insert method through interface reference:");
                oIDB.Insert();
            }

            InsertObject(o1);
            InsertObject(o2);
        }
    }
    public interface IDBFunction
    {
        void Insert();
        void Update();
        void Delete();
    }

    public class Class3 : IDBFunction
    {
        public void Insert()
        {
            Console.WriteLine("IDB.Insert form Class3");
        }
        public void Update()
        {
            Console.WriteLine("IDB.Update form Class3");
        }
        public void Delete()
        {
            Console.WriteLine("IDB.Delete form Class3");
        }
    }

    public class Class4 : IDBFunction
    {
        public void Insert()
        {
            Console.WriteLine("IDB.Insert form Class4");
        }
        public void Update()
        {
            Console.WriteLine("IDB.Update form Class4");
        }
        public void Delete()
        {
            Console.WriteLine("IDB.Delete form Class4");
        }
    }
}