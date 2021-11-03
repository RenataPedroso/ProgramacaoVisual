namespace EscolhaATV1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.radD = new System.Windows.Forms.RadioButton();
            this.radI = new System.Windows.Forms.RadioButton();
            this.radE = new System.Windows.Forms.RadioButton();
            this.cboOpcoes = new System.Windows.Forms.ComboBox();
            this.picImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // radD
            // 
            this.radD.AutoSize = true;
            this.radD.Location = new System.Drawing.Point(77, 77);
            this.radD.Name = "radD";
            this.radD.Size = new System.Drawing.Size(107, 17);
            this.radD.TabIndex = 0;
            this.radD.TabStop = true;
            this.radD.Text = "Desenvolvimento";
            this.radD.UseVisualStyleBackColor = true;
            this.radD.CheckedChanged += new System.EventHandler(this.radD_CheckedChanged);
            // 
            // radI
            // 
            this.radI.AutoSize = true;
            this.radI.Location = new System.Drawing.Point(77, 115);
            this.radI.Name = "radI";
            this.radI.Size = new System.Drawing.Size(87, 17);
            this.radI.TabIndex = 1;
            this.radI.TabStop = true;
            this.radI.Text = "Infraestrutura";
            this.radI.UseVisualStyleBackColor = true;
            this.radI.CheckedChanged += new System.EventHandler(this.radI_CheckedChanged);
            // 
            // radE
            // 
            this.radE.AutoSize = true;
            this.radE.Location = new System.Drawing.Point(77, 154);
            this.radE.Name = "radE";
            this.radE.Size = new System.Drawing.Size(96, 17);
            this.radE.TabIndex = 2;
            this.radE.TabStop = true;
            this.radE.Text = "Entretenimento";
            this.radE.UseVisualStyleBackColor = true;
            this.radE.CheckedChanged += new System.EventHandler(this.radE_CheckedChanged);
            // 
            // cboOpcoes
            // 
            this.cboOpcoes.FormattingEnabled = true;
            this.cboOpcoes.Location = new System.Drawing.Point(77, 202);
            this.cboOpcoes.Name = "cboOpcoes";
            this.cboOpcoes.Size = new System.Drawing.Size(121, 21);
            this.cboOpcoes.TabIndex = 3;
            this.cboOpcoes.SelectedIndexChanged += new System.EventHandler(this.cboOpcoes_SelectedIndexChanged);
            // 
            // picImg
            // 
            this.picImg.Location = new System.Drawing.Point(249, 39);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(284, 235);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg.TabIndex = 4;
            this.picImg.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picImg);
            this.Controls.Add(this.cboOpcoes);
            this.Controls.Add(this.radE);
            this.Controls.Add(this.radI);
            this.Controls.Add(this.radD);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radD;
        private System.Windows.Forms.RadioButton radI;
        private System.Windows.Forms.RadioButton radE;
        private System.Windows.Forms.ComboBox cboOpcoes;
        private System.Windows.Forms.PictureBox picImg;
    }
}

