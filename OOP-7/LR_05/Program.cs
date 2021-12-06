using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LR_07
{
    class LR_07
    {
        static void Main(string[] args)
        {
           

            try
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Работа с сообственными исключениями!\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                //Проверка цвета
                try
                {
                    Razum One = new Razum("Кирилл", 1900, "бел", "375445388008");

                }
                catch (ErrorName ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                    Logger.WriteLog(ex);
                }

                //Проверка правильности Возраста
                try
                {
                    Razum One = new Razum("Кирилл", 19, "reкd", "375445388008");

                }
                catch (ErrorAge ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                    Logger.WriteLog(ex);
                }

            }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                    Logger.WriteLog(ex);
                }
            people object1 = new people("Солдат", 1000, "зеленый", "М");
            Trans object2 = new Trans("Мегатрон", 1001, "красный", "Дессиптикон", "Кибертрон");
            Trans object3 = new Trans("Мегатрон", 1002, "красный", "Дессиптикон", "Кибертрон");
            Trans object4 = new Trans("Мегатрон", 1000, "красный", "Дессиптикон", "Кибертрон");
            Trans object5 = new Trans("Мегатрон1", 1001, "красный", "Дессиптикон", "Кибертрон");

            Razum Army = new Razum();
            Army.AddRazum(object2);
            Army.AddRazum(object3);
            Army.AddRazum(object4);
            Army.AddRazum(object5);
            Army.AddRazum(object1);

            Razum AllRazum = new Razum();
            Razum[] RazumList = new Razum[] { object1, object2, object3 };

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nРабота со стандартными исключениями!");
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\nЗапрос к несуществующему элементу = Вызов стандартного исключения IndexOutOfRangeException для несуществующего индекса.\n");
            try
            {
                Console.WriteLine(RazumList[4].ToString());
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                Logger.WriteLog(ex);
            }

            Console.WriteLine("\nПопытка недопустимого преобразования типов (Стан. фун. InvalidCastException)\n");
            try
            {
                object obj = object2.rasa;
                int Name = (char)obj;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                Logger.WriteLog(ex);
            }
            finally
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n<!--Работа программы завершена!-->");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }


                //Army.ShowList();
                Army.TestNumber(object2);
                //  Army.Findarmy();
                //Army.FindAge();
            }
    }
}
