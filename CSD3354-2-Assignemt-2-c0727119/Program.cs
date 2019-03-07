using System;

namespace CSD3354_2_Assignemt_2_c0727119
{
    public class DelegateExercises
    {
        public delegate void MyDelegate();
        void Methodl()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }

        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Methodl);
            myDelegate();
        }
    }
}