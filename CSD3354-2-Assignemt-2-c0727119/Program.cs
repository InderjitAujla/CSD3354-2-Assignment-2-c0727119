﻿using System;

namespace CSD3354_2_Assignemt_2_c0727119
//Sonia Manhas c0726358
//Inderjit Sngh Aujla c0727119
//CSD3354 Section 2
//Assignment 2
//March 7, 2019
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExcercises de = new DelegateExcercises();
            de.Method3();
        }
    }
    public class DelegateExcercises
    {
        public delegate int MyDelegate(int intValue);

        public int Method1(int intMethod1)
        {
            return intMethod1 * 2;
        }
        public int Method2(int intMethod2)
        {
            return intMethod2 * 10;
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            int result1 = myDelegate(10);
            System.Console.WriteLine(result1);
            myDelegate = new MyDelegate(Method2);
            int result2 = myDelegate(10);
            System.Console.WriteLine(result2);
        }
    }
}