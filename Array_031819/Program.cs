using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_031819
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;

            /**************** To declare an array**************/
            //int[] a1 = new int[5];
            //int[] a2 = new int[5];

            /************populating or assigning an array***********/
            //for (int i = 0; i < 5; i++)
            //{
            //    a1[i] = x;
            //    x += 10;
            //}

            /*******************print all values of both arrays************/

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(a1[i] + " - " + a2[i]);
            //}
            //Console.ReadKey();

            /************populating array a2 with values of a1**********/

            //for (int i = 0; i < 5; i++)
            //{
            //    a2[i] = a1[i];
            //}


            /****Other way to copy data from an array to another*****/
            //int[] a1 = new int[8]; 
            //a1[0] = 10;
            //a1[1] = 12;
            //a1[2] = 10;
            //a1[3] = 7;
            //a1[4] = 8;
            //a1[5] = 12;
            //a1[6] = 7;
            //a1[7] = 12;

            //int[] new_array = a1;

            ///********Showing data in new_array********/
            //for (int i = 0; i < a1.Length; i++)
            //{

            //    Console.WriteLine(new_array[i]);
            //}
            //Console.ReadKey();

            //// other way to declare an array
            //int[] arr = new int[] { 1,2,3,4 };

            //// reading the values of an array
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.ReadKey();

            //int[] arr1 = new int[] { 10, 12, 10, 7, 8, 12, 7, 12 };
            //int[] arr2 = new int[8] { -1, -1, -1, -1, -1, -1, -1, -1 };
            //int ctrl, i, j;

            //for ( i = 0; i < arr1.Length; i++)
            //{
            //    ctrl = 1;
            //    for (j = i+1; j < arr1.Length; j++)
            //    {
            //        if (arr1[i]==arr1[j])
            //        {
            //            ctrl++;
            //            arr2[j] = 0;
            //        }
            //    }
            //    if (arr2[i]!=0)
            //    {
            //        arr2[i] = ctrl;
            //    }
            //}

            //for (i = 0; i < arr1.Length; i++)
            //{
            //    if (arr2[i]!=0)
            //    {
            //        Console.WriteLine("The number "+arr1[i]+" have appeared "+arr2[i]+" times!");
            //    }
            //}
            //Console.ReadKey();





            /***********************************************************************
                Declare two one-dimension array named array1 and array2 with size 5.
                Enter data in both of the array (enter any data you want).
                Declare another one-dimension array named array3 with size 10.
                Write code to merge data into array3 from array1 and array2.
                Write code to find the sum of odd indexes of array3.
            ************************************************************************/
            //int[] array1 = new int[5] { 1, 2, 3, 4, 5 };
            //int[] array2 = new int[5] { 6, 7, 8, 9, 10 };
            //int[] array3 = new int[10];
            //int ctrl = 0;
            //int sum = 0;
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array3[i] = array1[i];
            //    ctrl++;
            //}
            //for (int j = 0; j < array2.Length; j++)
            //{
            //    array3[ctrl] = array2[j];
            //    ctrl++;
            //}
            //for (int k = 0; k < array3.Length; k++)
            //{
            //    if (k%2!=0)
            //    {
            //        sum += array3[k];
            //    }  
            //}
            //Console.WriteLine("Sum = " + sum);
            //Console.ReadKey();


            /***********************************************************************
                Write a program in C# Sharp where you will declare a one-dimension 
                array with 10 items (enter any value you want).
                Write code to find out those items which are duplicated in your array.
            ************************************************************************/
            //int[] arr1 = new int[] { 10, 12, 10, 7, 8, 12, 7, 12,7,8 };
            //int[] arr2 = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1,-1,-1 };
            //int ctrl, i, j;

            //for (i = 0; i < arr1.Length; i++)
            //{
            //    ctrl = 1;
            //    for (j = i + 1; j < arr1.Length; j++)
            //    {
            //        if (arr1[i] == arr1[j])
            //        {
            //            ctrl++;
            //            arr2[j] = 0;
            //        }
            //    }
            //    if (arr2[i] != 0)
            //    {
            //        arr2[i] = ctrl;
            //    }
            //}

            //for (i = 0; i < arr1.Length; i++)
            //{
            //    if (arr2[i] ==2)
            //    {
            //        Console.WriteLine("The number " + arr1[i] + " have appeared " + arr2[i] + " times!");
            //    }
            //}
            //Console.ReadKey();


            /***********************************************************************
                Write a program in C# Sharp where you will declare two one-dimension 
                array with 6 items. 
                Enter values in array1 (enter any value you want).
                Then copy all the elements from array1 to array2 at reverse order. 
                Find the sum of the odd indexes values in array2.
            ************************************************************************/
            //int[] arr1 = new int[] { 10, 12, 10, 7, 8, 12 };
            //int[] arr2 = new int[6];

            //int x = 0;
            //int sum = 0;

            //for (int i = 5; i >= 0; i--)
            //{
            //    arr2[x] = arr1[i];
            //    x++;
            //}
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.Write(arr2[i] + " - ");
            //}

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum += arr2[i];
            //    }
            //}
            //Console.WriteLine("Sum = " + sum);
            //Console.ReadLine();


            /***********************************************************************
                Write a program in C# Sharp to find the largest and 
                smallest element in an array.
            ************************************************************************/

            //int[] arr1 = new int[] { 10, 20, 12, 8, 50, 5 };

            //int large = arr1[0];
            //int small = arr1[0];

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    if (large < arr1[i])
            //    {
            //        large = arr1[i];
            //    }

            //    if (small > arr1[i])
            //    {
            //        small = arr1[i];
            //    }

            //}
            //Console.WriteLine("Largest: " + large + " - " + "Smallest: " + small);
            //Console.ReadKey();


            /***********************************************************************
                Write a program in C# Sharp to find the second largest and 
                second smallest element in an array.
            ************************************************************************/

            //int[] arr1 = new int[] { 10, 20, 12, 8, 50, 5 };

            //int X = arr1[0];

            //Array.Sort(arr1);

            //Console.WriteLine("Second Largest: " + arr1[4] + " - " + "Second Smallest: " + arr1[1]);
            //Console.ReadKey();

            int[] arr1 = new int[] { 53, 32, 19, 48, 25, 56 };
            int X=arr1[0];
            int Y;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (X > arr1[i])
                {
                    Y = arr1[i];
                    arr1[i] = X;
			arr1[i + 1] = Y;
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadKey();
            

        }
    }
}
