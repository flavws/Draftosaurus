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
            this.lblPartidaIniciada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(712, 415);
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
            // lblPartidaIniciada
            // 
            this.lblPartidaIniciada.AutoSize = true;
            this.lblPartidaIniciada.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidaIniciada.Location = new System.Drawing.Point(271, 212);
            this.lblPartidaIniciada.Name = "lblPartidaIniciada";
            this.lblPartidaIniciada.Size = new System.Drawing.Size(265, 39);
            this.lblPartidaIniciada.TabIndex = 15;
            this.lblPartidaIniciada.Text = "Partida Iniciada!";
            // 
            // IniciarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPartidaIniciada);
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
        private System.Windows.Forms.Label lblPartidaIniciada;
    }
}