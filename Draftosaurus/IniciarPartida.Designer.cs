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
            this.btnExibirMao = new System.Windows.Forms.Button();
            this.lstDinos = new System.Windows.Forms.ListBox();
            this.lblEspeciesDinos = new System.Windows.Forms.Label();
            this.lstMao = new System.Windows.Forms.ListBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lstCercados = new System.Windows.Forms.ListBox();
            this.lblCercados = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lstTabuleiro = new System.Windows.Forms.ListBox();
            this.btnExibirTabuleiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(915, 543);
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
            this.lblVersao.Location = new System.Drawing.Point(950, 569);
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
            this.lblFaceDado.Location = new System.Drawing.Point(356, 61);
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
            this.btnIniciarJogo.Size = new System.Drawing.Size(134, 23);
            this.btnIniciarJogo.TabIndex = 19;
            this.btnIniciarJogo.Text = "Iniciar Jogo";
            this.btnIniciarJogo.UseVisualStyleBackColor = true;
            // 
            // btnExibirMao
            // 
            this.btnExibirMao.Location = new System.Drawing.Point(22, 159);
            this.btnExibirMao.Name = "btnExibirMao";
            this.btnExibirMao.Size = new System.Drawing.Size(134, 23);
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
            this.lstDinos.Location = new System.Drawing.Point(665, 471);
            this.lstDinos.Name = "lstDinos";
            this.lstDinos.Size = new System.Drawing.Size(197, 108);
            this.lstDinos.TabIndex = 22;
            this.lstDinos.Tag = "";
            // 
            // lblEspeciesDinos
            // 
            this.lblEspeciesDinos.AutoSize = true;
            this.lblEspeciesDinos.Location = new System.Drawing.Point(662, 455);
            this.lblEspeciesDinos.Name = "lblEspeciesDinos";
            this.lblEspeciesDinos.Size = new System.Drawing.Size(126, 13);
            this.lblEspeciesDinos.TabIndex = 23;
            this.lblEspeciesDinos.Text = "Espécies de Dinossauros";
            // 
            // lstMao
            // 
            this.lstMao.FormattingEnabled = true;
            this.lstMao.Location = new System.Drawing.Point(22, 201);
            this.lstMao.Name = "lstMao";
            this.lstMao.Size = new System.Drawing.Size(155, 95);
            this.lstMao.TabIndex = 25;
            this.lstMao.SelectedIndexChanged += new System.EventHandler(this.lstMao_SelectedIndexChanged);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(356, 98);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 26;
            this.lblTurno.Text = "label1";
            // 
            // lstCercados
            // 
            this.lstCercados.FormattingEnabled = true;
            this.lstCercados.Items.AddRange(new object[] {
            "CD. Campina da Diferença = Só pode conter dinossauros de espécies diferentes. Pon" +
                "tuação: 1 / 3 / 6 / 10 / 15 / 21 respectivamente.",
            "FI. Floresta da Igualdade = Só pode conter dinossauros da mesma espécie. Pontuaçã" +
                "o: 2 / 4 / 8 / 12 / 18 / 24 respectivamente.",
            "IS. Ilha Solitária = Pode ter apenas um dinossauro. 7 pontos caso seja o único de" +
                "sta espécie no zoo.",
            "MA. Mata Tripla = Pode conter até 3 dinossauros de qualquer espécie. 7 pontos cas" +
                "o tenha exatamente 3.",
            "PA. Pradaria do Amor = Pode conter todas as espécies. 5 pontos para cada casal da" +
                " mesma espécie. Múltiplos casais permitidos.",
            "RI. Rio = Pode conter qualquer quantidade de dinossauros. 1 ponto para cada um.",
            "RS. Rei da Selva  = Pode ter apenas um dinossauro. 7 pontos caso seu zoo tenha ig" +
                "ual ou mais desta espécie que qualquer outro zoo."});
            this.lstCercados.Location = new System.Drawing.Point(12, 471);
            this.lstCercados.Name = "lstCercados";
            this.lstCercados.Size = new System.Drawing.Size(647, 108);
            this.lstCercados.TabIndex = 27;
            // 
            // lblCercados
            // 
            this.lblCercados.AutoSize = true;
            this.lblCercados.Location = new System.Drawing.Point(12, 455);
            this.lblCercados.Name = "lblCercados";
            this.lblCercados.Size = new System.Drawing.Size(92, 13);
            this.lblCercados.TabIndex = 28;
            this.lblCercados.Text = "Lista de Cercados";
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(171, 130);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(131, 23);
            this.btnJogar.TabIndex = 29;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lstTabuleiro
            // 
            this.lstTabuleiro.FormattingEnabled = true;
            this.lstTabuleiro.Location = new System.Drawing.Point(200, 201);
            this.lstTabuleiro.Name = "lstTabuleiro";
            this.lstTabuleiro.Size = new System.Drawing.Size(254, 95);
            this.lstTabuleiro.TabIndex = 30;
            // 
            // btnExibirTabuleiro
            // 
            this.btnExibirTabuleiro.Location = new System.Drawing.Point(171, 159);
            this.btnExibirTabuleiro.Name = "btnExibirTabuleiro";
            this.btnExibirTabuleiro.Size = new System.Drawing.Size(131, 23);
            this.btnExibirTabuleiro.TabIndex = 31;
            this.btnExibirTabuleiro.Text = "Exibir Tabuleiro";
            this.btnExibirTabuleiro.UseVisualStyleBackColor = true;
            this.btnExibirTabuleiro.Click += new System.EventHandler(this.btnExibirTabuleiro_Click);
            // 
            // IniciarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1001, 591);
            this.Controls.Add(this.btnExibirTabuleiro);
            this.Controls.Add(this.lstTabuleiro);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblCercados);
            this.Controls.Add(this.lstCercados);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lstMao);
            this.Controls.Add(this.lblEspeciesDinos);
            this.Controls.Add(this.lstDinos);
            this.Controls.Add(this.btnExibirMao);
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
        private System.Windows.Forms.Button btnExibirMao;
        private System.Windows.Forms.ListBox lstDinos;
        private System.Windows.Forms.Label lblEspeciesDinos;
        private System.Windows.Forms.ListBox lstMao;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ListBox lstCercados;
        private System.Windows.Forms.Label lblCercados;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.ListBox lstTabuleiro;
        private System.Windows.Forms.Button btnExibirTabuleiro;
    }
}