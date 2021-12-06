using System;
using System.Collections.Generic;
using System.Text;

namespace LR_05
{
    interface IRazum
    {
        void Info();
    }

    public abstract class Razum : IRazum
    {
        protected string Name;
        protected int Age;
        protected string color;
        private readonly int id;

        public Razum(string Name, int Age, string color)
        {
            this.Name = Name;
            this.Age = Age;
            this.color = color;
           
            id = (int)id.GetHashCode() + (int)Name.GetHashCode();
        }

        public override string ToString() // переопределение с выводом инфы
        {
            
            Console.WriteLine($"Имя: {Name};\nВозраст: {Age};\n цвет: {color};\n");
            return " type " + base.ToString();
           

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
        public abstract void Info();
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
           
            string Info = $"Пол: {pol};\n";
            
           
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

            return ($"Расса: {rasa};\nПланета: {planeta}");
          
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
