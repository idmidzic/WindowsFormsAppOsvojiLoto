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
                kuglice = new Kuglice(1, 36);

            int novaKuglica = kuglice.izvuciKuglicu();
            
            if (sljedećePolje < poljaZaKuglice.Count)
            {
                poljaZaKuglice[sljedećePolje].Text = novaKuglica.ToString();
                sljedećePolje++;
            }
            
            if (sljedećePolje == 6)
            {
                sljedećePolje = 0;

                // poruka gotovo izvlačenje, MessageBox();

                // Disable IzvuciKuglicuButton, promijeni izgled gumba
                IzvuciKuglicuButton.Enabled = false;
                IzvuciKuglicuButton.BackColor = System.Drawing.SystemColors.ControlLight;
                IzvuciKuglicuButton.ForeColor = System.Drawing.SystemColors.ControlLight;
                IzvuciKuglicuButton.Text = "";

                // Enable NovoIzvlacenjeButton, promijeni izgled gumba
                NovoIzvlacenjeButton.Enabled = true;
                NovoIzvlacenjeButton.BackColor = System.Drawing.Color.LightGreen;
                NovoIzvlacenjeButton.ForeColor = System.Drawing.Color.DarkGreen;
                NovoIzvlacenjeButton.Text = "Započni novo izvlačenje!";
            }
          
        }
             

        private void NovoIzvlacenjeButton_Click(object sender, EventArgs e)
        {      
            
            // kuglice postavi na null za novo izvlačenje
            kuglice = null;

            // Očisti textbox unose
            textBox1.Clear();
               // Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            // Enable IzvuciKuglicuButton, promijeni izgled gumba
            IzvuciKuglicuButton.Enabled = true;
            IzvuciKuglicuButton.BackColor = System.Drawing.Color.LightGreen;
            IzvuciKuglicuButton.ForeColor = System.Drawing.Color.DarkGreen;
            IzvuciKuglicuButton.Text = "Izvuci kuglicu!";            
            
            // Disable NovoIzvlacenjeButton, promijeni izgled gumba
            NovoIzvlacenjeButton.Enabled = false;
            NovoIzvlacenjeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            NovoIzvlacenjeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            NovoIzvlacenjeButton.Text = "";

        }

    }
}


