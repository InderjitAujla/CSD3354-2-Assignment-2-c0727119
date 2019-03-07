using System;

namespace CSD3354_2_Assignemt_2_c0727119
//Sonia Manhas c0726358
//Inderjit Sngh Aujla c0727119
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class DelegateExcercises
    {
        public delegate void MyDelegate();

        void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate mydelegate = new MyDelegate(Method1);
            mydelegate();
        }
    }
}