using System;

namespace Set
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем множества.
            var set1 = new Set<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 9, 10
            };

            var set2 = new Set<int>()
            {
                4, 5, 6, 7, 8, 9, 11
            };

            var set3 = new Set<int>()
            {
                2, 3, 4
            };

            // Выполняем операции со множествами.
            var union = set1 + set2;
            var itn = Set<int>.itn(set2, set1);
            var intersection = set1*set2;
            var subset1 = Set<int>.fals(set3, set1);
            var subset2 = Set<int>.fals(set3, set2);
            var sum = Set<int>.sum(set2, set1);
            // Выводим исходные множества на консоль.
            PrintSet(set1, "Первое множество: ");
            PrintSet(set2, "Второе множество: ");
            PrintSet(set3, "Третье множество: ");

            // Выводим результирующие множества на консоль.
            PrintSet(union, "Объединение первого и второго множества: ");
            PrintSet(itn, "Мощнсть второго множества:");
            PrintSet(intersection, "Пересечение первого и второго множества: ");
            Console.WriteLine($"Сумма колличеств чисел второго и первого множества: "+sum);
            // Выводим результаты проверки на подмножества.
            if (subset1)
            {
                Console.WriteLine("Третье множество является подмножеством первого.");
            }
            else
            {
                Console.WriteLine("Третье множество не является подмножеством первого.");
            }

            if (subset2)
            {
                Console.WriteLine("Третье множество является подмножеством второго.");
            }
            else
            {
                Console.WriteLine("Третье множество не является подмножеством второго.");
            }

            Console.ReadLine();
        }

       
        private static void PrintSet(Set<int> set, string title)
        {
            Console.Write(title);
            foreach (var item in set)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}