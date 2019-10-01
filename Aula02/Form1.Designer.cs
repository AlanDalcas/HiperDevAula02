namespace Aula02
{
    partial class Form1
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
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblNasc = new System.Windows.Forms.Label();
            this.CbxDias = new System.Windows.Forms.ComboBox();
            this.CbxMeses = new System.Windows.Forms.ComboBox();
            this.CbxAnos = new System.Windows.Forms.ComboBox();
            this.LblPeso = new System.Windows.Forms.Label();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.LblAltura = new System.Windows.Forms.Label();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(259, 35);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(327, 20);
            this.TxtNome.TabIndex = 0;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(218, 38);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(41, 13);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Nome: ";
            // 
            // LblNasc
            // 
            this.LblNasc.AutoSize = true;
            this.LblNasc.Location = new System.Drawing.Point(193, 64);
            this.LblNasc.Name = "LblNasc";
            this.LblNasc.Size = new System.Drawing.Size(66, 13);
            this.LblNasc.TabIndex = 2;
            this.LblNasc.Text = "Nascimento:";
            // 
            // CbxDias
            // 
            this.CbxDias.FormattingEnabled = true;
            this.CbxDias.Location = new System.Drawing.Point(259, 61);
            this.CbxDias.Name = "CbxDias";
            this.CbxDias.Size = new System.Drawing.Size(75, 21);
            this.CbxDias.TabIndex = 3;
            // 
            // CbxMeses
            // 
            this.CbxMeses.FormattingEnabled = true;
            this.CbxMeses.Location = new System.Drawing.Point(340, 61);
            this.CbxMeses.Name = "CbxMeses";
            this.CbxMeses.Size = new System.Drawing.Size(76, 21);
            this.CbxMeses.TabIndex = 4;
            // 
            // CbxAnos
            // 
            this.CbxAnos.FormattingEnabled = true;
            this.CbxAnos.Location = new System.Drawing.Point(422, 61);
            this.CbxAnos.Name = "CbxAnos";
            this.CbxAnos.Size = new System.Drawing.Size(158, 21);
            this.CbxAnos.TabIndex = 5;
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.Location = new System.Drawing.Point(218, 92);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(34, 13);
            this.LblPeso.TabIndex = 6;
            this.LblPeso.Text = "Peso:";
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(259, 88);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(75, 20);
            this.TxtPeso.TabIndex = 7;
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Location = new System.Drawing.Point(215, 120);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(37, 13);
            this.LblAltura.TabIndex = 8;
            this.LblAltura.Text = "Altura:";
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(258, 117);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(76, 20);
            this.TxtAltura.TabIndex = 9;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(258, 153);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 10;
            this.BtnCalcular.Text = "Calcular IMC";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.LblPeso);
            this.Controls.Add(this.CbxAnos);
            this.Controls.Add(this.CbxMeses);
            this.Controls.Add(this.CbxDias);
            this.Controls.Add(this.LblNasc);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.TxtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblNasc;
        private System.Windows.Forms.ComboBox CbxDias;
        private System.Windows.Forms.ComboBox CbxMeses;
        private System.Windows.Forms.ComboBox CbxAnos;
        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.Button BtnCalcular;
    }
}

