using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Závěrečný_projekt
{
    internal class Databaze
    {
        private List<Pojisteny> evidence = new List<Pojisteny>();
        
        public void PridejPojisteneho(string jmeno, string prijmeni, int vek, int telefon)
        {
            evidence.Add(new Pojisteny(jmeno, prijmeni, vek, telefon));
        }
        public List<Pojisteny> NajdiPojisteneho(string jmeno, string prijmeni)
        {
            List<Pojisteny> nalezene = new List<Pojisteny>();
            foreach (Pojisteny p  in evidence)
            {
                if ((p.Jmeno.Equals(jmeno)) && (prijmeni.Equals(p.Prijmeni)))
                {
                    nalezene.Add(p);
                }
            }
            return nalezene;
        }
        public void VymazPojisteneho(string jmeno, string prijmeni)
        {
            List<Pojisteny> nalezeno = NajdiPojisteneho(jmeno, prijmeni);
                foreach(Pojisteny p in nalezeno)
                    evidence.Remove(p);
        }
        public List<Pojisteny> VypisPojistene()
        {
            List<Pojisteny> pojisteni = new List<Pojisteny>();
            foreach (Pojisteny p in evidence)
            {
                pojisteni.Add(p);
            }
            return pojisteni;
        }
    }
}
