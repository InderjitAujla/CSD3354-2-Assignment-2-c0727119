using System;

namespace CSD3354_2_Assignemt_2_c0727119
//Sonia Manhas c0726358
//Inderjit Sngh Aujla c0727119
//CSD3354 Section 2
//Assignment 2
//March 7, 2019

public class DelegateExercises
{
    public delegate void MyDelegate();
    void Method1(int i)
    {
        Console.WriteLine("Method1");
        Console.ReadLine();
    }
    public void Method2()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        myDelegate();
    }
}
}