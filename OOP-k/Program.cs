using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Threading;

using System;
namespace kompot
{
    public class HOURExp : Exception
    {
        public int sum { get; set; }

        public HOURExp(string message, int sum) : base(message)
        {
            this.sum = sum;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //1A
            int i = int.MinValue;
            uint a = uint.MaxValue;
            int x = 0;
            x = (int)(a + i);
            Console.WriteLine($"Сумма={x} ");
            Б
           Random rand = new Random();
            string[,] Map = new string[10, 10];

            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    Map[i, j] = ((char)rand.Next('a', 'z')).ToString();
                    Console.Write(Map[i, j] + " ");
                }
                Console.WriteLine();
            }
            //2
            //        try
            //        {
            //            Time obj1 = new Time(2, 35, 34);
            //            Time obj2 = new Time(2, 36, 50);
            //            if (obj1 == obj2) Console.WriteLine("True");
            //            else Console.WriteLine("false");
            //            if (obj1.Equals(obj2)) Console.WriteLine("True");
            //            else Console.WriteLine("false");

            //        }
            //        catch (ArgumentOutOfRangeException e)
            //        {
            //            Console.WriteLine("Error: " + e.Message);
            //        }

            //        //3
            //        Time[] arr = new Time[6] { new Time(2, 35, 45), new Time(14, 35, 34), new Time(2, 36, 50), new Time(15, 23, 50), new Time(15, 23, 50), new Time(16, 23, 50) };
            //        try
            //        {
            //            int i = 0;
            //            foreach (IPossible obj in arr)
            //            {
            //                if (i > 2)
            //                {
            //                    throw new HOURExp("Ночью", i);
            //                }
            //                if (obj.Chaek()) i++;
            //            }
            //        }
            //        catch (HOURExp e)
            //        {
            //            Console.WriteLine("Error: " + e.Message);
            //        }
            //    }
            //}

            //interface IComparable { }
            //interface IPossible
            //{
            //    bool Chaek();
            //}

            //partial class Time : IPossible
            //{
            //    int hour;
            //    int minute;
            //    int second;

            //    public Time(int h, int m, int s)
            //    {
            //        if (h > 24 || s < 0) throw new ArgumentOutOfRangeException("Не коректное значение", "m");
            //        hour = h;
            //        if (s > 60 || s < 0) throw new ArgumentOutOfRangeException("Не коректное значение", "m");
            //        minute = m;
            //        if (s > 60 || s < 0) throw new ArgumentOutOfRangeException("Не коректное значение", "s");
            //        second = s;
            //    }


            //    public static bool operator ==(Time a, Time b)
            //    {
            //        if (a.hour == b.hour) return true;
            //        return false;
            //    }
            //    public static bool operator !=(Time a, Time b)
            //    {
            //        if (a.hour != b.hour) return true;
            //        return false;
            //    }
            //    public bool Equals(Time obj)
            //    {
            //        if (this.hour == obj.hour)
            //            if (this.minute == obj.minute)
            //                if (this.second == obj.second) return true;
            //        return false;
            //    }
            //    bool IPossible.Chaek()
            //    {
            //        if (this.hour > 20 || this.hour < 6) return true;
            //        return false;
            //    }
            //}
        }


