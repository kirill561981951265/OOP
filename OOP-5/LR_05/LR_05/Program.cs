using System;

namespace LR_05
{
    class LR_05
    {
        static void Main(string[] args)
        {
            people object1 = new people("Амеба", 1000, "зеленый","М" );
            Trans object2 = new Trans("Мегатрон", 1000, "красный", "Дессиптикон","Кибертрон");
            Sredstwo object3 = new Sredstwo("Яхта", 10, "Белая", "Китаец", "Земля");
            Car object4 = new Car("Mersedes", 15, "Черный ", 123456);
            Dvig object5 = new Dvig("MBX-4000",1, "Черный", 4000);



           

            Printer printer = new Printer();
            Razum[] razum = new Razum[] {object1, object2, object3,object4,object5  };
            for (int i = 0; i < razum.Length; i++)
            {
                printer.IAmPrinting(razum[i]);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("=============================");
        }
    }
}
