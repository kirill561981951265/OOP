using System;
using System.Collections.Generic;
using System.Text;

namespace OOTP_Lab5
{

    public interface IDescription
    {
        void Display();
    }
    public abstract class Content 
    {
        public abstract string ToString();
    }

    class Window : IDescription
    {
        private int hash = 0;
        public string ProgramName;
        public Window(string name)
        {
            ProgramName = name;
        }
        void IDescription.Display()
        {
            Console.WriteLine("This is a Window");
        }
        public override bool Equals(object obj)
        {
            return obj is Element;
        }
        public override int GetHashCode()
        {
            return hash++;
        }
        public override string ToString()
        {
            string description =    $"Object name: {nameof(Window)}\n";
            return description;
        }
    }
    class ViewPort : Window, IDescription
    {
        public int memory { get; set; }

        public ViewPort(string ProgramName, int _memory) : base(ProgramName)
        {
            memory = _memory;
        }
        void IDescription.Display()
        {
            Console.WriteLine("This is a ViewPort");
        }
        public override string ToString()
        {
            string description =    $"Object name of program: {nameof(Window)}\n" +
                                    $"Number of ViewPorts: {nameof(ViewPort)}\n";
            return description;
        }
    }
    class Element : ViewPort, IDescription
    {
        public int numel { get; set; }

        public Element(string ProgramName, int _memory, int _numel) : base(ProgramName, _memory)
        {
            numel = _numel;
        }
        void IDescription.Display()
        {
            Console.WriteLine("This is an Element");
        }
        public override string ToString()
        {
            string description =    $"Object name of program: {ProgramName}\n" +
                                    $"Number of ViewPort: {memory}\n" + 
                                    $"Number of control element: {numel}\n";

            return description;
        }
    }
    class Button : Element, IDescription
    {
        public int numbut;
        public Button(string Name, int _memory, int _numel, int _numbut)
            : base(Name, _memory, _numel)
        {
            numbut = _numbut;
        }
        void IDescription.Display()
        {
            Console.WriteLine("This is a Button of Element");
        }
        public override string ToString()
        {
            string description = $"Object name of program: {ProgramName}\n" +
                                    $"Number of ViewPort: {memory}\n" +
                                    $"Number of control element: {numel}\n" +
                                    $"Number of button: {numbut}\n";
            return description;
        }
    }
    class Figure : Button, IDescription
    {
        public int angle;
        public Figure(string Name, int _memory, int _numel, int _numbut, int _angle)
            : base(Name, _memory, _numel, _numbut)
        {
            angle = _angle;
        }
        void IDescription.Display()
        {
            Console.WriteLine("This is a Figure of Button of Element");
        }
        public override string ToString()
        {
            string description = $"Object name of program: {ProgramName}\n" +
                                    $"Number of ViewPort: {memory}\n" +
                                    $"Number of control element: {numel}\n" +
                                    $"Number of button: {numbut}\n" +
                                    $"Number of angle: {angle}\n";
            return description;
        }
    }
    sealed class Rectangle : Figure, IDescription
    {
        public string type;
        public int squere;
        public Rectangle(string Name, int _memory, int _numel, int _numbut, int _angle, string _type, int a, int b)
            : base(Name, _memory, _numel, _numbut, _angle)
        {
            type = _type;
            squere = resize(a, b);
        }
        void IDescription.Display()
        {
            Console.WriteLine("This is a Rectangle of Figure of Button of Element");
        }
        int resize(int a, int b)
        {
            int sq = a * b;
            return sq;
        }
        public override string ToString()
        {
            string description =    $"Object name of program: {ProgramName}\n" +
                                    $"Number of ViewPort: {memory}\n" + 
                                    $"Number of control element: {numel}\n" +  
                                    $"Number of button: {numbut}\n" + 
                                    $"Number of angle: {angle}\n" + 
                                    $"Name of type: {type}\n" + 
                                    $"Him squere : {squere}\n";
           return description;
        }
    }
    class TextBox : Element, IDescription
    {
        public int numText;
        public TextBox(string Name, int _memory, int _numel, int _numText)
            : base(Name, _memory, _numel)
        {
            numText = _numText;
        }
        void IDescription.Display()
        {
            Console.WriteLine("This is a TextBox of Element");
        }
        public override string ToString()
        {
            string description =    $"Object name of program: {ProgramName}\n" +
                                    $"Number of ViewPort: {memory}\n" + 
                                    $"Number of control element: {numel}\n" + 
                                    $"Number of TextBox: {numText}\n";

            return description;
        }
    }

    public class Printer
    {
        public void IAmPrinting(IDescription obj)
        {
            obj.Display();
        }
    }
   
}
