using Draft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draftosaurus
{
    public partial class IniciarPartida : Form
    {

        public string Versao { get; set; }
        public string Resultado { get; set; }
        private bool partidaIniciada = false;
        public IniciarPartida()
        {
            InitializeComponent();
            //string infos = Jogo.Entrar(1266, "melkson15", "1234");
            //Jogo.Entrar(1266, "melkson13", "1234");
            //if (!infos.StartsWith("ERRO"))
            //{
            //    string[] info = infos.Split(',');

            //    this.listarDinos(Int32.Parse(info[0]), info[1]);
            //}
            
        }
        private void listarDinos(Int32 id, string senha)
        {
            //string iniciar = Jogo.Iniciar(id, senha);

            string res = Jogo.ExibirMao(id, senha);
            if (!res.StartsWith("ERRO"))
            {
                string[] maos = res.Trim().Split('\n');
                int i = 0;
                foreach (string mao in maos)
                {
                    if (i>0)
                    {
                        string[] infos = mao.Replace("\r", "").Split(',');
                        if (infos.Length > 0)
                        {
                            Label dino = new Label();
                            dino.Text = $"tipo: {infos[0]} quantidade: {infos[1]}";
                            dino.Size = new Size(30, 30);
                            dino.Location = new Point(50 * i, 200);
                            dino.BackColor = Color.White;
                            dino.ForeColor = Color.Black;
                            dino.Font = new Font("Arial", 10, FontStyle.Bold);
                            this.Controls.Add(dino);
                        }
                    }
                    i++;


                }
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IniciarPartida_Load(object sender, EventArgs e)
        {
            lblVersao.Text = Versao;
            string[] dados = Resultado.Split(',');
            if (dados.Length >= 2)
            {
                lblJogadorAtual.Text = dados[0];
                lblFaceDado.Text = dados[1];
            }
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            partidaIniciada = true;
        }

        private void btnExibirMao_Click(object sender, EventArgs e)
        {
            if (!partidaIniciada)
            {
                MessageBox.Show("A partida não foi iniciada. Não é possível exibir a mão.");
                return;
            }
            lstMao.Items.Clear();

            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                int indice = rnd.Next(0, lstDinos.Items.Count);
                lstMao.Items.Add(lstDinos.Items[indice]);
            }
        }
            
    
    
    
    
    
    }
}
