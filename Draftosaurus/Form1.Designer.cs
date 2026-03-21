namespace Draftosaurus
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
            this.lstPartidas = new System.Windows.Forms.ListBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.pnlEntrar = new System.Windows.Forms.Panel();
            this.gbJogadores = new System.Windows.Forms.GroupBox();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.btnIniciarJogo = new System.Windows.Forms.Button();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.pnlNomeGrupoImg = new System.Windows.Forms.Panel();
            this.btnSalvarRegistro = new System.Windows.Forms.Button();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.btnCarregarJogo = new System.Windows.Forms.Button();
            this.pnlRegistro.SuspendLayout();
            this.pnlEntrar.SuspendLayout();
            this.gbJogadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPartidas
            // 
            this.lstPartidas.BackColor = System.Drawing.Color.Tan;
            this.lstPartidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPartidas.CausesValidation = false;
            this.lstPartidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstPartidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.ItemHeight = 16;
            this.lstPartidas.Location = new System.Drawing.Point(548, 82);
            this.lstPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(420, 448);
            this.lstPartidas.TabIndex = 2;
            this.lstPartidas.Visible = false;
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(138)))), ((int)(((byte)(57)))));
            this.lblVersao.Location = new System.Drawing.Point(1121, 581);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(0, 16);
            this.lblVersao.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSenha.Location = new System.Drawing.Point(20, 155);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 16);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(24, 175);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(412, 22);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(23, 91);
            this.txtNomePartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(413, 22);
            this.txtNomePartida.TabIndex = 4;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNomePartida.Location = new System.Drawing.Point(20, 69);
            this.lblNomePartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(93, 16);
            this.lblNomePartida.TabIndex = 7;
            this.lblNomePartida.Text = "Nome Partida:";
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.BackColor = System.Drawing.Color.Tan;
            this.pnlRegistro.Controls.Add(this.btnSalvarRegistro);
            this.pnlRegistro.Controls.Add(this.lblNomePartida);
            this.pnlRegistro.Controls.Add(this.txtNomePartida);
            this.pnlRegistro.Controls.Add(this.txtSenha);
            this.pnlRegistro.Controls.Add(this.lblSenha);
            this.pnlRegistro.Location = new System.Drawing.Point(532, 147);
            this.pnlRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(479, 362);
            this.pnlRegistro.TabIndex = 11;
            this.pnlRegistro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegistro_Paint);
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(67)))), ((int)(((byte)(52)))));
            this.lblIdPartida.Location = new System.Drawing.Point(69, 108);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(86, 16);
            this.lblIdPartida.TabIndex = 0;
            this.lblIdPartida.Text = "Id da Partida:";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(72, 262);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(207, 22);
            this.txtNomeJogador.TabIndex = 5;
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(70, 127);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(207, 22);
            this.txtIdPartida.TabIndex = 3;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(67)))), ((int)(((byte)(52)))));
            this.lblNomeJogador.Location = new System.Drawing.Point(71, 243);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(120, 16);
            this.lblNomeJogador.TabIndex = 2;
            this.lblNomeJogador.Text = "Nome do Jogador:";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(67)))), ((int)(((byte)(52)))));
            this.lblSenhaPartida.Location = new System.Drawing.Point(69, 176);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(114, 16);
            this.lblSenhaPartida.TabIndex = 16;
            this.lblSenhaPartida.Text = "Senha da Partida:";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(70, 195);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(207, 22);
            this.txtSenhaPartida.TabIndex = 17;
            // 
            // pnlEntrar
            // 
            this.pnlEntrar.BackColor = System.Drawing.Color.Tan;
            this.pnlEntrar.Controls.Add(this.gbJogadores);
            this.pnlEntrar.Controls.Add(this.txtSenhaPartida);
            this.pnlEntrar.Controls.Add(this.lblSenhaPartida);
            this.pnlEntrar.Controls.Add(this.btnEntrar);
            this.pnlEntrar.Controls.Add(this.lblNomeJogador);
            this.pnlEntrar.Controls.Add(this.txtIdPartida);
            this.pnlEntrar.Controls.Add(this.txtNomeJogador);
            this.pnlEntrar.Controls.Add(this.lblIdPartida);
            this.pnlEntrar.Location = new System.Drawing.Point(454, 82);
            this.pnlEntrar.Name = "pnlEntrar";
            this.pnlEntrar.Size = new System.Drawing.Size(701, 484);
            this.pnlEntrar.TabIndex = 16;
            this.pnlEntrar.Visible = false;
            // 
            // gbJogadores
            // 
            this.gbJogadores.Controls.Add(this.btnIniciarJogo);
            this.gbJogadores.Controls.Add(this.lstJogadores);
            this.gbJogadores.Controls.Add(this.btnListarJogadores);
            this.gbJogadores.Controls.Add(this.txtSenhaJogador);
            this.gbJogadores.Controls.Add(this.label1);
            this.gbJogadores.Controls.Add(this.txtIdJogador);
            this.gbJogadores.Controls.Add(this.lblIdJogador);
            this.gbJogadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(67)))), ((int)(((byte)(52)))));
            this.gbJogadores.Location = new System.Drawing.Point(327, 3);
            this.gbJogadores.Name = "gbJogadores";
            this.gbJogadores.Size = new System.Drawing.Size(371, 478);
            this.gbJogadores.TabIndex = 18;
            this.gbJogadores.TabStop = false;
            this.gbJogadores.Text = "Jogar";
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(67)))), ((int)(((byte)(52)))));
            this.lblIdJogador.Location = new System.Drawing.Point(15, 41);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(75, 16);
            this.lblIdJogador.TabIndex = 19;
            this.lblIdJogador.Text = "Id Jogador:";
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(18, 61);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.ReadOnly = true;
            this.txtIdJogador.Size = new System.Drawing.Size(134, 22);
            this.txtIdJogador.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(67)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(194, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Senha:";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(197, 61);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.ReadOnly = true;
            this.txtSenhaJogador.Size = new System.Drawing.Size(134, 22);
            this.txtSenhaJogador.TabIndex = 21;
            // 
            // lstJogadores
            // 
            this.lstJogadores.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 16;
            this.lstJogadores.Location = new System.Drawing.Point(18, 156);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(313, 212);
            this.lstJogadores.TabIndex = 22;
            // 
            // btnIniciarJogo
            // 
            this.btnIniciarJogo.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarJogo.BackgroundImage = global::Draftosaurus.Properties.Resources.btnIniciarJogo;
            this.btnIniciarJogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciarJogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarJogo.FlatAppearance.BorderSize = 0;
            this.btnIniciarJogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIniciarJogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIniciarJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarJogo.Location = new System.Drawing.Point(82, 375);
            this.btnIniciarJogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciarJogo.Name = "btnIniciarJogo";
            this.btnIniciarJogo.Size = new System.Drawing.Size(207, 71);
            this.btnIniciarJogo.TabIndex = 19;
            this.btnIniciarJogo.UseVisualStyleBackColor = false;
            this.btnIniciarJogo.Click += new System.EventHandler(this.btnIniciarJogo_Click);
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.BackColor = System.Drawing.Color.Transparent;
            this.btnListarJogadores.BackgroundImage = global::Draftosaurus.Properties.Resources.btnListarJogadores;
            this.btnListarJogadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListarJogadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarJogadores.FlatAppearance.BorderSize = 0;
            this.btnListarJogadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnListarJogadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnListarJogadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarJogadores.Location = new System.Drawing.Point(118, 105);
            this.btnListarJogadores.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(125, 44);
            this.btnListarJogadores.TabIndex = 19;
            this.btnListarJogadores.UseVisualStyleBackColor = false;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.BackgroundImage = global::Draftosaurus.Properties.Resources.btnEntrar;
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Location = new System.Drawing.Point(70, 313);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(207, 71);
            this.btnEntrar.TabIndex = 15;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrarPartida.BackgroundImage = global::Draftosaurus.Properties.Resources.btnEntrarPartida;
            this.btnEntrarPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntrarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrarPartida.FlatAppearance.BorderSize = 0;
            this.btnEntrarPartida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEntrarPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEntrarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarPartida.Location = new System.Drawing.Point(136, 438);
            this.btnEntrarPartida.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(207, 71);
            this.btnEntrarPartida.TabIndex = 13;
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // pnlNomeGrupoImg
            // 
            this.pnlNomeGrupoImg.BackColor = System.Drawing.Color.Transparent;
            this.pnlNomeGrupoImg.BackgroundImage = global::Draftosaurus.Properties.Resources.fundoNomeGrupo;
            this.pnlNomeGrupoImg.Location = new System.Drawing.Point(88, 29);
            this.pnlNomeGrupoImg.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNomeGrupoImg.Name = "pnlNomeGrupoImg";
            this.pnlNomeGrupoImg.Size = new System.Drawing.Size(304, 122);
            this.pnlNomeGrupoImg.TabIndex = 12;
            // 
            // btnSalvarRegistro
            // 
            this.btnSalvarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarRegistro.BackgroundImage = global::Draftosaurus.Properties.Resources.btnSave;
            this.btnSalvarRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarRegistro.FlatAppearance.BorderSize = 0;
            this.btnSalvarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalvarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalvarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarRegistro.Location = new System.Drawing.Point(128, 248);
            this.btnSalvarRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarRegistro.Name = "btnSalvarRegistro";
            this.btnSalvarRegistro.Size = new System.Drawing.Size(184, 64);
            this.btnSalvarRegistro.TabIndex = 10;
            this.btnSalvarRegistro.UseVisualStyleBackColor = false;
            this.btnSalvarRegistro.Click += new System.EventHandler(this.btnSalvarRegistro_Click);
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoJogo.BackgroundImage = global::Draftosaurus.Properties.Resources.btnCriarPartida;
            this.btnNovoJogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoJogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoJogo.FlatAppearance.BorderSize = 0;
            this.btnNovoJogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNovoJogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNovoJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoJogo.Location = new System.Drawing.Point(136, 320);
            this.btnNovoJogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(207, 71);
            this.btnNovoJogo.TabIndex = 1;
            this.btnNovoJogo.UseVisualStyleBackColor = false;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // btnCarregarJogo
            // 
            this.btnCarregarJogo.BackColor = System.Drawing.Color.Transparent;
            this.btnCarregarJogo.BackgroundImage = global::Draftosaurus.Properties.Resources.btnListarPartidas;
            this.btnCarregarJogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarregarJogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregarJogo.FlatAppearance.BorderSize = 0;
            this.btnCarregarJogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCarregarJogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCarregarJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarJogo.Location = new System.Drawing.Point(136, 192);
            this.btnCarregarJogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarregarJogo.Name = "btnCarregarJogo";
            this.btnCarregarJogo.Size = new System.Drawing.Size(207, 71);
            this.btnCarregarJogo.TabIndex = 0;
            this.btnCarregarJogo.UseVisualStyleBackColor = false;
            this.btnCarregarJogo.Click += new System.EventHandler(this.btnCarregarJogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1167, 620);
            this.Controls.Add(this.pnlEntrar);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.pnlNomeGrupoImg);
            this.Controls.Add(this.pnlRegistro);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.btnCarregarJogo);
            this.Controls.Add(this.lstPartidas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draftosaurus";
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.pnlEntrar.ResumeLayout(false);
            this.pnlEntrar.PerformLayout();
            this.gbJogadores.ResumeLayout(false);
            this.gbJogadores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregarJogo;
        private System.Windows.Forms.Button btnNovoJogo;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Panel pnlNomeGrupoImg;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Button btnSalvarRegistro;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Panel pnlEntrar;
        private System.Windows.Forms.GroupBox gbJogadores;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Button btnIniciarJogo;
    }
}

