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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmExercicio4_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtboxNome.Text;
            string matricula = txtboxMatricula.Text;
            int producao;
            double salarioBase, gratificacao;

            if (!int.TryParse(txtboxProd.Text, out producao) ||
                !double.TryParse(txtboxSalBase.Text, out salarioBase) ||
                !double.TryParse(txtboxGrat.Text, out gratificacao))
            {
                MessageBox.Show("Verifique os campos: Produção, Salário e Gratificação devem ser números válidos.");
                return;
            }

            int B = (producao >= 100) ? 1 : 0;
            int C = (producao >= 120) ? 1 : 0;
            int D = (producao >= 150) ? 1 : 0;

            double salarioBruto = salarioBase + salarioBase * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacao;

            if (salarioBruto > 7000)
            {
                if (!(producao >= 150 && gratificacao > 0))
                {
                    salarioBruto = 7000.00;
                }
            }
            txtboxSalBruto.Text = salarioBruto.ToString("C2");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtboxNome.Clear();
            txtboxMatricula.Clear();
            txtboxProd.Clear();
            txtboxSalBase.Clear();
            txtboxGrat.Clear();
            txtboxSalBruto.Clear();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void txtboxNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
