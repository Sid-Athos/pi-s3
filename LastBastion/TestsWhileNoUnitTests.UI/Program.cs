using System;
using LastBastion.Model;

namespace TestsWhileNoUnitTests.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Villagers sid = new Villagers(false, 10.5f, 11.6f, "Villageois", 25, 5, 0,false, 3, 0.2f);
            Villagers feras = new Villagers(false, 10.5f, 11.6f, "Villageois", 25, 5, 1, false, 3, 0.2f);

            if(sid != null)
            {
                Console.WriteLine("Wallah il existe !!");
            }

            sid.AddVillager(sid);
            feras.AddVillager(feras);

            Console.WriteLine("Nombre de villageois  : {0}", sid.VillCount);

            Console.WriteLine("Vie de sid  : {0}", sid.Life);

            sid.Attack(feras);
            sid.Attack(feras);
            sid.Attack(feras);
            sid.Attack(feras);
            sid.Attack(feras);
            sid.Attack(feras);
            sid.Attack(feras);



            Console.WriteLine("Vie de feras  : {0}", feras.Life);

            Towers hugo = new Towers(0.5f, 0.6f, 250, 3, 1, 2, 1);

            hugo.Attack(sid);
            hugo.Attack(sid);
            hugo.Attack(sid);
            hugo.Attack(sid);

            Console.WriteLine("La tour dispose de {0} emplacement(s) pour des soldats.", hugo.AvailableSlots);

            hugo.Upgrade();
            hugo.Upgrade();
            hugo.Attack(sid);
            hugo.Attack(sid);

            hugo.AddArcher(sid);
            hugo.AddArcher(feras);




            Console.WriteLine("La tour dispose de {0} emplacement(s) pour des soldats.", hugo.AvailableSlots);
            Console.WriteLine("La tour est occupée par {0} soldat(s).", hugo.ShowArchers());
            Console.WriteLine("Le soldat {0} est dans une tour : {1}.", sid.Job, sid.IsInTower);
            Console.WriteLine("Le soldat {0} est dans une tour : {1}.", feras.Job, feras.IsInTower);
            Console.WriteLine("La tour dispose de {0} armure.", hugo.Armor);
            Console.WriteLine("La tour dispose de {0} dégâts", hugo.Dmg);
            Console.WriteLine("La tour dispose de {0} points de vie maximum.", hugo.MaxLife);
            Console.WriteLine("La tour dispose de {0} points de vie.", hugo.Life);
            
            Console.WriteLine("Vie de Sid  : {0}", sid.Life);

            Console.WriteLine("Vie de fefe  : {0}", feras.Life);
            
            Console.ReadKey();
        }
    }
}
