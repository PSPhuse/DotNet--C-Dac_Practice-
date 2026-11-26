using System.Collections;

namespace WorkWithCollections_Day_4
{
    internal class Program
    {
        static void Main()
        {
            ArrayList o2 = new ArrayList() { 1,2,3};
            ArrayList ar = new ArrayList();
            ar.Add(25);
            ar.Add("aaa");
            ar.Add(true);

            ar.Insert(0,"This is IndexOf Method");
            ar.AddRange(o2);
            ar.InsertRange(0, o2);

            ar.Remove("aaa");
            ar.RemoveAt(0);
            ar.RemoveRange(0,3);

            //ArrayList reverse = new ArrayList();

            foreach (object val in ar)            //Iterate an Array List
            {
                Console.Write(val+" ");
            }

            
            //ar.Clear();

            Console.WriteLine(ar.Contains(25));
                          //---->it 

            Console.WriteLine(ar.Count);

            //reverse mathod
            ar.Reverse();
            foreach (object val in ar)            //Iterate an Array List
            {
                Console.Write(val+" ");
            }
            //int[] array = new int[10];
            //ar.CopyTo(array, 2);
            
        }
    }
}
