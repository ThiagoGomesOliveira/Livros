using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GastoEmRestaurante
{
    public partial class formGastoEmRestaurante : Form
    {
        public formGastoEmRestaurante()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double despesa = Convert.ToDouble(txtDespesa.Text);
            double total = despesa * 1.10;
            txtTotal.Text = total.ToString();
            txtDespesa.Text = "";
        }
    }
}
