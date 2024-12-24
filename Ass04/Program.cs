using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Ass04
{
    //class
    //interface
    //enum
    //struct
    internal class Program
    {
        //function
        //data
        // types of function 
        // 1.class Member funvtion [static function]
        //2.object member function [non static function
        //not call because its not in internal point 
        public static void print(string pattern, int count = 10)
        {
            for (int i=0;i<count;i++)
                Console.WriteLine(pattern);
        }
        public static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void Swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static int Sum(int x,params int[] arr)
        {
            int sum = 0;
           // arr=new int[] {4,5,6};
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static int Sum(ref int[] arr)
        { 
            
            int sum = 0;
            arr=new int [] {4,5,6}; ;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static void SumMul(int x,int y,out int sum,out int mul)
        {
             sum = x+y;
             mul = x * y;

        }
        public static void SumMul1(int x, int y, ref int sum, ref int mul)
        {
            sum = x + y;
            mul = x * y;

        }
        static void Main(string[] args)
        {

            #region Casting [Boxing,unBoxing]
            // takes time and memory Not recommended 
            //ref type casting=> ref type to ref type 
            //Boxing Value type to ref type [Safe Casting]
            //unBoxing Casting => Ref type to value type [unsafe Casting]
            //object obj = new object;
            //obj = "Mostafa";// reference type casting
            //obj = 1;        //Boxing [Casting from value type to reference type]
            #region Boxing [Safe Casting]
            //int x = 10;
            //object obj01 = new object();
            //obj01 = x;
            //Console.WriteLine(obj01);
            //Parent =child
            //Dog is an Animal
            #endregion

            #region UnBoxing[unsafe casting]
            //object obj02 = new object();
            //obj02 = "mostafa";
            //int x = (int)obj02;
            //Console.WriteLine(x);
            ////Child =Parent 
            ////Animals ares Dogs
            #endregion
            #endregion
            #region Nullable Data Type
            #region Value type
            //any tging accept null must check 
            //int x =null ;// int number only
            //int? x = null;// int Number and null
            //Nullable<int> y = null;
            //Console.WriteLine(x);
            //int x = 10;
            //int? y = x;
            //int? x = 10;
            //int y;
            //if (x != null)
            //{
            //    y = (int)x;
            //}
            //else y = 0;
            //it  take less time 
            //if (x.HasValue)
            //{
            //    y = x.Value;//not casting
            //}
            //else y = 0;
            //Console.WriteLine(y);
            // y=x.HasValue ? x.Value : 0;
            #endregion
            #region reference type
            // string? Name = null;//default
            //string? Name = null!;
            #endregion
            #endregion
            #region Null Propagation Operator
            //int[] Numbers = null; //{ 1, 2, 3, 4, 5 };
            //for (int i = 0;Numbers !=null  && i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //check evey time
            //for (int i = 0;  i < Numbers?.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //i<Numbers?.length
            //Numbers=>object [length]
            //Numbers=>Null[Null]
            ////best
            //if(Numbers != null)
            //{
            //    for (int i = 0; i < Numbers.Length; i++)
            //    {
            //        Console.WriteLine(Numbers[i]);
            //    }
            //}
            //int? Length = Numbers?.Length;
            //int L=Numbers?.Length??0;
            //Employee Emp=new Employee();
            //Emp.department=new Department();
            //if (Emp != null)
            //{
            //    if (Emp.department != null)
            //    {
            //        Console.WriteLine(Emp.department.Name);
            //    }
            //}
            //Console.WriteLine(Emp?.department.?Name??"Not found");

            #endregion
            #region Functions
            //passing by order
            // print(10,"***");
            //passing by name
            // print(pattern:"***", count:10);
            //print("***");
            //Hello Mostafa 
            //welcome to              route
            //Console.WriteLine("Hello Mostafa\nwelcome to\t\t\t\troute");
            //string path = @"D:\C#Projects\Ass04\Ass04.sln";

            #endregion
            #region function value parameters
            #region By value
            //int x = 10;
            //int y = 5;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Swap( x,  y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            #endregion
            #region By reference
            //int x = 10;
            //int y = 5;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Swap(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            #endregion
            #endregion

            #region reference type parameters
            #region Ex01
            #region By value
            // value => address 
            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine(Sum(arr));
            //Console.WriteLine(arr[0]);

            #endregion
            #region By reference
            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine(Sum(ref arr));
            //Console.WriteLine(arr[0]);

            #endregion
            #endregion
            #region Ex02
            #region by Value
            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine(Sum(arr));
            //Console.WriteLine(arr[0]);
            #endregion
            #region by reference
            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine(Sum(ref arr));
            //Console.WriteLine(arr[0]);
            #endregion
            #endregion
            #endregion
            #region Function Passing by out
            //int a = 10, b = 20, sum=0, mul=0;
            //SumMul(10, 20, out sum, out mul);
            //Console.WriteLine(sum);
            //Console.WriteLine(mul);
            //ref input and out paramaters
            //SumMul1(10, 20, ref sum, ref mul);
            //Console.WriteLine(sum);
            //Console.WriteLine(mul);
            #endregion
            #region Functions-params
            //int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(Sum(0,1, 2, 3, 4, 5, 6, 7, 8, 9));
            //int A=10, B=11,C=12;
            //Console.WriteLine("A :{0},B:{1},C:{2}",A,B,C);
            #endregion

        }
    }
}
