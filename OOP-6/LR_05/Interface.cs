using System;
using System.Collections.Generic;
using System.Text;

namespace LR_05
{
    interface IRazum
    {
        void Info();
    }

    public  class Razum : IRazum
    {
        protected string Name;
        protected int Age;
        protected string color;
        private readonly int id;
        public List<Razum> Army;

        public virtual void Info() { Console.WriteLine(this.Name); }
        public void AddRazum(Razum a) { Army.Add(a); }
        public void DelRazum(Razum a) { Army.Remove(a); }

        public Razum(string Name, int Age, string color)
        {
            this.Name = Name;
            this.Age = Age;
            this.color = color;
           
            id = (int)id.GetHashCode() + (int)Name.GetHashCode();
        }

        public Razum()
        {
         
                this.Army = new List<Razum>(10);
            
        }

        public void ShowList()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n" + "Список Армии: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (Razum elem in Army)
            {
                Console.WriteLine(elem.ToString());
            }
        }
        public void FindAge()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nПоиск трансформера определенного возраста.");
            Console.ForegroundColor = ConsoleColor.Gray;
            List<Razum> programmer = new List<Razum>(10);
            int amount = 0;
            int result = Convert.ToInt32(Console.ReadLine());
            //int age = 1000;
            foreach (Razum item in Army)
            {
                if (item is Trans)
                {
                    if (item.Age == result)
                    {
                        Console.WriteLine($"Трансформер под номером #{amount + 1} столько лет {item.Age} ");
                      
                    }
                   
                    amount++;
                }
            }
            Console.WriteLine($"Колличество трансформерров: {amount}");
        }
        public void Findarmy()
        {
            
            List<Razum> programmer = new List<Razum>(10);
            int amount = 0;
            int age = 1000;
            foreach (Razum item in Army)
            {
                    amount++;

                         }
            Console.WriteLine($"Колличество солдат: {amount}");
        }









        public override string ToString() // переопределение с выводом инфы
        {
            
            Console.WriteLine($"Имя: {Name};\nВозраст: {Age};\n цвет: {color};\n");
            return  base.ToString();
           

        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != this.GetType())
                return false;
            return this.Name == ((Razum)obj).Name;
        }
        public override int GetHashCode()
        {
            int hash = 47, d = 32;
            string a = Convert.ToString(Name);
            hash = string.IsNullOrEmpty(a) ? 0 : Name.GetHashCode();
            hash = (hash * 47) + d.GetHashCode();
            return hash;
        }
       
    }

    //Человек
    sealed class people : Razum, IRazum
    {
        private string pol;       //пол
        
        public people(string Name, int Age, string color, string pol)
            : base (Name, Age, color)
        {
           
            this.pol = pol;
        }
        public override void Info()
        {
            
            Console.WriteLine($"Имя: {Name};\nВозраст: {Age};\n цвет: {color};\n" +
                $"Пол: {pol};\n");
        }
        public override string ToString()
        {
           
            string Info = $"Имя: {Name};\nВозраст: {Age};\n цвет: {color};\n" +
                $"Пол: {pol};\n";


            return Info;
        }
    }

    //Трансформер
    public  class  Trans : Razum, IRazum
    {
       public string rasa;         //расса
        public string planeta;   //планета

        public Trans(string Name, int Age, string color, string rasa,string planeta )
            : base(Name, Age, color)
        {
            this.rasa = rasa;
            this.planeta = planeta;
        }
        public override void Info()
        {
            Console.WriteLine($"Имя: {Name};\nВозраст: {Age};\ncolor: {color};\n" +
                $"Расса: {rasa};\nПланета: {planeta}");
        }
        public override string ToString()
        {

            return ($"Имя: {Name};\nВозраст: {Age};\ncolor: {color};\n" +
                $"Расса: {rasa};\nПланета: {planeta}");
          
        }
    }

    //транспортное средство
    sealed class Sredstwo : Trans, IRazum
    {
 

        public Sredstwo(string Name, int Age, string color, string rasa, string planeta)
            : base(Name, Age, color,rasa,planeta)
        {
           
        }
        public override void Info()
        {
            Console.WriteLine($"Имя: {Name};\nВозраст: {Age};\nЦвет: {color};\n" +
                $"Расса: {rasa};\nСтрана:{planeta}");
        }
    
    }



    //МАшина
    sealed class Car : Razum, IRazum
    {
        private int number;   //номер
       

        public Car(string Name, int Age, string color,int number )
            : base(Name, Age, color)
        {
            this.number = number;
            
        }
        public override void Info()
        {
            Console.WriteLine($"Имя: {Name};\nВозраст: {Age};\ncolor: {color};\n" +
                $"Номер машины: {number}; \n");
        }
        public override string ToString()
        {
           
            return ($"Номер машины: {number};");

        }
    }


    //Двигатель
    sealed class Dvig : Razum, IRazum
    {
        private int power;
        

        public Dvig(string Name, int Age, string color,int power )
            : base(Name, Age, color)
        {
            this.power = power;
        }
        public override void Info()
        {
            Console.WriteLine($"Имя: {Name};\nВозраст: {Age};\ncolor: {color};\n" +
                $"Мощность двигателя{power}" + "л.с");
        }
        public override string ToString()
        {
            
            return ($"Мощность двигателя{power}" + "л.с");

        }
    }
    public class Printer
    {
        public void IAmPrinting(Razum value)
        {
            Console.WriteLine(value.ToString());
        }
    }

}
