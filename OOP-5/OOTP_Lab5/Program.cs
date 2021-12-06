using System;

namespace OOTP_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            IDescription[] array = new IDescription[8];
            array[0] = new Window("Exel");
            array[1] = new ViewPort("Word", 1654);
            array[2] = new Element("Access", 148, 2);
            array[3] = new Button("MathCad", 4567, 4, 8);
            array[4] = new Figure("HTML", 4512, 2, 3, 8);
            array[5] = new Rectangle("Opel", 456789, 1, 4, 4, "rectangle", 5, 4);
            array[6] = new TextBox("baba", 2000, 2, 3);
            Console.WriteLine(array[5].ToString());
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(array[0] is Window);
            array[7] = array[4] as Button;
            if (array[7] != null)
            {
                Console.WriteLine("Object realize interface Button");
            }
            else
                Console.WriteLine("Object don't realize interface Button");
            Console.WriteLine("-------------------------------------------------------------");
            Printer p = new Printer();
            for (int i = 0; i < 7; i++)
            {
                p.IAmPrinting(array[i]);
            }
        }
    }
}
