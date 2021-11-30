using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOsvojiLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            // 6 kuglica, 1-36
            int donji = 1;
            int gornji = 36;
            int[] slucajniBrojevi = new int[6];
            bool zastavica = false;


            // Promijeniti tekst na Buttonu klikni: Klikni za novo izvačenje
            // idx globalna varijabla
            // automatsko izvlačenje sve odjednom u 1 buttonu
            // zvukovi ting ting kad se izvuče broj, pauza između izvlačenja
            // sporo izvlačenje
            // controls of array


            TextBox[] brojevi = new TextBox[6];


            listBox1.Items.Clear();
            Random rnd = new Random();
            for (int idx = 0; idx < 6; idx++)
            {
                zastavica = false;

                do
                {

                    slucajniBrojevi[idx] = rnd.Next(donji, gornji);
               

                    if (idx > 0)
                    {

                        for (int jdx = 0; jdx == idx; jdx++)
                        {

                            if (slucajniBrojevi[jdx] == slucajniBrojevi[idx])
                            {
                                zastavica = true;
                                // break;
                            }

                        }
                    }
                } while (zastavica == true);

                listBox1.Items.Add(slucajniBrojevi[idx]);
                int broj = slucajniBrojevi[idx];
                
                txt_1.Text = txt_1.Text + broj.ToString() +"     "; 
            }
                        
           //int len = slucajniBrojevi.Length; 
            
            //listBox1.Items.Add(len);
            //string str = broj.ToString();

            //foreach (string i in myArray2)
            //{
            //    myArray2[0] = str;
            //    listBox1.Items.Add(myArray2);
            //}
            //txt_1.Text = broj.ToString();

            //for (int idx = 1; idx < 5; idx++)
            //{
            //    Random rnd = new Random();

            //    int broj = rnd.Next(lower, upper);
            //    myArray.Append(broj);
            //    listBox1.Items.Add(txt_1.Text);
               //txt_1.Text = broj.ToString();
            //}


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
    }

        private void txt_1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
