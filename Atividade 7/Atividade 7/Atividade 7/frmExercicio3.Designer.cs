namespace Atividade_7
{
    partial class frmExercicio3
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtboxFrase = new System.Windows.Forms.TextBox();
            this.txtboxResultado = new System.Windows.Forms.TextBox();
            this.btnTeste = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(213, 59);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(325, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Digite a frase para testar se é um palíndromo:";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // txtboxFrase
            // 
            this.txtboxFrase.Location = new System.Drawing.Point(233, 94);
            this.txtboxFrase.Multiline = true;
            this.txtboxFrase.Name = "txtboxFrase";
            this.txtboxFrase.Size = new System.Drawing.Size(282, 59);
            this.txtboxFrase.TabIndex = 1;
            this.txtboxFrase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxFrase_KeyPress);
            // 
            // txtboxResultado
            // 
            this.txtboxResultado.Location = new System.Drawing.Point(233, 296);
            this.txtboxResultado.Multiline = true;
            this.txtboxResultado.Name = "txtboxResultado";
            this.txtboxResultado.ReadOnly = true;
            this.txtboxResultado.Size = new System.Drawing.Size(282, 59);
            this.txtboxResultado.TabIndex = 2;
            // 
            // btnTeste
            // 
            this.btnTeste.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeste.Location = new System.Drawing.Point(454, 188);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(224, 75);
            this.btnTeste.TabIndex = 3;
            this.btnTeste.Text = "Testar";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(87, 188);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(224, 75);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.txtboxResultado);
            this.Controls.Add(this.txtboxFrase);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtboxFrase;
        private System.Windows.Forms.TextBox txtboxResultado;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Button btnLimpar;
    }
}