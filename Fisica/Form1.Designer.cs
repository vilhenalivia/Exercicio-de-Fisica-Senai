namespace Exercício_1
{
    partial class frmTelaPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEspaco = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblVelocidade = new System.Windows.Forms.Label();
            this.txtEspacoBox = new System.Windows.Forms.TextBox();
            this.txtTempoBox = new System.Windows.Forms.TextBox();
            this.txtVelocidadeBox = new System.Windows.Forms.TextBox();
            this.btnEspaco = new System.Windows.Forms.Button();
            this.btnTempo = new System.Windows.Forms.Button();
            this.btnVelocidade = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(165, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Física";
            // 
            // lblEspaco
            // 
            this.lblEspaco.AutoSize = true;
            this.lblEspaco.Location = new System.Drawing.Point(38, 81);
            this.lblEspaco.Name = "lblEspaco";
            this.lblEspaco.Size = new System.Drawing.Size(46, 13);
            this.lblEspaco.TabIndex = 1;
            this.lblEspaco.Text = "Espaço:";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(38, 114);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(43, 13);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "Tempo:";
            // 
            // lblVelocidade
            // 
            this.lblVelocidade.AutoSize = true;
            this.lblVelocidade.Location = new System.Drawing.Point(38, 148);
            this.lblVelocidade.Name = "lblVelocidade";
            this.lblVelocidade.Size = new System.Drawing.Size(66, 13);
            this.lblVelocidade.TabIndex = 3;
            this.lblVelocidade.Text = "Velocidade: ";
            // 
            // txtEspacoBox
            // 
            this.txtEspacoBox.Location = new System.Drawing.Point(110, 78);
            this.txtEspacoBox.Name = "txtEspacoBox";
            this.txtEspacoBox.Size = new System.Drawing.Size(152, 20);
            this.txtEspacoBox.TabIndex = 4;
            // 
            // txtTempoBox
            // 
            this.txtTempoBox.Location = new System.Drawing.Point(110, 111);
            this.txtTempoBox.Name = "txtTempoBox";
            this.txtTempoBox.Size = new System.Drawing.Size(152, 20);
            this.txtTempoBox.TabIndex = 5;
            // 
            // txtVelocidadeBox
            // 
            this.txtVelocidadeBox.Location = new System.Drawing.Point(110, 145);
            this.txtVelocidadeBox.Name = "txtVelocidadeBox";
            this.txtVelocidadeBox.Size = new System.Drawing.Size(152, 20);
            this.txtVelocidadeBox.TabIndex = 6;
            // 
            // btnEspaco
            // 
            this.btnEspaco.Location = new System.Drawing.Point(28, 195);
            this.btnEspaco.Name = "btnEspaco";
            this.btnEspaco.Size = new System.Drawing.Size(102, 32);
            this.btnEspaco.TabIndex = 7;
            this.btnEspaco.Text = "Espaço";
            this.btnEspaco.UseVisualStyleBackColor = true;
            this.btnEspaco.Click += new System.EventHandler(this.btnEspaco_Click);
            // 
            // btnTempo
            // 
            this.btnTempo.Location = new System.Drawing.Point(136, 195);
            this.btnTempo.Name = "btnTempo";
            this.btnTempo.Size = new System.Drawing.Size(102, 32);
            this.btnTempo.TabIndex = 8;
            this.btnTempo.Text = "Tempo ";
            this.btnTempo.UseVisualStyleBackColor = true;
            this.btnTempo.Click += new System.EventHandler(this.btnTempo_Click);
            // 
            // btnVelocidade
            // 
            this.btnVelocidade.Location = new System.Drawing.Point(244, 195);
            this.btnVelocidade.Name = "btnVelocidade";
            this.btnVelocidade.Size = new System.Drawing.Size(102, 32);
            this.btnVelocidade.TabIndex = 9;
            this.btnVelocidade.Text = "Velocidade";
            this.btnVelocidade.UseVisualStyleBackColor = true;
            this.btnVelocidade.Click += new System.EventHandler(this.btnVelocidade_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(134, 252);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(35, 13);
            this.lblResposta.TabIndex = 10;
            this.lblResposta.Text = "label1";
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 280);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnVelocidade);
            this.Controls.Add(this.btnTempo);
            this.Controls.Add(this.btnEspaco);
            this.Controls.Add(this.txtVelocidadeBox);
            this.Controls.Add(this.txtTempoBox);
            this.Controls.Add(this.txtEspacoBox);
            this.Controls.Add(this.lblVelocidade);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblEspaco);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmTelaPrincipal";
            this.Text = "Física";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEspaco;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblVelocidade;
        private System.Windows.Forms.TextBox txtEspacoBox;
        private System.Windows.Forms.TextBox txtTempoBox;
        private System.Windows.Forms.TextBox txtVelocidadeBox;
        private System.Windows.Forms.Button btnEspaco;
        private System.Windows.Forms.Button btnTempo;
        private System.Windows.Forms.Button btnVelocidade;
        private System.Windows.Forms.Label lblResposta;
    }
}

