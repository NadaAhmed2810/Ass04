﻿using System.Security.Cryptography.X509Certificates;

namespace Assignment
{
    internal class Program
    {
        public static void IncreaseNumber(int num)
        {
            num += 10;
            Console.WriteLine(num);
        }
        public static void IncreaseNumber(ref int num)
        {
            num += 10;
            Console.WriteLine(num);
        }
        public static void UpdateNameOfStudent(Student std,string s)
        {
            std.Name = s;
        }
        public static void UpdateNameOfStudent(ref Student std, string s)
        {
            std.Name = s;
        }
        public static void updateStudent(Student std, string s)
        {
            std=new Student();
            std.Name=s;
            std.Id = 10;
        }
        public static void updateStudent(ref Student std, string s)
        {
            std = new Student();
            std.Name = s;
            std.Id = 10;
        }
        public static void CalcSumAndSub(int x,int y,out int sum,out int sub)
        {
            sum = x + y;
            sub = x - y;
        }
        public static int CalcSumOfdigits(int x)
        {
            string s = x.ToString();
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i]-'0';
            }
            return sum;
        }
        public static bool IsPrime(int x)
        {
            for (int i = 2;i*i <= x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int[] GetMinAndMax(ref int[] arr)
        {
            int[] a = new int []{ int.MaxValue, int.MinValue };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < a[0])
                {
                    a[0] = arr[i];
                }
                if (arr[i] > a[1])
                {
                    a[1] = arr[i];
                }
            }
            return a;

        }
        public static long factorial(int x)
        {
            long f = 1;
            for(int i = 1; i <= x; i++)
            {
                f*= i;
            }
            return f;
        }
        public static string ChangeChar(string s, int pos, char c)
        {
            if (s == null)
            {
                throw new ArgumentException("Input string cannot be null or empty.");
            }

            char[] charArray = s.ToCharArray();
            charArray[pos] = c;
            return new string(charArray);
        }
        static void Main(string[] args)
        {
            #region Q1: Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            #region Value type passing by value
            ////Function By Value works on a copy value and  do not affect the original variable
            //int num = 10;
            //Console.WriteLine("Passing by Value: ");
            //Console.WriteLine($"Before: {num}");
            //IncreaseNumber( num);
            //Console.WriteLine($"After:{num}");
            #endregion
            #region Value type passing by reference 

            ////works on actual variable and do affect the original variable 
            //Console.WriteLine("Passing by Reference: ");
            //Console.WriteLine($"Before: {num}");
            //IncreaseNumber(ref num);
            //Console.WriteLine($"After:{num}");
            #endregion
            #endregion
            #region Q2:Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            #region reference passing By value
            #region update value in this object
            //function to update Name of Student
            //function take address of object so it work in object if i update value in this object
            //Student student= new Student();
            //student.Name = "Nada";
            //Console.WriteLine(student?.Name??" ");
            //if(student!=null)
            //   UpdateNameOfStudent(student, "Nour");
            //Console.WriteLine(student?.Name??" ");
            #endregion
            #region make new object 
            //function to update Name of Student
            //function take address of object so it work in object if make new object in function original object not effect
            //Student student = new Student();
            //student.Name = "Nada";
            //Console.WriteLine(student?.Name ?? " ");
            //if (student != null)
            //    updateStudent(student, "Nour");
            //Console.WriteLine(student?.Name ?? " ");
            #endregion
            #endregion
            #region reference type passing By ref 
            //function take ref of object so work on object always
            //Student student = new Student();
            //student.Name = "Noura";
            //Console.WriteLine(student?.Name ?? " ");
            //if (student != null)
            //    UpdateNameOfStudent(ref student, "Nour");
            //Console.WriteLine(student?.Name ?? " ");
            #endregion
            #region make new object 
            //function to update Student
            //function take  object so it work in object if make new object in function original object effect
            //Student student = new Student();
            //student.Name = "Nada";
            //Console.WriteLine(student?.Name ?? " ");
            //if (student != null)
            //    updateStudent(ref student, "Nour");
            //Console.WriteLine(student?.Name ?? " ");
            #endregion
            #endregion
            #region Q3:Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int x = 50, y = 10, sum, sub;
            //CalcSumAndSub(x, y, out sum, out sub);
            //Console.WriteLine($"Sum: {sum}\nSub: {sub}");

            #endregion
            #region Q4:Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Console.Write("Enter Number: ");
            //int Num =int.Parse(Console.ReadLine());
            //Console.WriteLine(CalcSumOfdigits(Num));
            #endregion
            #region Q5:Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.Write("Enter Number: ");
            //int Num = int.Parse(Console.ReadLine());
            //if(IsPrime(Num))
            //    Console.WriteLine("Number Is Prime ");
            //else Console.WriteLine("Number Is Not Prime");
            #endregion
            #region Q6:Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int size;
            //bool f = false;
            //do {
            //    Console.Write("Enter Size: ");
            //    f=int.TryParse(Console.ReadLine(), out size);
            //} while (size >0 && !f);
            //int[] arr = new int[size];
            //for (int i = 0; i < size;)
            //{
            //    Console.Write($"Enter Element [{i + 1}]:");
            //    f = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (f) i++;
            //}
            //int[] a=GetMinAndMax(ref arr);
            //Console.WriteLine($"Min: {a[0]}\nMax:{a[1]}");
            #endregion
            #region Q7:Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //Console.Write("Enter Number:");
            //int Num =int.Parse(Console.ReadLine());
            //if (Num > 0)
            //{
            //    Console.WriteLine(factorial(Num));
            //}
            #endregion
            #region Q8:Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //String s = null;
            //bool f = false;
            //do
            //{
            //    Console.Write("Enter String:");
            //     s = Console.ReadLine();
            //} while(s==null);
            //int pos;
            //f=false;
            //do {
            //    Console.Write("Enter position greater than 0 and less than length of string:");
            //    f=int.TryParse(Console.ReadLine(), out pos);
            //} while (!f || pos<0 || pos>s.Length);
            //char c;
            //f = false;
            //do
            //{
            //    Console.Write("Enter newchar :");
            //    f = char.TryParse(Console.ReadLine(),out c);
            //} while (!f);
            //Console.WriteLine($"New string :{ChangeChar(s, pos, c)} ");
            #endregion 
            //finished
        }
    }
}
