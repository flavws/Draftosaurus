namespace Draftosaurus
{
    partial class IniciarPartida
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pnlNomeGrupoImg = new System.Windows.Forms.Panel();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblJogadorAtual = new System.Windows.Forms.Label();
            this.lblFaceDado = new System.Windows.Forms.Label();
            this.btnIniciarJogo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExibirMao = new System.Windows.Forms.Button();
            this.lstDinos = new System.Windows.Forms.ListBox();
            this.lblEspeciesDinos = new System.Windows.Forms.Label();
            this.lstMao = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(706, 391);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pnlNomeGrupoImg
            // 
            this.pnlNomeGrupoImg.BackColor = System.Drawing.Color.Transparent;
            this.pnlNomeGrupoImg.BackgroundImage = global::Draftosaurus.Properties.Resources.fundoNomeGrupo;
            this.pnlNomeGrupoImg.Location = new System.Drawing.Point(12, 12);
            this.pnlNomeGrupoImg.Name = "pnlNomeGrupoImg";
            this.pnlNomeGrupoImg.Size = new System.Drawing.Size(308, 99);
            this.pnlNomeGrupoImg.TabIndex = 13;
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(748, 430);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(40, 13);
            this.lblVersao.TabIndex = 16;
            this.lblVersao.Text = "Versão";
            // 
            // lblJogadorAtual
            // 
            this.lblJogadorAtual.AutoSize = true;
            this.lblJogadorAtual.Location = new System.Drawing.Point(356, 24);
            this.lblJogadorAtual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJogadorAtual.Name = "lblJogadorAtual";
            this.lblJogadorAtual.Size = new System.Drawing.Size(74, 13);
            this.lblJogadorAtual.TabIndex = 17;
            this.lblJogadorAtual.Text = "ID do Jogador";
            // 
            // lblFaceDado
            // 
            this.lblFaceDado.AutoSize = true;
            this.lblFaceDado.Location = new System.Drawing.Point(448, 24);
            this.lblFaceDado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFaceDado.Name = "lblFaceDado";
            this.lblFaceDado.Size = new System.Drawing.Size(35, 13);
            this.lblFaceDado.TabIndex = 18;
            this.lblFaceDado.Text = "label1";
            // 
            // btnIniciarJogo
            // 
            this.btnIniciarJogo.Location = new System.Drawing.Point(22, 131);
            this.btnIniciarJogo.Name = "btnIniciarJogo";
            this.btnIniciarJogo.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarJogo.TabIndex = 19;
            this.btnIniciarJogo.Text = "Iniciar Jogo";
            this.btnIniciarJogo.UseVisualStyleBackColor = true;
            this.btnIniciarJogo.Click += new System.EventHandler(this.btnIniciarJogo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnExibirMao
            // 
            this.btnExibirMao.Location = new System.Drawing.Point(22, 189);
            this.btnExibirMao.Name = "btnExibirMao";
            this.btnExibirMao.Size = new System.Drawing.Size(75, 23);
            this.btnExibirMao.TabIndex = 21;
            this.btnExibirMao.Text = "Exibir Mão";
            this.btnExibirMao.UseVisualStyleBackColor = true;
            this.btnExibirMao.Click += new System.EventHandler(this.btnExibirMao_Click);
            // 
            // lstDinos
            // 
            this.lstDinos.FormattingEnabled = true;
            this.lstDinos.Items.AddRange(new object[] {
            "BR.Branquiossauro.Roxo",
            "EP.Epinossauro.Laranja",
            "ET.Estegossauro.Azul",
            "PA.Parasaurolófo.Verde",
            "TI.Tiranossauro.Vermelho",
            "TR.Tricerátops"});
            this.lstDinos.Location = new System.Drawing.Point(631, 272);
            this.lstDinos.Name = "lstDinos";
            this.lstDinos.Size = new System.Drawing.Size(157, 95);
            this.lstDinos.TabIndex = 22;
            this.lstDinos.Tag = "";
            // 
            // lblEspeciesDinos
            // 
            this.lblEspeciesDinos.AutoSize = true;
            this.lblEspeciesDinos.Location = new System.Drawing.Point(631, 253);
            this.lblEspeciesDinos.Name = "lblEspeciesDinos";
            this.lblEspeciesDinos.Size = new System.Drawing.Size(126, 13);
            this.lblEspeciesDinos.TabIndex = 23;
            this.lblEspeciesDinos.Text = "Espécies de Dinossauros";
            // 
            // lstMao
            // 
            this.lstMao.FormattingEnabled = true;
            this.lstMao.Location = new System.Drawing.Point(481, 272);
            this.lstMao.Name = "lstMao";
            this.lstMao.Size = new System.Drawing.Size(120, 95);
            this.lstMao.TabIndex = 25;
            // 
            // IniciarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMao);
            this.Controls.Add(this.lblEspeciesDinos);
            this.Controls.Add(this.lstDinos);
            this.Controls.Add(this.btnExibirMao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIniciarJogo);
            this.Controls.Add(this.lblFaceDado);
            this.Controls.Add(this.lblJogadorAtual);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.pnlNomeGrupoImg);
            this.Controls.Add(this.btnVoltar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "IniciarPartida";
            this.Text = "CriarPartida";
            this.Load += new System.EventHandler(this.IniciarPartida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel pnlNomeGrupoImg;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblJogadorAtual;
        private System.Windows.Forms.Label lblFaceDado;
        private System.Windows.Forms.Button btnIniciarJogo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExibirMao;
        private System.Windows.Forms.ListBox lstDinos;
        private System.Windows.Forms.Label lblEspeciesDinos;
        private System.Windows.Forms.ListBox lstMao;
    }
}