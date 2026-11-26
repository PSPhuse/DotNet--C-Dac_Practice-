namespace WorkWithArray_Day_4
{
    internal class Program
    {
        static void Main()
        {
            //Array1D();
            Array2D();
        }

        public static void Array1D()
        {
            int[] arr = new int[5];

            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };             //----->Array with initial value
            int[] arr2 = new int[] { 0, 12, 4, 5, 21, 87, 8, 9, 6, 21, 4 };

            //To store element in array
            //for(int i=0;i<arr.Length;i++)
            //{
            //    Console.Write("Enter element for arr["+i+"]");
            //    arr[i] = int.Parse(Console.ReadLine()!);               //Console.ReadLine()  -->Always take string as an input 
            //                                                          //to take integer as input we need to parse string to integer
            //}
            ////to print an array
            //foreach(int value in arr)
            //{
            //    Console.WriteLine(value);
            //}

            int pos = Array.IndexOf(arr1, 5);       //----->return position of given element
            Console.WriteLine(pos);

            Console.WriteLine(Array.LastIndexOf(arr2, 21));           //--------->return last position of given element

            Console.WriteLine(Array.BinarySearch(arr1, 3));        //------>return -ne random number if element not found

            Array.Copy(arr1, arr, arr1.Length);
            Console.WriteLine("--------Copy Function---------");
            foreach (int value in arr)
            {
                Console.WriteLine(value);
            }

            //int[] constArray = new int[] {};

            //Array.ConstrainedCopy(arr1, 0, constArray, 5, 6);
            //Console.WriteLine("--------Constrained Copy Function-----------");
            //foreach (int value in constArray)
            //{
            //    Console.WriteLine(value);
            //}

        }

        public static void Array2D()
        {
            int[,] arr = new int[3,3];

            /*
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.Write($"Enter element for arr[{i},{j}] :");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            //foreach(int value in arr)
            //{
            //    Console.Write(value);
            //}

            */

            int[,] arr1 = new int[3, 2] { { 1, 2 }, { 4, 5 }, { 5, 6 } };
            Console.WriteLine(arr.GetUpperBound(0));        //-------->it return Last index 
            Console.WriteLine(arr.GetLowerBound(1));        //------>it always return 0

            Console.WriteLine(arr.Rank);              //----------->it returns Dimension of array


        }
    }
   
}
