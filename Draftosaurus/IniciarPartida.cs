using Draft;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Draftosaurus
{
    public partial class IniciarPartida : Form
    {
        public string Versao { get; set; }
        public string Resultado { get; set; }
        private Jogador jogador { get; set; }
        private Partida partida { get; set; }

        private readonly Dictionary<string, Dinossauro> Dinossauros = new Dictionary<string, Dinossauro>
        {
            { "BR", new Dinossauro { Nome = "Branquiossauro", Cor = "Roxo" } },
            { "EP", new Dinossauro { Nome = "Epinossauro", Cor = "Laranja" } },
            { "ET", new Dinossauro { Nome = "Estegossauro", Cor = "Azul" } },
            { "PA", new Dinossauro { Nome = "Parasaurolófo", Cor = "Verde" } },
            { "TI", new Dinossauro { Nome = "Tiranossauro", Cor = "Vermelho" } },
            { "TR", new Dinossauro { Nome = "Tricerátops", Cor = "Amarelo" } }
        };

        private readonly Dictionary<string, Cercado> Cercados = new Dictionary<string, Cercado>
        {
            { "CD", new Cercado { Nome = "Campina da Diferença", Descricao = "Só pode conter dinossauros de espécies diferentes. Pontuação: 1 / 3 / 6 / 10 / 15 / 21 respectivamente." } },
            { "FI", new Cercado { Nome = "Floresta da Igualdade", Descricao = "Só pode conter dinossauros da mesma espécie. Pontuação: 2 / 4 / 8 / 12 / 18 / 24 respectivamente." } },
            { "IS", new Cercado { Nome = "Ilha Solitária", Descricao = "Pode ter apenas um dinossauro. 7 pontos caso seja o único desta espécie no zoo." } },
            { "MT", new Cercado { Nome = "Mata Tripla", Descricao = "Pode conter até 3 dinossauros de qualquer espécie. 7 pontos caso tenha exatamente 3." } },
            { "PA", new Cercado { Nome = "Pradaria do Amor", Descricao = "Pode conter todas as espécies. 5 pontos para cada casal da mesma espécie. Múltiplos casais permitidos." } },
            { "RI", new Cercado { Nome = "Rio", Descricao = "Pode conter qualquer quantidade de dinossauros. 1 ponto para cada um." } },
            { "RS", new Cercado { Nome = "Rei da Selva", Descricao = "Pode ter apenas um dinossauro. 7 pontos caso seu zoo tenha igual ou mais desta espécie que qualquer outro zoo." } }
        };

        public IniciarPartida(string versao, Jogador jogador, string res, Partida partida)
        {
            InitializeComponent();
            this.Versao = versao;
            this.jogador = jogador;
            this.Resultado = res;
            this.partida = partida;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void IniciarPartida_Load(object sender, EventArgs e)
        {
            lblVersao.Text = Versao;
            string[] dados = Resultado.Split(',');
            string[] data = this.partida.Verificar();
            if (dados.Length >= 2)
            {
                this.partida.loadJogadores();
                Jogador jogador = this.partida.jogadores[Int32.Parse(dados[0])];
                string[] face = this.partida.facesDados[dados[1]];
                this.partida.face = dados[1];
                lblJogadorAtual.Text = $"Jogador atual:{jogador.nome}";
                lblFaceDado.Text = $"Face do dado:{face[1]}";
                lblTurno.Text = $"Turno: {data[1]}";
            }
        }

        private void btnExibirMao_Click(object sender, EventArgs e)
        {
            lstMao.Items.Clear();
            try
            {
                string[] dinos = this.jogador.ExibirMao();
                foreach (var dino in dinos)
                {
                    string[] info = dino.Split(',');
                    if (this.Dinossauros.ContainsKey(info[0]))
                    {
                        Dinossauro dinossauro = this.Dinossauros[info[0]];
                        lstMao.Items.Add($"{dinossauro.Nome}-{info[1]}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir mão: " + ex.Message);
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (lstMao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um dinossauro da mão.");
                return;
            }
            if (lstCercados.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cercado.");
                return;
            }

            try
            {
                string dinoSelecionado = lstMao.SelectedItem.ToString();
                string idDino = Dinossauros.FirstOrDefault(d =>
                    dinoSelecionado.StartsWith(d.Value.Nome)).Key;

                string cercadoSelecionado = lstCercados.SelectedItem.ToString();
                string idCercado = cercadoSelecionado.Substring(0, 2);

                this.jogador.Jogar(idDino, idCercado);

                MessageBox.Show("Dinossauro adicionado ao cercado com sucesso!");

                btnExibirMao_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao jogar: " + ex.Message);
            }
        } // ← esse } fecha o btnJogar_Click

        private void btnExibirTabuleiro_Click(object sender, EventArgs e)
        {
            lstTabuleiro.Items.Clear();
            try
            {
                string res = Jogo.ExibirTabuleiro(this.jogador.id, this.jogador.senha);
                if (res.StartsWith("ERRO"))
                    throw new Exception(res);

                string[] linhas = res.Trim().Replace("\r", "").ToUpper().Split('\n');
                foreach (var linha in linhas)
                {
                    string[] info = linha.Split(',');
                    string idCercado = info[0];
                    string idDino = info[1];

                    string nomeCercado = Cercados.ContainsKey(idCercado) ? Cercados[idCercado].Nome : idCercado;
                    string nomeDino = Dinossauros.ContainsKey(idDino) ? Dinossauros[idDino].Nome : idDino;

                    lstTabuleiro.Items.Add($"{nomeCercado} → {nomeDino}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir tabuleiro: " + ex.Message);
            }
        }

        private void lstMao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExibirTabuleiro_Click_1(object sender, EventArgs e)
        {

        }
    }
}