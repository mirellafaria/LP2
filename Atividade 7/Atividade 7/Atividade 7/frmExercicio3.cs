using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_7
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            string frase = txtboxFrase.Text;

            if (frase.Length > 50)
            {
                MessageBox.Show("Digite no máximo 50 caracteres!");
                return;
            }

            foreach (char c in frase)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show("A frase não pode conter números!");
                    return;
                }

                frase = frase.Replace(" ", "");

                frase = frase.ToUpper();

                string invertida = "";

                for (int i = frase.Length - 1; i >= 0; i--)
                {
                    invertida += frase[i];
                }

                if (frase == invertida)
                {
                    txtboxResultado.Text = "É um palíndromo!";
                }
                else
                {
                    txtboxResultado.Text = "Não é um palíndromo.";
                }
            }
        }

        private void txtboxFrase_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtboxFrase.Clear();
            txtboxResultado.Clear();

            txtboxFrase.Focus();
        }
    }
}
