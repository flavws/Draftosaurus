using Draft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Draft;

namespace Draftosaurus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblVersao.Text = Jogo.versao;
        }

        private void btnCarregarJogo_Click(object sender, EventArgs e)
        {
            lstPartidas.Visible = true;
            pnlRegistro.Visible = false;

            string retorno = Jogo.ListarPartidas("T");

            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');

            lstPartidas.Items.Clear();
            for (int i = 0; i < partidas.Length; i++)
            {
                string[] detalhesPartida = partidas[i].Split(',');

                if (detalhesPartida.Length > 1)
                {
                    string id = detalhesPartida[0];
                    string nome = detalhesPartida[1];

                    lstPartidas.Items.Add(id + " | " + nome);
                }
            }
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            lstPartidas.Visible = false;
            pnlRegistro.Visible = true;
        }

        private void pnlRegistro_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void btnSalvarRegistro_Click(object sender, EventArgs e)
        {
            string nomePartida = txtNomePartida.Text;
            string senha = txtSenha.Text;
            string nomeGrupo = txtNomeGrupo.Text;
            string partida = Jogo.CriarPartida(nomePartida, senha, nomeGrupo);
            MessageBox.Show("Partida criada!", "Bem-vindo(a)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
