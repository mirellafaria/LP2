namespace Atividade_7
{
    partial class frmExercicio1
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
            this.rchTextBox = new System.Windows.Forms.RichTextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnEspaceWht = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnNumPar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTextBox
            // 
            this.rchTextBox.Location = new System.Drawing.Point(110, 83);
            this.rchTextBox.Name = "rchTextBox";
            this.rchTextBox.Size = new System.Drawing.Size(547, 121);
            this.rchTextBox.TabIndex = 0;
            this.rchTextBox.Text = "";
            this.rchTextBox.TextChanged += new System.EventHandler(this.rchTextBox_TextChanged);
            this.rchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rchTextBox_KeyPress);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(245, 44);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(284, 18);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Digite uma frase de até 100 caracteres:";
            // 
            // btnEspaceWht
            // 
            this.btnEspaceWht.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspaceWht.Location = new System.Drawing.Point(110, 246);
            this.btnEspaceWht.Name = "btnEspaceWht";
            this.btnEspaceWht.Size = new System.Drawing.Size(144, 78);
            this.btnEspaceWht.TabIndex = 2;
            this.btnEspaceWht.Text = "Número de espaços em brancos na frase";
            this.btnEspaceWht.UseVisualStyleBackColor = true;
            this.btnEspaceWht.Click += new System.EventHandler(this.btnEspaceWht_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetraR.Location = new System.Drawing.Point(312, 246);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(144, 78);
            this.btnLetraR.TabIndex = 3;
            this.btnLetraR.Text = "Número de vezes que aparece a letra \"R\"";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetraR_Click);
            // 
            // btnNumPar
            // 
            this.btnNumPar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumPar.Location = new System.Drawing.Point(513, 246);
            this.btnNumPar.Name = "btnNumPar";
            this.btnNumPar.Size = new System.Drawing.Size(144, 78);
            this.btnNumPar.TabIndex = 4;
            this.btnNumPar.Text = "Número de pares de letra";
            this.btnNumPar.UseVisualStyleBackColor = true;
            this.btnNumPar.Click += new System.EventHandler(this.btnNumPar_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNumPar);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnEspaceWht);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.rchTextBox);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTextBox;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnEspaceWht;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnNumPar;
    }
}