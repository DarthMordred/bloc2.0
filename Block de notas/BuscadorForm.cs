using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Block_de_notas
{
    public partial class BuscadorForm : Form
    {
        private string txt_aBuscar;
        private Form1 bloc;

        public BuscadorForm()
        {
            InitializeComponent();
            initBuscador();
        }
        public BuscadorForm(Form1 f1, string wordMemory)
        {
            InitializeComponent();
            initBuscador();
            tbBusca.Text = wordMemory;
            bloc = f1;
        }

        private void initBuscador()
        {
            btnBuscAnt.Enabled = false;
            btnBuscSig.Enabled = false;
        }

        private void BuscadorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            bloc.setMemBuscador(tbBusca.Text);
            Program.buscCloseWindow();
        }

        private void tbBusca_TextChanged(object sender, EventArgs e)
        {
            btnBuscSig.Enabled = tbBusca.Text.Length > 0;
            btnBuscAnt.Enabled = tbBusca.Text.Length > 0;
        }

        private void btnBuscSig_Click(object sender, EventArgs e)
        {
            txt_aBuscar = tbBusca.Text.ToLower();
            bloc.buscaAdelante(txt_aBuscar);
        }

        private void btnBuscAnt_Click(object sender, EventArgs e)
        {
            txt_aBuscar = tbBusca.Text.ToLower();
            bloc.buscaAtras(txt_aBuscar);
        }
    }
}
