using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculaJurosDeMontante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vlrParcela = Convert.ToDouble(valorParcela.Text);
            double txDeJuros = Convert.ToDouble(taxaDeJuros.Text);
            double tempoAtraso = Convert.ToDouble(diasDeAtraso.Text);

            double juros = vlrParcela * (txDeJuros * tempoAtraso);

            jurosFinal.Text = $"{juros}";
        }
    }
}
