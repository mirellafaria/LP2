namespace Atividade_7
{
    partial class frmExercicio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblSalBase = new System.Windows.Forms.Label();
            this.lblGrat = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtboxSalBase = new System.Windows.Forms.TextBox();
            this.txtboxProd = new System.Windows.Forms.TextBox();
            this.txtboxMatricula = new System.Windows.Forms.TextBox();
            this.txtboxNome = new System.Windows.Forms.TextBox();
            this.txtboxGrat = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtboxSalBruto = new System.Windows.Forms.TextBox();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(3, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(326, 65);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(70, 18);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(3, 100);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(76, 18);
            this.lblProd.TabIndex = 2;
            this.lblProd.Text = "Produção";
            // 
            // lblSalBase
            // 
            this.lblSalBase.AutoSize = true;
            this.lblSalBase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalBase.Location = new System.Drawing.Point(350, 102);
            this.lblSalBase.Name = "lblSalBase";
            this.lblSalBase.Size = new System.Drawing.Size(99, 18);
            this.lblSalBase.TabIndex = 3;
            this.lblSalBase.Text = "Salário Base";
            // 
            // lblGrat
            // 
            this.lblGrat.AutoSize = true;
            this.lblGrat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrat.Location = new System.Drawing.Point(3, 138);
            this.lblGrat.Name = "lblGrat";
            this.lblGrat.Size = new System.Drawing.Size(93, 18);
            this.lblGrat.TabIndex = 4;
            this.lblGrat.Text = "Gratificação";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(389, 32);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "CALCULADORA DE SALÁRIO";
            // 
            // txtboxSalBase
            // 
            this.txtboxSalBase.Location = new System.Drawing.Point(455, 100);
            this.txtboxSalBase.Name = "txtboxSalBase";
            this.txtboxSalBase.Size = new System.Drawing.Size(253, 20);
            this.txtboxSalBase.TabIndex = 3;
            // 
            // txtboxProd
            // 
            this.txtboxProd.Location = new System.Drawing.Point(88, 98);
            this.txtboxProd.Name = "txtboxProd";
            this.txtboxProd.Size = new System.Drawing.Size(253, 20);
            this.txtboxProd.TabIndex = 2;
            // 
            // txtboxMatricula
            // 
            this.txtboxMatricula.Location = new System.Drawing.Point(412, 63);
            this.txtboxMatricula.Name = "txtboxMatricula";
            this.txtboxMatricula.Size = new System.Drawing.Size(253, 20);
            this.txtboxMatricula.TabIndex = 1;
            // 
            // txtboxNome
            // 
            this.txtboxNome.Location = new System.Drawing.Point(67, 61);
            this.txtboxNome.Name = "txtboxNome";
            this.txtboxNome.Size = new System.Drawing.Size(253, 20);
            this.txtboxNome.TabIndex = 0;
            this.txtboxNome.TextChanged += new System.EventHandler(this.txtboxNome_TextChanged);
            // 
            // txtboxGrat
            // 
            this.txtboxGrat.Location = new System.Drawing.Point(102, 136);
            this.txtboxGrat.Name = "txtboxGrat";
            this.txtboxGrat.Size = new System.Drawing.Size(253, 20);
            this.txtboxGrat.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(102, 214);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(196, 69);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtboxSalBruto
            // 
            this.txtboxSalBruto.Location = new System.Drawing.Point(213, 314);
            this.txtboxSalBruto.Multiline = true;
            this.txtboxSalBruto.Name = "txtboxSalBruto";
            this.txtboxSalBruto.ReadOnly = true;
            this.txtboxSalBruto.Size = new System.Drawing.Size(253, 19);
            this.txtboxSalBruto.TabIndex = 12;
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalBruto.Location = new System.Drawing.Point(99, 313);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(99, 18);
            this.lblSalBruto.TabIndex = 13;
            this.lblSalBruto.Text = "Salário Bruto";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(412, 214);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(196, 69);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.txtboxSalBruto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtboxGrat);
            this.Controls.Add(this.txtboxNome);
            this.Controls.Add(this.txtboxMatricula);
            this.Controls.Add(this.txtboxProd);
            this.Controls.Add(this.txtboxSalBase);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblGrat);
            this.Controls.Add(this.lblSalBase);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblNome);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.Load += new System.EventHandler(this.frmExercicio4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblSalBase;
        private System.Windows.Forms.Label lblGrat;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtboxSalBase;
        private System.Windows.Forms.TextBox txtboxProd;
        private System.Windows.Forms.TextBox txtboxMatricula;
        private System.Windows.Forms.TextBox txtboxNome;
        private System.Windows.Forms.TextBox txtboxGrat;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtboxSalBruto;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Button btnLimpar;
    }
}