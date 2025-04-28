using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_7
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void rchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void btnEspaceWht_Click(object sender, EventArgs e)
        {
            if (rchTextBox.Text.Length > 100)
            {
                MessageBox.Show("Digite no máximo 100 caracteres!");
                return;
            }

            string texto = rchTextBox.Text;
            int cont = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == ' ')
                {
                    cont++;
                }
            }
            MessageBox.Show($"Número de espaços em branco é: {cont}");
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            if (rchTextBox.Text.Length > 100)
            {
                MessageBox.Show("Digite no máximo 100 caracteres!");
                return;
            }

            string texto = rchTextBox.Text.ToLower();
            int cont = 0;
            int i = 0;
            while (i < texto.Length) 
            {
                if (texto[i] == 'r')
                {
                    cont++;
                }
                i++;
            }
            MessageBox.Show($"Número de letras 'R': {cont}");
        }

        private void btnNumPar_Click(object sender, EventArgs e)
        {
            if (rchTextBox.Text.Length > 100)
            {
                MessageBox.Show("Digite no máximo 100 caracteres!");
                return;
            }

            string texto = rchTextBox.Text.ToLower();
            int cont = 0;
            char anterior = '\0';

            foreach (char atual in texto)
            {
                if (atual == anterior && Char.IsLetter(atual))
                {
                    cont++;
                }
                anterior = atual;
            }

            MessageBox.Show($"Número de pares de letras iguais: {cont}");
        }
    }
}