//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace OOTP_Lab3
//{
//    class Massive
//    {
//        readonly int id;
//        public int size { get; private set; }                                //поле размера массіва
//        public int[] arr;                               //поле самого массіва

//        protected int name;
//        private const int SIZE = 17;
//        public static int count = 0;
//        public int sum;


//        public Massive(int size, int a = 15)
//        {
//            name = count;
//            this.size = size;
//            content(size, a);
//            id = GetHashCode();
//            sum = arr.Sum();
//            count++;
//        }

//        public Massive()
//        {
//            name = count;
//            size = SIZE;
//            int a = 20;
//            content(size, a);
//            id = GetHashCode();
//            count++;
//        }

//        public override bool Equals(object obj)
//        {
//            Massive arr = obj as Massive;
//            if (this.sum == arr.sum) return true;
//            else return false;
//        }
//        public void content(int size, int a)
//        {
//            arr = new int[size];
//            Random rand = new Random();
//            for (int i = 0; i < size; i++)
//            {
//                arr[i] = rand.Next(0, a);
//            }
//        }
//        public void summa()
//        {
//            Console.WriteLine(arr.Sum());
//            Console.Write($"Max: {arr.Max()},  min: {arr.Min()}");
//        }
//        public void getconsole()
//        {
//            Console.WriteLine($"Массив №:{name}");
//            for (int i = 0; i < this.size; i++)
//            {
//                Console.Write($"{ arr[i]} ");
//            }
//            Console.WriteLine();


//            //summa();
//            //Console.WriteLine();
//            Console.WriteLine($"{id}");
//            Console.WriteLine("----------");

//        }
//        public override int GetHashCode()
//        {
//            return base.GetHashCode();
//        }
//        public static void peredacha(ref Massive a)
//        {
//            foreach (var element in a.arr)
//            {
//                Console.Write($"{element} ");
//            }
//            Console.WriteLine();
//        }

//    }
//}
