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
    public partial class IniciarPartida : Form
    {
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

        }
    }
}
