using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOsvojiLoto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GlavnaForma());
            
        }
    }

    public class Glavna
    {


    // Privremeno public varijable dok se ne definiraju metode i pozivi
    public int donjaGranica = 1;
    public int gornjaGranica = 37;
    public int[] slucajniBrojevi = new int[6];
    public bool zastavica = false;
        public int indeks = 0;

        static Random rnd = new Random();
        // Metoda koja se poziva kad se klikne na gumb   
        public void izvuciKuglicu(int donjaGranica, int gornjaGranica)
        {
            if (indeks == 0)
            {
                // počinje izvačenje, pozovi random funkciju i započni izvlačenje prve kuglice
                Random rnd = new Random();
            }
            else
            {
                slucajniBrojevi[indeks] = rnd.Next(donjaGranica, gornjaGranica);
                int brojIzvucenihKuglica = slucajniBrojevi.Length;
                if (brojIzvucenihKuglica < 6)
                {
                    // ispitati nalazi li se izvučeni broj već u polju slucajni broj
                    for (int idx = 0; idx == 5; idx++)
                    {
                        // slučajni broj je već izvučen, izvuci drugi broj
                        if (slucajniBrojevi[idx] == slucajniBrojevi[indeks])         
                        {
                            slucajniBrojevi[indeks] = rnd.Next(donjaGranica, gornjaGranica);                                
                        }
                        else
                        {
                            indeks = indeks + 1;
                        }
                    }
                }
            }   
        }
    }
}
//        TextBox[] brojevi = new TextBox[6];


//        listBox1.Items.Clear();
//            Random rnd = new Random();
//            for (int idx = 0; idx< 6; idx++)
//            {
//                zastavica = false;

//                do
//                {

//                    slucajniBrojevi[idx] = rnd.Next(donjaGranica, gornjaGranica);


//                    if (idx > 0)
//                    {

//                        for (int jdx = 0; jdx == idx; jdx++)
//                        {

//                            if (slucajniBrojevi[jdx] == slucajniBrojevi[idx])
//                            {
//                                zastavica = true;
//                                // break;
//                            }

//}
//                    }
//                } while (zastavica == true) ;

//listBox1.Items.Add(slucajniBrojevi[idx]);
//int broj = slucajniBrojevi[idx];

//txt_1.Text = txt_1.Text + broj.ToString() + "     "; 
//            }
