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
    public partial class FrmPai : Form
    {
        public FrmPai()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio1>().Count() > 0)
            {
                Application.OpenForms["frmExercicio1"].BringToFront(); // form existe traz ele para a frente
            }
            else
            {
                frmExercicio1 obj1 = new frmExercicio1(); // crio o objeto do novo formulario
                obj1.MdiParent = this;
                obj1.WindowState = FormWindowState.Maximized;
                obj1.Show();
            }
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio2>().Count() > 0)
            {
                Application.OpenForms["frmExercicio2"].BringToFront(); // form existe traz ele para a frente
            }
            else
            {
                frmExercicio2 obj2 = new frmExercicio2(); // crio o objeto do novo formulario
                obj2.MdiParent = this;
                obj2.WindowState = FormWindowState.Maximized;
                obj2.Show();
            }
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio3>().Count() > 0)
            {
                Application.OpenForms["frmExercicio3"].BringToFront(); // form existe traz ele para a frente
            }
            else
            {
                frmExercicio3 obj3 = new frmExercicio3(); // crio o objeto do novo formulario
                obj3.MdiParent = this;
                obj3.WindowState = FormWindowState.Maximized;
                obj3.Show();
            }
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                Application.OpenForms["frmExercicio4"].BringToFront(); // form existe traz ele para a frente
            }
            else
            {
                frmExercicio4 obj4 = new frmExercicio4(); // crio o objeto do novo formulario
                obj4.MdiParent = this;
                obj4.WindowState = FormWindowState.Maximized;
                obj4.Show();
            }
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
