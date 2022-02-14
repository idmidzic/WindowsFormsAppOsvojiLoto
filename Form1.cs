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
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
            poljaZaKuglice = new List<TextBox> { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6 };

        }

        private Kuglice kuglice = null;

        private List<TextBox> poljaZaKuglice = null;
        private int sljedećePolje = 0;

        private void IzvuciKuglicuButton_Click(object sender, EventArgs e)
        {
            if (kuglice == null) 
                kuglice = new Kuglice(1, 37);

            int novaKuglica = kuglice.izvuciKuglicu();
            poljaZaKuglice[sljedećePolje].Text = novaKuglica.ToString();
            sljedećePolje++;

            if (sljedećePolje > poljaZaKuglice.Count)
            {

                // poruka gotovo izvlačenje, MessageBox();

                // Disable IzvuciKuglicuButton, promijeni izgled gumba
                //IzvuciKuglicuButton.Enabled = false;
                IzvuciKuglicuButton.BackColor = System.Drawing.SystemColors.ControlLight;
                IzvuciKuglicuButton.ForeColor = System.Drawing.SystemColors.ControlDark;

                // Enable NovoIzvlacenjeButton, promijeni izgled gumba
                //NovoIzvlacenjeButton.Enabled = true;
                NovoIzvlacenjeButton.BackColor = System.Drawing.Color.Khaki;
                NovoIzvlacenjeButton.ForeColor = System.Drawing.Color.OrangeRed;
            }
          

            










            // 6 kuglica, 1-36
            //int donji = 1;
            //int gornji = 36;
            //int[] slucajniBrojevi = new int[6];
            //bool zastavica = false;


            // Promijeniti tekst na Buttonu klikni: Klikni za novo izvačenje, klikni za 1., 2. 3,. kuglicu
            // idx globalna varijabla
            // automatsko izvlačenje sve odjednom u 1 buttonu
            // zvukovi ting ting kad se izvuče broj, pauza između izvlačenja
            // sporo izvlačenje kuglica
            // controls - array of textboxes 


            //TextBox[] brojevi = new TextBox[6];


            //listBox1.Items.Clear();
            //Random rnd = new Random();
            //for (int idx = 0; idx < 6; idx++)
            //{
            //    zastavica = false;

            //    do
            //    {

            //        slucajniBrojevi[idx] = rnd.Next(donjaGranica, gornjaGranica);


            //        if (idx > 0)
            //        {

            //            for (int jdx = 0; jdx == idx; jdx++)
            //            {

            //                if (slucajniBrojevi[jdx] == slucajniBrojevi[idx])
            //                {
            //                    zastavica = true;
            //                    // break;
            //                }

            //            }
            //        }
            //    } while (zastavica == true);

            //    listBox1.Items.Add(slucajniBrojevi[idx]);
            //    int broj = slucajniBrojevi[idx];

            //    txt_1.Text = txt_1.Text + broj.ToString() +"     "; 
            //}

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

             

        private void NovoIzvlacenjeButton_Click(object sender, EventArgs e)
        {
            if (sljedećePolje > poljaZaKuglice.Count)
            {
                // kuglice postavi na null za novo izvlačenje
                //kuglice = null;

                // Očisti textbox unose
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";


                // Enable IzvuciKuglicuButton, promijeni izgled gumba
                //IzvuciKuglicuButton.Enabled = true;
                IzvuciKuglicuButton.BackColor = System.Drawing.Color.LightGreen;
                IzvuciKuglicuButton.ForeColor = System.Drawing.Color.Green;

                // Disable NovoIzvlacenjeButton, promijeni izgled gumba
                //NovoIzvlacenjeButton.Enabled = false;
                NovoIzvlacenjeButton.BackColor = System.Drawing.SystemColors.ControlLight;
                NovoIzvlacenjeButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {

        }
    }
}


