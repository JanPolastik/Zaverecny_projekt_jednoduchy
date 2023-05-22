using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Závěrečný_projekt
{
    internal class SpravaPojistenych
    {
        private Databaze databaze = new Databaze();
        
        private string ZjistiJmeno()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = Console.ReadLine();
            return jmeno;
        }
        private string ZjistiPrijmeni()
        {
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = Console.ReadLine();
            return prijmeni;
        }
        public void VypisPojistene()
        {
            List<Pojisteny> pojisteni = databaze.VypisPojistene();
            Console.WriteLine();
            Console.WriteLine("Seznam pojištěných");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Jméno          Příjmení        Věk \tTelefon");
            Console.WriteLine("------------------------------------------------");
            foreach (Pojisteny p in pojisteni)
            {
                Console.WriteLine(p);
            }
        }
        public void PridejPojisteneho()
        {
            string jmeno = ZjistiJmeno();
            string prijmeni = ZjistiPrijmeni();
            Console.WriteLine("Zadejte věk:");
            int vek = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte telefonní číslo:");
            int telefon = int.Parse(Console.ReadLine());

            databaze.PridejPojisteneho(jmeno , prijmeni, vek, telefon);
        }
        public void VyhledejPojistene()
        {
            string jmeno = ZjistiJmeno();
            string prijmeni = ZjistiPrijmeni();
            List<Pojisteny> pojisteni = databaze.NajdiPojisteneho(jmeno, prijmeni);
            if (pojisteni.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Nalezení pojištění:");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Jméno          Příjmení        Věk \tTelefon");
                Console.WriteLine("------------------------------------------------");
                foreach (Pojisteny p in pojisteni)
                    Console.WriteLine(p);
            } 
            else 
            {
                Console.WriteLine("Nenalezeno");
            }
            
        }
        public void VymazPojistene()
        {
            Console.WriteLine("Budou vymazáni nalezení pojištění");
            string jmeno = ZjistiJmeno();
            string prijmeni = ZjistiPrijmeni();
            databaze.VymazPojisteneho (jmeno, prijmeni);
        }
        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

        }
    }
}
