using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Grup = new string[] { "Кирилл","Глеб","Игорь","Катя","Диана","Ольга" };
            //1
            //Console.WriteLine("Введите количество символов длины месяцев для проверки:");
            //int n = int.Parse(Console.ReadLine());
            //IEnumerable<string> NewGrup = Grup.Where(m => m.Length == n);
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Подходящие месяцы");
            //Console.ForegroundColor = ConsoleColor.Gray;
            //foreach (string item in NewGrup)
            //{
            //    Console.WriteLine(item);
            //}
            //2
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nТолько мальчики:");
            Console.ForegroundColor = ConsoleColor.Gray;
            IEnumerable<string> NewMonts2 = from m in Grup where m.StartsWith("Ки") || m.StartsWith("Г") || m.StartsWith("И")  select m; //вывод одногрупника по первой букве по первым буквам 
            foreach (string item in NewMonts2)
            {
                Console.WriteLine(item);
            }
            //3
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nОдногрупники в алфавитном порядке:");
            Console.ForegroundColor = ConsoleColor.Gray;
            IEnumerable<string> NewGrup3 = Grup.OrderBy(а => а); //вывод по алфавиту
            foreach (string item in NewGrup3)
            {
                Console.WriteLine(item);
            }
            //4
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nИмя с \"и\" и длиной строки больше четырех: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            IEnumerable<string> NewGrup4 = Grup.Where(n1 => n1.Contains("и") && n1.Length > 4); 
            foreach (string item in NewGrup4)
            {
                Console.WriteLine(item);
            }


            //Часть 2

            List<Student> library = new List<Student>() { new Student("Кирилл",  17, 8, 9, 10, 27),
                                                    new Student("Глеб", 16, 3, 5, 8, 16),
                                                    new Student("Игорь", 20, 8, 6, 10, 24),
                                                    new Student("Катя", 16, 9, 2, 7, 18),
                                                    new Student("Диана", 19, 9, 7, 9, 25),
                                                    new Student("Ольга",  18, 8, 10, 10, 28)
                                                  };
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nВведите абитуриента для поиска:");
            Console.ForegroundColor = ConsoleColor.Gray;
            string findName = Console.ReadLine();
            var lib1 = library.Where(n3 => n3.Name == findName); //поиск по автору 
            foreach (Student item in lib1)
            {
                Console.WriteLine(item.Name + " " +  item.Year);
            }


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nВведите, после каких баллов вывести аббиткриентов:");
            Console.ForegroundColor = ConsoleColor.Gray;
            int ball = int.Parse(Console.ReadLine()); 
            var lib2 = library.Where(n3 => n3.Ball > ball);
            foreach (Student item in lib2)
            {
                Console.WriteLine(item.Name + " "  + item.Year + "" + item.Ball);
            }

            

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nАбитуриенты по возросту..."); //сортировка по возросту 
            Console.ForegroundColor = ConsoleColor.Gray;
            var lib3 = library.OrderBy(n4 => n4.year);
            foreach (Student item in lib3)
            {
                Console.WriteLine(item.Name + " " + item.Year) ;
            }


           

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nАбитуриенты имеющие 10 по русскому: " ); //толщина книги
            Console.ForegroundColor = ConsoleColor.Gray;
            var lib4 = library.Where(n3 => n3.rus == 10);
            foreach (Student item in lib4)
            {
                Console.WriteLine(item.Name + " " + item.Year + " " + item.Rus);
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n4 последних абитуриента с самой низкой успеваемостью...");
            Console.ForegroundColor = ConsoleColor.Gray;
            var lib = library.OrderByDescending(n5 => n5.ball).Take(4);
            foreach (Student item in lib)
            {
                Console.WriteLine(item.Name +  " " + "успеваемость: " + item.ball);
            }


            List<Team> teams = new List<Team>()
            {
                new Team { Name = "Спартак", Country ="Россия" }, //создание команды
                new Team { Name = "Динамо", Country ="Белорусь" }
            };
            List<Player> players = new List<Player>()
            {
            new Player {Name="Дзюба", Team="Спартак"}, //создание игроков
            new Player {Name="Халк", Team="Динамо"},
            };

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nИспользование оператора Join");
            Console.ForegroundColor = ConsoleColor.Gray;
            var result = players.Join(teams, p => p.Team, t => t.Name, (p, t) => new { Name = p.Name, Team = p.Team, Country = t.Country });
            foreach (var item in result)
                Console.WriteLine($"{item.Name} - {item.Team} ({item.Country})");
        }
    }
}
