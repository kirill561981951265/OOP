using System;
namespace oop2
{
    class Program
    {

        static void Main(string[] args)
        {
            // a_types();
            // b_types();
            // a_str();
            // b_str();
            // a_arrays();
            // b_arrays();
            a_corteg();
            // task6_checked();
            //task6_unchecked();

            (int max, int min, int sum, char firstLetter) tuple;
            int[] array = { 1, 2, 3, 4, 5, 813, 0, 738 };
            string name = "Kirill";
            tuple = task5(array, name);
            Console.WriteLine($"Max num: {tuple.max}\n" +
                              $"Min num: {tuple.min}\n" +
                              $"Sum: {tuple.sum}\n" +
                              $"First letter: {tuple.firstLetter}");


        }
        static void a_types()
        {
            // типы данных
            bool a = true;
            Console.WriteLine("[true - false] bool a = " + a);

            byte b = 254;
            Console.WriteLine("[0 - 255] byte b = " + b);

            sbyte c = 126;
            Console.WriteLine("[-128 - 127] sbyte c = " + c);

            char d = 'M';
            Console.WriteLine("[16 bit] char d = " + d);

            decimal e = 123123;
            Console.WriteLine("[16 bytes] decimal e = " + e);

            double f = 12.3213123;
            Console.WriteLine("[8 bytes] double f = " + f);

            float g = (float)3.4;
            Console.WriteLine("[4 bytes] float g = " + g);

            int h = 123123123;
            Console.WriteLine("[32 bit] int h = " + h);

            uint i = 11111111;
            Console.WriteLine("[unsigned 32 bit] uint i = " + i);

            long j = 91918191919;
            Console.WriteLine("[64 bit] long j = " + j);

            ulong k = 83172377124;
            Console.WriteLine("[unsigned 64 bit] ulong k = " + k);

            short l = 12312;
            Console.WriteLine("[16 bit] short l = " + l);

            ushort m = 12121;
            Console.WriteLine("[unsigned 16 bit] ushort m = " + m);

            object w= "hello code";
            Console.WriteLine("[object] w = " + w);

            Console.WriteLine("Введите строку :");
            string n = Console.ReadLine();
            Console.WriteLine("[string] Ваша строка : " + n);

        }
        static void b_types()
        {
            // явное привидение типов
            byte number = 128;
            Console.WriteLine("[byte] " + number + " -- to int --> " + (int)number);
            Console.WriteLine("[int] " + (int)number + " -- to long --> " + (long)number);
            Console.WriteLine("[byte] " + number + " -- to double --> " + (double)number);
            Console.WriteLine("[double] " + (double)number + " -- to float --> " + (float)number);
            Console.WriteLine("[byte] " + number + " -- to ulong --> " + (ulong)number);

            // неявное привидение типов
            int a = 0;
            double b = a; // приводит int -> double
            float c = a; // приводит int -> float
            double d = 23.32;
            double e = d + a;
            // привидение с помощью класса Convert
            // вернёт false
            bool f = System.Convert.ToBoolean(a);
            Console.WriteLine("Convert.ToBoolean() : " + f);
            // вернёт строку "23.32"
            string g = System.Convert.ToString(d);
            Console.WriteLine("Convert.ToString() : " + g);

            // упаковка
            double i = 777.984;
            object o = i;

            // распаковка
            o = 123.589;
            i = (double)o;

            // можно выполнять упаковку явно
            o = (object)i;

            var q = 19; // компилируется как int

            var name = "Kirill "; // компилируется как string

            var kino = true; // компилируется как bool

            // операции с неявно типизированной переменной
            if (kino) Console.WriteLine(name + " лет " + q);
            // Nullable
            /* Если после типа переменной поставить ?
             * то это означает что эта переменная может
             * принимат значение null;
             */
            int? r = null; 

            // если после переменной поставить ??, то она будет проверяться
            // на null значение, и если оно так и есть, оно вернёт значение
            // переменной после ?? символа
            string? Name = null;
            Console.WriteLine(Name ?? "Kirill");
      
       //var v = 123;
       //v = 23.32;
       
       //Этот код выдаст ошибку, т.к. при инициализации v
       //в первой строке, она получает тип int и уже остаётся int
       // и  неявное привидение к другому типу не будет выполнено
     
        }
        static void a_str()
        {
            string str1 = "He";
            string str2 = "KS";
            string str3 = "He";

            Console.WriteLine(str1 == str2); // false
            Console.WriteLine(str1 == str3); // true
        }
        static void b_str()
        {
            string str1 = "Hello world. ";
            string str2 = "My name is Kirill. ";
            string str3 = "This is C# language. ";

            str1 += str2; // сцепление
            Console.WriteLine("1 " + str1);
            string str4 = str1; // копирование
            Console.WriteLine("2 " + str4);
            string word = str1.Substring(0, 7); // выделение подстроки и её копирование
            Console.WriteLine("3 " + word);
            string[] words = str2.Split(); // разделение строки на слова
            Console.WriteLine("4 " + words[3]); 

                // вставка в определенную позицию
                string message = "Hello, ";
                string name = "Kirill";
                // Insert(pos, str);
                Console.WriteLine("5 " + message.Insert(message.Length, name));

                // удаление
                string question = "Привет, как дела";
                question.Remove(0, 6); // или короче question.Replace("Robert ", "");

                // интерполирование строк
                Console.WriteLine($"Hello, {name}! {str3}");
            string firstname = null;
            string lastname = "hh";

            // простейший пример использования isNullOrEmpty
            // null вернет true, empty - false
            if (String.IsNullOrEmpty(firstname)) Console.WriteLine("Ноль");
            else Console.WriteLine("This string is empty");
            if (String.IsNullOrEmpty(lastname)) Console.WriteLine("hh");
            else Console.WriteLine("This string is empty");


            var sb = new System.Text.StringBuilder();

            for (int i = 0; i < 10; i++)                                  
                sb.Append(i);

            Console.WriteLine(sb.ToString()); 

            sb[0] = sb[8]; 

            Console.WriteLine(sb.ToString()); 
        }
        static void a_arrays()
        {
            int[,] array = { { 1, 0, 1 }, { 0, 1, 0 }, { 1, 0, 1 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.Write("\n");
            }

            string[] str_array = { "Hello", "My name is", "Kirill" };
            Console.WriteLine("Содержание массива:");
            for (int i = 0; i < str_array.Length; i++)
                Console.WriteLine($"[{i}]. {str_array[i]}");

            Console.WriteLine("Выберите номер строки, которую хотите заменить: ");
            int a = System.Convert.ToInt32(Console.ReadLine());

            if (a < str_array.Length)
            {
                Console.WriteLine("Напишите предложение: ");
                string answer = Console.ReadLine();
                str_array[a] = answer;
                for (int i = 0; i < str_array.Length; i++)
                    Console.WriteLine($"[{i}]. {str_array[i]}");
            }
            else Console.WriteLine("Вы ввели неправильное число");
        }
        static void b_arrays()
        {
            byte arraySize = 4;
            int[][] array = new int[arraySize][];

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = new int[i + 1];
                Console.WriteLine($"заполните массив {i} из {arraySize - 1}");
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]}\t");
                }
                Console.Write("\n");

                var arrray = new[] { 1, 2, 3, 4 };       // неявно типизированный массив чисел
                var str = new[] { "lol", "ffgf" };                        // неявно типизированная строка
            }
        }
        static void a_corteg()
        {
            // a part
            (int, string, char, string, ulong) tuple = (19, "STR", 'm', "ASDASDASD", 888888);
            // b part
            Console.WriteLine(tuple);
            Console.WriteLine($"{tuple.Item1}  {tuple.Item3} {tuple.Item4} ");
            // c part
            string name;
            int age;

            (string name, ushort age) man = ("Kirill", 19);
            name = man.name;
            age = man.age;
            Console.WriteLine(man == ("Kirill", 18)); 
            Console.WriteLine(man == ("Kirill", 19)); 
            (name, _, _) = tuplesReturn();
            static (string, ushort, char) tuplesReturn()
            {
                return ("Gleb", 19, 's');
            }
            object mans = man;

           

        }
        static (int max, int min, int sum, char firstLetter) task5(int[] a, string str)
        {

            if ((a is null || a.Length == 0) || (str is null || str.Length == 0))
            {
                throw new ArgumentException("строка или элемент null");
            }

            int min = 0;
            int max = 0;
            int sum = 0;

            foreach (int i in a)
            {
                sum += i;

                if (i < min)
                {
                    min = i;
                }

                if (i > max)
                {
                    max = i;
                }
            }

            char letter = str[0];

            return (max, min, sum, letter);
        }
        static void task6_checked()
        {
            checked
            {
                int i = int.MaxValue ;
                i++;
            }
        }

        static void task6_unchecked()
        {
            unchecked
            {
              
                int i = int.MaxValue ;

            }
           
        }
    }
       
}
