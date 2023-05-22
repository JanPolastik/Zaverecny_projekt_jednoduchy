using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Závěrečný_projekt
{
    internal class Pojisteny
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek { get; set; }
        public int Telefon { get; set; }
        public Pojisteny (string jmeno, string prijmeni, int vek, int telefon) 
        { 
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Telefon = telefon;
        }
        
        public override string ToString()
        {
            
            while (Jmeno.Length < 15)
            {
                Jmeno += " ";
            }
            while (Prijmeni.Length < 15)
            {
                Prijmeni += " ";
            }
            return Jmeno + Prijmeni + Vek + "\t" + Telefon;
        }

    }
}
