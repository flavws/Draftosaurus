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
