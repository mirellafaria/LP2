using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Atividade_7
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int N;
            bool sucesso = int.TryParse(txtNumN.Text, out N);

            if (!sucesso || N <= 0)
            {
                MessageBox.Show("Digite um número inteiro maior que 0!");
                return;
            }

            double H = 0.0;

            for (int i = 1; i <= N; i++)
            {
                H += 1.0 / i;
            }

            txtResultado.Text = H.ToString("F4");
        }

        private void txtNumN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumN.Clear();
            txtResultado.Clear();

            txtNumN.Focus();
        }
    }
}
