using System;
using static LR_09.director;

namespace LR_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero person1 = new Hero(750, "Вася");
            Stol person2 = new Stol(600, "Петя");
            person1.Notify += DisplayNotify;
            person2.Notify += DisplayNotify;
            person1.Poniz();
            person2.Povs();
            person1.Poniz();



            Console.WriteLine("\n------------Работа со строками---------------\n");

            string str = "На колени ставить толпой — не дипломатично\nЯ всё это хаваю, у меня нет выбора\nЕсли не хочу, чтоб мои будущие дети в школе увидали видео";
            Console.WriteLine("Исходная строка: " + str);
            Func<string, string> A = null;
            A = ChangeString.Remove;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Без знаков препинания: {0}", A(str));
            Console.ForegroundColor = ConsoleColor.Gray;
            A = ChangeString.AddToString;
            Console.WriteLine("Добавление строки: {0}", A(str));
            A = ChangeString.Upper;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Заглавные буквы: {0}", str = A(str));
            Console.ForegroundColor = ConsoleColor.Gray;
            A = ChangeString.Lower;
            Console.WriteLine("Прописные: {0}", A(str));
        }
    }
}
