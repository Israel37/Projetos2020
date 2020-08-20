using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoPrazoObra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTime dataAssinatura = DateTime.Parse(txtDataAssinatura.Text);
            DateTime dataTermino    = DateTime.Parse(txtDataTerminoObra.Text);
            
            int PrazoObra = ((dataTermino.Year - dataAssinatura.Year) * 12) + dataTermino.Month - dataAssinatura.Month;
            if (dataTermino.Day < dataAssinatura.Day)
            {
                PrazoObra -= 1;
            }

            txtPrazoObra.Text = PrazoObra.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDataAssinatura.Text = string.Empty;
            txtDataTerminoObra.Text = string.Empty;
            txtPrazoObra.Text = string.Empty;
        }
    }
}
