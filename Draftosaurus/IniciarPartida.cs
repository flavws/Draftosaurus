using Draft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draftosaurus
{
    public partial class IniciarPartida : Form
    {

        public string Versao { get; set; }
        public string Resultado { get; set; }

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
    }
}
