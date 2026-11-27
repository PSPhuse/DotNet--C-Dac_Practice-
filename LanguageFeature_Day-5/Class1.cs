using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    public partial class Class1
    {
        public int k;
        public void MethodFrom()
        {
            Console.WriteLine("Method from another File");
        }
    }
    public partial class Class1
    {
        public int l;
    }
}

namespace PartialMethods
{
    public partial class PartialClass
    {
        partial void anotherFile()
        {
            Console.WriteLine("This is From another class but in same namespace and same Assembly");
        }

    }
}
