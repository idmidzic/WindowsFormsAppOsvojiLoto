﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppOsvojiLoto
{
    class Kuglice
    {
        // Konstruktor
        public Kuglice(int donjaGranica, int gornjaGranica)
        {
            // inicijalizirani donja i gornja
            this.donjaGranica = donjaGranica;
            this.gornjaGranica = gornjaGranica;
            
            for (int idx = donjaGranica; idx <= gornjaGranica; idx++)
                brojeviZaIzvlacenje.Add(idx);
        }
      
        // Ipak ostaje 1 do 36, neće se mijenjati tijekom programa
        private readonly int donjaGranica;
        private readonly int gornjaGranica;

        //public int[] slucajniBrojevi = new int[6];
        private List<int> izvuceniBrojevi = new List<int>();
        private List<int> brojeviZaIzvlacenje = new List<int>();

        private Random rnd = new Random();

        // Metoda koja se poziva kad se klikne na gumb IzvuciKuglicuButton  
        public int izvuciKuglicu()
        {
            int indeks = rnd.Next(0, brojeviZaIzvlacenje.Count);
            int izvuceniBroj = brojeviZaIzvlacenje[indeks];
            izvuceniBrojevi.Add(izvuceniBroj);
            brojeviZaIzvlacenje.Remove(izvuceniBroj);
            return izvuceniBroj;
        }
        //property 
        //public int[] IzvuceniBrojevi
        //{
        //    get { return izvuceniBrojevi.ToArray(); }
        //}
           
    }
}