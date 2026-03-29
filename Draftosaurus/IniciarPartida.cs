using Draft;
using System;
using System.Collections.Generic;
using System.Drawing;
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
    { "TR", new Dinossauro { Nome = "Tricerátops", Cor = null } }
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
                    if (this.Dinossauros.ContainsKey(info[0])){
                        Dinossauro dinossauro = this.Dinossauros[info[0]];
                        lstMao.Items.Add($"{dinossauro.Nome}-{info[1]}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir mao " + ex.Message);
            }
        }
    }
}
