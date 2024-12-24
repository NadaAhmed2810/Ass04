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
        }
    }
}
