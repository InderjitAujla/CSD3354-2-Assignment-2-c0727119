using System;

namespace CSD3354_2_Assignemt_2_c0727119
//Sonia Manhas c0726358
//Inderjit Sngh Aujla c0727119
//CSD3354 Section 2
//Assignment 2
//March 7, 2019
{
    public class Program
    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }
    }

    public delegate void MyDelegate();

    public class DelegateExercises
    {
        void Method1()
        {
            System.Console.WriteLine("Method1");


        }

        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
            System.Console.WriteLine(myDelegate.ToString());
        }
    }
}