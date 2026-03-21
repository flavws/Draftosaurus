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
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.Label();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.btnSalvarRegistro = new System.Windows.Forms.Button();
            this.pnlNomeGrupoImg = new System.Windows.Forms.Panel();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.btnCarregarJogo = new System.Windows.Forms.Button();
            this.pnlRegistro.SuspendLayout();
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
            this.lstPartidas.Location = new System.Drawing.Point(411, 67);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(315, 364);
            this.lstPartidas.TabIndex = 2;
            this.lstPartidas.Visible = false;
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(138)))), ((int)(((byte)(57)))));
            this.lblVersao.Location = new System.Drawing.Point(841, 472);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(0, 13);
            this.lblVersao.TabIndex = 3;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(18, 54);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(303, 20);
            this.txtNomePartida.TabIndex = 4;
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.Location = new System.Drawing.Point(18, 116);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Size = new System.Drawing.Size(303, 20);
            this.txtNomeGrupo.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(303, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNomePartida.Location = new System.Drawing.Point(15, 34);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(74, 13);
            this.lblNomePartida.TabIndex = 7;
            this.lblNomePartida.Text = "Nome Partida:";
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNomeGrupo.Location = new System.Drawing.Point(15, 100);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(85, 13);
            this.lblNomeGrupo.TabIndex = 8;
            this.lblNomeGrupo.Text = "Nome do Grupo:";
            // 
            // txtSenha
            // 
            this.txtSenha.AutoSize = true;
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha.Location = new System.Drawing.Point(15, 160);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(41, 13);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.Text = "Senha:";
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.BackColor = System.Drawing.Color.Tan;
            this.pnlRegistro.Controls.Add(this.btnSalvarRegistro);
            this.pnlRegistro.Controls.Add(this.txtNomeGrupo);
            this.pnlRegistro.Controls.Add(this.lblNomePartida);
            this.pnlRegistro.Controls.Add(this.lblNomeGrupo);
            this.pnlRegistro.Controls.Add(this.txtNomePartida);
            this.pnlRegistro.Controls.Add(this.textBox3);
            this.pnlRegistro.Controls.Add(this.txtSenha);
            this.pnlRegistro.Location = new System.Drawing.Point(393, 122);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(346, 292);
            this.pnlRegistro.TabIndex = 11;
            this.pnlRegistro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegistro_Paint);
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
            this.btnSalvarRegistro.Location = new System.Drawing.Point(103, 214);
            this.btnSalvarRegistro.Name = "btnSalvarRegistro";
            this.btnSalvarRegistro.Size = new System.Drawing.Size(138, 52);
            this.btnSalvarRegistro.TabIndex = 10;
            this.btnSalvarRegistro.UseVisualStyleBackColor = false;
            this.btnSalvarRegistro.Click += new System.EventHandler(this.btnSalvarRegistro_Click);
            // 
            // pnlNomeGrupoImg
            // 
            this.pnlNomeGrupoImg.BackColor = System.Drawing.Color.Transparent;
            this.pnlNomeGrupoImg.BackgroundImage = global::Draftosaurus.Properties.Resources.fundoNomeGrupo;
            this.pnlNomeGrupoImg.Location = new System.Drawing.Point(46, 23);
            this.pnlNomeGrupoImg.Name = "pnlNomeGrupoImg";
            this.pnlNomeGrupoImg.Size = new System.Drawing.Size(308, 99);
            this.pnlNomeGrupoImg.TabIndex = 12;
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoJogo.BackgroundImage = global::Draftosaurus.Properties.Resources.btnNovo;
            this.btnNovoJogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoJogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoJogo.FlatAppearance.BorderSize = 0;
            this.btnNovoJogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNovoJogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNovoJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoJogo.Location = new System.Drawing.Point(102, 260);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(155, 58);
            this.btnNovoJogo.TabIndex = 1;
            this.btnNovoJogo.UseVisualStyleBackColor = false;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // btnCarregarJogo
            // 
            this.btnCarregarJogo.BackColor = System.Drawing.Color.Transparent;
            this.btnCarregarJogo.BackgroundImage = global::Draftosaurus.Properties.Resources.btnCarregar1;
            this.btnCarregarJogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarregarJogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregarJogo.FlatAppearance.BorderSize = 0;
            this.btnCarregarJogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCarregarJogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCarregarJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarJogo.Location = new System.Drawing.Point(102, 156);
            this.btnCarregarJogo.Name = "btnCarregarJogo";
            this.btnCarregarJogo.Size = new System.Drawing.Size(155, 58);
            this.btnCarregarJogo.TabIndex = 0;
            this.btnCarregarJogo.UseVisualStyleBackColor = false;
            this.btnCarregarJogo.Click += new System.EventHandler(this.btnCarregarJogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(875, 504);
            this.Controls.Add(this.pnlNomeGrupoImg);
            this.Controls.Add(this.pnlRegistro);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.btnCarregarJogo);
            this.Controls.Add(this.lstPartidas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draftosaurus";
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregarJogo;
        private System.Windows.Forms.Button btnNovoJogo;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.Label txtSenha;
        private System.Windows.Forms.Button btnSalvarRegistro;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.Panel pnlNomeGrupoImg;
    }
}

