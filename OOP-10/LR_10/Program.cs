using LR_10;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //--10--Game
            Player frst = new Player("One");
            Player scnd = new Player("Two");
            Player thrd = new Player("Three");
            Player frth = new Player("Four");
            Player ffth = new Player("Five");

            Game<Player> idkgame = new Game<Player>();

            idkgame.players.Enqueue(frst);
            idkgame.players.Enqueue(scnd);
            idkgame.players.Enqueue(thrd);
            idkgame.Show();


            idkgame.players.Dequeue();
            Console.WriteLine("\n---------После удаления первого элемента-------");
            idkgame.Show();

            Console.WriteLine("\n----------Вывод ключ + значение-----------------");
            Game<Player> NotAgame = new Game<Player>();
            NotAgame.dict.Add(1, frst);
            NotAgame.dict.Add(2, scnd);
            NotAgame.dict.Add(3, thrd);
            NotAgame.dict.Add(4, ffth);
            NotAgame.dict.Add(5, frth);
            NotAgame.ShowDict();


            NotAgame.dict.Remove(1);
            Console.WriteLine("\n---------Удаление 1-го элемента по ключу-------");
            NotAgame.ShowDict();
            NotAgame.Remove(2);
            Console.WriteLine("\n---------Удаление 2-х элемента по ключу-------");
            NotAgame.ShowDict();


            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("Содержит ключ '4'?:" + NotAgame.dict.ContainsKey(4));
            Console.WriteLine("Содержит ключ '6'?:" + NotAgame.dict.ContainsKey(6));

            Console.WriteLine("\n------------------------------------------------------\n");

            ObservableCollection<int> obs = new ObservableCollection<int>();
            obs.CollectionChanged += Ch;
            obs.Add(1);
            NotAgame.ShowDict();
            obs.Remove(1);
            NotAgame.ShowDict();
        }
        public static void Ch(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Коллекция изменена действием " + e.Action);
        }
    }
}

