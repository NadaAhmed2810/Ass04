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
        static void Main(string[] args)
        {
            #region Q1: Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            #region Value type
            ////Function By Value works on a copy value and  do not affect the original variable
            //int num = 10;
            //Console.WriteLine("Passing by Value: ");
            //Console.WriteLine($"Before: {num}");
            //IncreaseNumber( num);
            //Console.WriteLine($"After:{num}");

            ////works on actual variable and do affect the original variable 
            //Console.WriteLine("Passing by Reference: ");
            //Console.WriteLine($"Before: {num}");
            //IncreaseNumber(ref num);
            //Console.WriteLine($"After:{num}");
            #endregion
            #endregion
        }
    }
}
