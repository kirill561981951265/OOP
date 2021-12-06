using System;

namespace LR_09
{
    public class director
    {
        public int people;
        public string Name;
        public string professional;
        public string st;
        public delegate void List(string message);
        public event List Notify;

        public director(int people, string Name)
        {
            this.people = people;
            this.Name = Name;
        }

        public void Poniz()
        {
        
            Random ZP = new Random();
            int ZPValue = ZP.Next(50, 150);
            this.people = this.people - ZPValue;
            Notify.Invoke($"\nРаботник  {this.Name} - понижена зп!\nПонижена на {ZPValue}.\nТекущая зарплата сотрудника: {this.people}\n");
           
        }

        public void Povs()
        {
            Random ZP = new Random();
            int ZPValue = ZP.Next(0, 200);
            this.people = this.people + ZPValue;
            Notify.Invoke($"\nРаботник  {this.Name} - повышена зп!\nПовышена на {ZPValue}.\nТекущая зарплата сотрудника: {this.people}\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void DisplayNotify(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Hero : director
    {
        public Hero(int people, string Name):base(people, Name)
        {
            this.professional = "Токарь";
            Console.WriteLine($"Поступил новый работник:\nИмя: {this.Name}\nТип: {this.professional}\nТекущая зарплата сотрудника: {this.people}\n");
           
        }
    }

    public class Stol : director
    {
     

                public Stol(int people, string Name) : base(people, Name)
        {
            this.professional = "Студент";
            this.st = "10";
            Console.WriteLine($"Поступил новый работник:\nИмя: {this.Name}\nТип: {this.professional}\nТекущая зарплата сотрудника: {this.people}\n Стаж:{this.st}");
        }
    }
}
