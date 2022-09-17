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
    public partial class MensajeError : Form
    {
        Form1 f = null;
        public MensajeError()
        {
            InitializeComponent();
        }
        public MensajeError(Form1 f) {
        this.f=f;
            InitializeComponent();

            //MessageBox.Show("CIERRAME HDTPM");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.btnGuardarMensajeError(f.tbBlocText.Text);
           
            
            Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.nuevoArch();  
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void MensajeError_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.msjErrorCierra();
        }
    }
}
