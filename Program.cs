using System;
using System.Collections.Generic;

namespace Day5_Practice
{
    class DeleteArray<T> where T : IComparable
    {
        public void Add(params T[] values)
        {
            var list = new List<T>();
            list.AddRange(values);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void Delete1(T values)
        {
            var list = new List<T>();
            list.Remove(values);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
    internal class Program
    {
        public void Delete()
        {
            var list = new List<int>();
            var list1 = new List<double>();
            var list2 = new List<char>();

            list.Add(1);
            list.Add(4);
            list.Add(5);
            list.Add(8);

            foreach(var element in list)
            {
                Console.WriteLine(element);
            }
            list.Remove(5);
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            list1.Add(1.14);
            list1.Add(4.14);
            list1.Add(5.14);
            list1.Add(8.14);

            foreach (var element in list1)
            {
                Console.WriteLine(element);
            }
            list1.Remove(4.14);
            foreach (var element in list1)
            {
                Console.WriteLine(element);
            }
            list2.Add('a');
            list2.Add('b');
            list2.Add('c');
            list2.Add('d');

            foreach (var element in list2)
            {
                Console.WriteLine(element);
            }
            list2.Remove('c');
            foreach (var element in list2)
            {
                Console.WriteLine(element);
            }
        }
        public void Add<T>(params T[] values)
        {
            var list = new List<T>();
            list.AddRange(values);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void Delete1<T>(T values)
        {
            var list = new List<T>();
            list.Remove(values);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            //Program program = new Program();
            //program.Delete();
            //program.Add(1,4,5,8);
            //program.Delete1(5);

            //MinimumInteger minimum = new MinimumInteger();
            //minimum.checkMin2();
            //minimum.checkeveryvalue<int>(2,1,3);

            checkforGeneric<int> checkfor = new checkforGeneric<int>(4,3,1);
            checkfor.checkeveryvalue();
        }
    }
}
