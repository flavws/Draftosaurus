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
            IniciarPartida criarPartida = new IniciarPartida();
            criarPartida.ShowDialog();

        }

        private void pnlRegistro_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void btnSalvarRegistro_Click(object sender, EventArgs e)
        {
            string nomePartida = txtNomePartida.Text;
            string senha = textBox3.Text;
            string nomeJogador = txtNomeGrupo.Text;
            string partida = Jogo.CriarPartida(nomePartida, senha, nomeJogador);
            MessageBox.Show("Partida criada!", "Bem-vindo(a)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lstPartidas.SelectedItem == null) return;

            
            string linhaSelecionada = lstPartidas.SelectedItem.ToString();

            
            string[] partes = linhaSelecionada.Split('|');
            int idPartida = Convert.ToInt32(partes[0].Trim());

            
            ListarJogadores(idPartida);
        }
        private void ListarJogadores(int idPartida)
        {
            
            string retorno = Jogo.ListarJogadores(idPartida);

            
            if (string.IsNullOrEmpty(retorno) || retorno.StartsWith("ERRO"))
            {
                MessageBox.Show("Não foi possível listar os jogadores ou a partida está vazia.");
                return;
            }

            
            retorno = retorno.Replace("\r", "").Trim();
            string[] linhas = retorno.Split('\n');

          
            string listaFormatada = "Jogadores na partida " + idPartida + ":\n";

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(',');
                if (dados.Length >= 2)
                {
                    string idJogador = dados[0];
                    string nomeJogador = dados[1];
                    listaFormatada += $"- {nomeJogador} (ID: {idJogador})\n";
                }
            }

            MessageBox.Show(listaFormatada, "Lista de Jogadores");
        }

    }


}
