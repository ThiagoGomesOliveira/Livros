using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaAluno
{
    public partial class formMatricula : Form
    {
        public formMatricula()
        {
            InitializeComponent();
            lblDataAtual.Text = "Hoje é " + DateTime.Now.ToLongDateString();
        }

        private void formMatricula_Load(object sender, EventArgs e)
        {

        }

        private void txtAnoAniver_Enter(object sender, EventArgs e)
        {
            if (txtAnoNasc.Text.Trim().Length < 4)
            {
                MessageBox.Show("É preciso informar o ANO DE NASCISMENTO COM 4 DIGITOS", "ATENÇÃO!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnoNasc.Focus();
            }
        }

        private void txtAnoAniver_Validating(object sender, CancelEventArgs e)
        {
            //int anoNiver = Convert.ToInt32(txtAnoAniver.Text);
            //int anoNasc = Convert.ToInt32(txtAnoNasc.Text);

            //if (txtAnoAniver.Text != string.Empty && anoNiver <= anoNasc)
            //{
            //    MessageBox.Show("O ano do ultimo aniversario deve ser superior " +
            //        "ao Ano de nascimento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    e.Cancel = true;
            //}
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty ||
                txtAnoNasc.Text == string.Empty 
              )
            {
                MessageBox.Show("Todos Campos Devem estar Preenchidos",
                    "Atençã!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int anoNasc = Convert.ToInt32(txtAnoNasc.Text);
               
                int idade = anoNasc;
                VerificarIdade(idade);

            }
        }

        public void VerificarIdade(int idade)
        {
            if ( idade > 17 )
            {
                txtCategoria.Text = "Adulto";
            }
            else if (idade > 13)
            {
                txtCategoria.Text = "Juvenil B";
            }
            else if (idade > 10 )
            {
                txtCategoria.Text = "Juvenil A";
            }
            else if (idade > 7)
            {
                txtCategoria.Text = "Infantil B";
            }
            else if(idade >= 5)
            {
                txtCategoria.Text = "Infantil A";
            }
            else
            {
                txtCategoria.Text = "Não existe Categoria";
            }
        }
    }
}
    
