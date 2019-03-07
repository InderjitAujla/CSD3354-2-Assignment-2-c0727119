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
        void Method3()
        {
            System.Console.WriteLine(MyDelegate.ToString());
        }
    }
}