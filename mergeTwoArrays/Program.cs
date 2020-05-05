using System;

namespace mergeTwoArrays
{
    class Program

        //Given 2 sorted arrays, A and B, where A 
        //is long enough to hold the contents of A and B,
        //write a function to copy the contents of B into A
        //without using any buffer or additional memory.

    {
        static void Main()
        {
            static void MergeTwoArrays(int[] a,int[] b, int aLength, int bLength) 
            {
                if (aLength + bLength > a.Length)
                    Console.WriteLine("A array is not long enough");

                int i = aLength - 1;
                int j = bLength - 1;
                int k = aLength + bLength - 1;

                while (i >=0 && j>=0)
                {
                    if (a[i] > b[j])
                    {
                        a[k] = a[i];
                        i--;
                    }
                    else 
                    {
                        a[k] = b[j];
                        j--;
                    }

                    k--;
                }

                while (j>=0)
                {
                    a[k] = b[j];
                    j--;
                    k--;
                }



                Console.WriteLine(string.Join(", ", a));
            }

            int[] a_Array = { 2, 5, 9, 0, 0 };
            int[] b_Array = { 4, 8 };

            MergeTwoArrays(a_Array, b_Array, 3, 2);
            Console.ReadKey();
        }
    }
}
