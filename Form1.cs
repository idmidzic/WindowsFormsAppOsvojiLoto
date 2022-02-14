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

    }
}


