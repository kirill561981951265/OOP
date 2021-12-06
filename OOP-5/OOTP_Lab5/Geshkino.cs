//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace OOTP_Lab5
//{
//    public interface IDescription
//    {
//        void Display();
//    }

//    class Human : IDescription
//    {
//        private int hash = 0;
//        public string name;

//        public Human(string _name)
//        {
//            name = _name;
//        }

//        public void Say(string str)
//        {
//            Console.WriteLine($"Человек сказал: {str}");
//        }

//        void IDescription.Display()
//        {
//            Console.WriteLine("This is a human");
//        }

//        public override bool Equals(object obj)
//        {
//            return obj is Human;
//        }

//        public override int GetHashCode()
//        {
//            return hash++;
//        }

//        public override string ToString()
//        {
//            string description = $"Object name: {nameof(Human)}\n" +
//                $"Name: {name}";

//            return description;
//        }

//    }

//    class ArtificialIntelligence : Human, IDescription
//    {
//        public int memory { get; set; }

//        public ArtificialIntelligence(string name, int _memory) : base(name)
//        {
//            memory = _memory;
//        }

//        void IDescription.Display()
//        {
//            Console.WriteLine("This is a artificial intelligence");
//        }

//        public override string ToString()
//        {
//            string description = $"Object name: {nameof(ArtificialIntelligence)}\n" +
//                $"Name: {name}\n" +
//                $"Memory: {memory}";

//            return description;
//        }
//    }

//    class Engine : ArtificialIntelligence, IDescription
//    {
//        public int fuel;
//        public Engine(string _name, int _memory, int _fuel)
//            : base(_name, _memory)
//        {
//            fuel = _fuel;
//        }
//        void IDescription.Display()
//        {
//            Console.WriteLine("This is an engine");
//        }

//        public override string ToString()
//        {
//            string description = $"Object name: {nameof(Engine)}\n" +
//                $"Name: {name}\n" +
//                $"Memory: {memory}\n" +
//                $"Fuel: {fuel}";

//            return description;
//        }
//    }

//    class Controls : Engine, IDescription
//    {
//        public bool movable;

//        public Controls(string _name, int _memory, int _fuel, bool _movable)
//            : base(_name, _memory, _fuel)
//        {
//            movable = _movable;
//        }
//        void IDescription.Display()
//        {
//            Console.WriteLine("This is a controls");
//        }
//        public override string ToString()
//        {
//            string description = $"Object name: {nameof(Controls)}\n" +
//                $"Name: {name}\n" +
//                $"Memory: {memory}\n" +
//                $"Fuel: {fuel}\n" +
//                $"Movable: {movable}";

//            return description;
//        }
//    }

//    class Car : Controls, IDescription
//    {
//        public string color;

//        public Car(string _name, int _memory, int _fuel, bool _movable, string _color)
//            : base(_name, _memory, _fuel, _movable)
//        {
//            color = _color;
//        }

//        void IDescription.Display()
//        {
//            Console.WriteLine("This is a car");
//        }

//        public override string ToString()
//        {
//            string description = $"Object name: {nameof(Car)}\n" +
//                $"Name: {name}\n" +
//                $"Memory: {memory}\n" +
//                $"Fuel: {fuel}\n" +
//                $"Movable: {movable}\n" +
//                $"Color: {color}";

//            return description;
//        }
//    }

//    class Transport : Car, IDescription
//    {
//        public string type;

//        public Transport(string _name, int _memory, int _fuel, bool _movable, string _color, string _type)
//            : base(_name, _memory, _fuel, _movable, _color)
//        {
//            type = _type;
//        }

//        void IDescription.Display()
//        {
//            Console.WriteLine("This is a transport");
//        }

//        public override string ToString()
//        {
//            string description = $"Object name: {nameof(Car)}\n" +
//                $"Name: {name}\n" +
//                $"Memory: {memory}\n" +
//                $"Fuel: {fuel}\n" +
//                $"Movable: {movable}\n" +
//                $"Color: {color}\n" +
//                $"Type: {type}";

//            return description;
//        }
//    }

//    class Transformer : Transport, IDescription
//    {
//        bool enemy;

//        public Transformer(string _name, int _memory, int _fuel, bool _movable, string _color, string _type, bool _enemy)
//            : base(_name, _memory, _fuel, _movable, _color, _type)
//        {
//            enemy = _enemy;
//        }
//        void IDescription.Display()
//        {
//            Console.WriteLine("This is a Transformer");
//        }

//        public override string ToString()
//        {
//            string description = $"Object name: {nameof(Car)}\n" +
//                $"Name: {name}\n" +
//                $"Memory: {memory}\n" +
//                $"Fuel: {fuel}\n" +
//                $"Movable: {movable}\n" +
//                $"Color: {color}\n" +
//                $"Type: {type}\n" +
//                $"Is enemy: {enemy}";

//            return description;
//        }
//    }

//    abstract public class BaseClone
//    {
//        public abstract void Clone();
//    }


//    class userClass : BaseClone, IDescription
//    {
//        public override void Clone()
//        {
//            Console.WriteLine("using abstract class to make functions");
//        }

//        void IDescription.Display()
//        {
//            Console.WriteLine("this is iDescription function of my user class");
//        }
//    }

//    public class Printer
//    {
//        public void IAmPrinting(IDescription obj)
//        {
//            obj.Display();
//        }
//    }



//    class Program
//    {
//        static void Main(string[] args)
//        {


//            IDescription[] array = new IDescription[7];
//            array[0] = new Human("Zheka");
//            array[1] = new ArtificialIntelligence("Vova", 1000);
//            array[2] = new Engine("Antoha", 0, 25);
//            array[3] = new Controls("Ruchnik", 0, 22, true);
//            array[4] = new Car("Pejo", 0, 222, true, "red");
//            array[5] = new Transport("Opel", 0, 222, true, "blue", "hatchback");
//            array[6] = new Transformer("bababoi", 20000, 200000, true, "black", "transformer", true);


//            Console.Write(array[0] is Human);
//            Printer p = new Printer();
//            for (int i = 0; i < 7; i++)
//            {
//                p.IAmPrinting(array[i]);
//            }
//        }
//    }
//}
