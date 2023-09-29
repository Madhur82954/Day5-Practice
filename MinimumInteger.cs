using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Practice
{
    class checkforGeneric<T> where T : IComparable
    {
        public T n1, n2, n3;
        public checkforGeneric(T n1,T n2,T n3)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
        }
        public void checkeveryvalue() 
        {
            if (n1.CompareTo(n2) < 0 && n1.CompareTo(n3) < 0)
            {
                Console.WriteLine("n1 is Minimum");
            }
            else if (n2.CompareTo(n1) < 0 && n2.CompareTo(n3) < 0)
            {
                Console.WriteLine("n2 is Minimum");
            }
            else if (n3.CompareTo(n1) < 0 && n3.CompareTo(n2) < 0)
            {
                Console.WriteLine("n3 is Minimum");
            }
        }
    }
    internal class MinimumInteger
    {
        public void checkMin() 
        {
            int n1, n2, n3;
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            if(n1<n2 && n1 < n3)
            {
                Console.WriteLine("n1 is Minimum");
            }
            else if (n2 < n1 && n2 < n3)
            {
                Console.WriteLine("n2 is Minimum");
            }
            else if (n3 < n1 && n3 < n2)
            {
                Console.WriteLine("n3 is Minimum");
            }
        }
        public void checkMin1()
        {
            float n1, n2, n3;
            n1 = float.Parse(Console.ReadLine());
            n2 = float.Parse(Console.ReadLine());
            n3 = float.Parse(Console.ReadLine());
            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine("n1 is Minimum");
            }
            else if (n2 < n1 && n2 < n3)
            {
                Console.WriteLine("n2 is Minimum");
            }
            else if (n3 < n1 && n3 < n2)
            {
                Console.WriteLine("n3 is Minimum");
            }
        }
        public void checkMin2()
        {
            string n1, n2, n3;
            n1 = Console.ReadLine();
            n2 = Console.ReadLine();
            n3 = Console.ReadLine();
            if (n1.CompareTo(n2) < 0 && n1.CompareTo(n3) < 0)
            {
                Console.WriteLine("n1 is Minimum");
            }
            else if (n2.CompareTo(n1) < 0 && n2.CompareTo(n3) < 0)
            {
                Console.WriteLine("n2 is Minimum");
            }
            else if (n3.CompareTo(n1) < 0 && n3.CompareTo(n2) < 0)
            {
                Console.WriteLine("n3 is Minimum");
            }
        }
        public void checkeveryvalue<T>(T n1,T n2,T n3) where T:IComparable
        {
            if (n1.CompareTo(n2) < 0 && n1.CompareTo(n3) < 0)
            {
                Console.WriteLine("n1 is Minimum");
            }
            else if (n2.CompareTo(n1) < 0 && n2.CompareTo(n3) < 0)
            {
                Console.WriteLine("n2 is Minimum");
            }
            else if (n3.CompareTo(n1) < 0 && n3.CompareTo(n2) < 0)
            {
                Console.WriteLine("n3 is Minimum");
            }
        }
    }
}
