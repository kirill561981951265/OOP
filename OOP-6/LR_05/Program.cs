using System;

namespace LR_05
{
    class LR_05
    {
        static void Main(string[] args)
        {
            people object1 = new people("Амеба", 1000, "зеленый","М" );
            Trans object2 = new Trans("Мегатрон", 1001, "красный", "Дессиптикон","Кибертрон");
            Trans object3 = new Trans("Мегатрон", 1002, "красный", "Дессиптикон", "Кибертрон");
            Trans object4 = new Trans("Мегатрон", 1000, "красный", "Дессиптикон", "Кибертрон");
            Trans object5 = new Trans("Мегатрон1", 1001, "красный", "Дессиптикон", "Кибертрон");

            Razum Army = new Razum();
            Army.AddRazum(object2);
            Army.AddRazum(object3);
            Army.AddRazum(object4);
            Army.AddRazum(object5);
            Army.AddRazum(object1);


            Army.ShowList();
            Army.Findarmy();
            Army.FindAge();

        }
    }
}
