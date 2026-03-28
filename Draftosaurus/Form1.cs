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

        private string versao;
        private int idJogador;
        private string senhaJogador;
        public Form1()
        {
            InitializeComponent();
            this.versao = Jogo.versao;
            lblVersao.Text = this.versao;
        }

        private void btnCarregarJogo_Click(object sender, EventArgs e)
        {
            lstPartidas.Visible = true;
            pnlRegistro.Visible = false;
            pnlEntrar.Visible = false;

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
            pnlEntrar.Visible = false;
        }

        private void pnlRegistro_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void btnSalvarRegistro_Click(object sender, EventArgs e)
        {
            string nomePartida = txtNomePartida.Text;
            string senha = txtSenha.Text;
            string nomeGrupo = "Naturalistas";
            string partida = Jogo.CriarPartida(nomePartida, senha, nomeGrupo);
            MessageBox.Show("Partida criada!", "Bem-vindo(a)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lstPartidas.SelectedItem == null) return;

            
            string linhaSelecionada = lstPartidas.SelectedItem.ToString();

            
            string[] partes = linhaSelecionada.Split('|');
            int idPartida = Convert.ToInt32(partes[0].Trim());
        }
        

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            lstPartidas.Visible = false;
            pnlRegistro.Visible = false;
            pnlEntrar.Visible = true;

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            int idPartida = Convert.ToInt32(txtIdPartida.Text);
            string senhaPartida = txtSenhaPartida.Text.Trim();
            string nomeJogador = txtNomeJogador.Text;
            string partida = Jogo.Entrar(idPartida, nomeJogador, senhaPartida);

            string[] dados = partida.Split(',');
            if (dados.Length >= 2)
            {
                this.idJogador = Convert.ToInt32(dados[0]);
                this.senhaJogador = dados[1];
                txtIdJogador.Text = dados[0];
                txtSenhaJogador.Text = dados[1];
            }
            else
            {
                MessageBox.Show("Retorno inesperado: " + partida);
            }
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdPartida.Text, out int idPartida))
            {
                MessageBox.Show("Por favor, informe um ID de partida válido.");
                return;
            }

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

            lstJogadores.Items.Clear();

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(',');
                if (dados.Length >= 2)
                {
                    string idJogador = dados[0];
                    string nomeJogador = dados[1];
                    lstJogadores.Items.Add($"- {nomeJogador} (ID: {idJogador})");
                }
            }
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdPartida.Text, out int idPartida) || idPartida == 0)
            {
                MessageBox.Show("Você precisa informar o id da partida.");
                return;
            }

            string retorno = Jogo.ListarJogadores(idPartida);
            if (string.IsNullOrEmpty(retorno) || retorno.StartsWith("ERRO"))
            {
                MessageBox.Show("Não foi possível listar os jogadores ou a partida está vazia.");
                return;
            }

            string resultado = Jogo.Iniciar(idJogador, senhaJogador);
            if (string.IsNullOrEmpty(resultado) || resultado.StartsWith("ERRO"))
            {
                MessageBox.Show("Erro ao iniciar: " + resultado);
                return;
            }

            IniciarPartida criarPartida = new IniciarPartida();
            criarPartida.Versao = this.versao;
            criarPartida.Resultado = resultado;
            criarPartida.ShowDialog();
        }
    }
}
