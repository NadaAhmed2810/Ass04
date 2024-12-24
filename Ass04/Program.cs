namespace Ass04
{
    internal class Program
    {
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
        }
    }
}
