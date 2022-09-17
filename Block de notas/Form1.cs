using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Block_de_notas
{
    
    public partial class Form1 : Form
    {

        private bool nuevoCreando = false;
        MensajeError m = null;
        BuscadorForm buscador = null;
        private bool isOpening=false;   
        private bool msjErrorisClosing=false;
        private string camino="";
        private string textWC="";
        private string todoTexto, txtAdelante, txtDetras; //Texto adelante y detrás del cursor.
        private string memBuscador = "";

        public Form1()
        {
            InitializeComponent();
            ReiniciarCamino();
            initBusc();
        }

        private void initBusc()
        {
            buscarToolStripMenuItem.Enabled = false;
            buscarSiguienteToolStripMenuItem.Enabled = false;
            buscarAnteriorToolStripMenuItem.Enabled = false;
        }

        private void tbBlocText_TextChanged(object sender, EventArgs e)
        {
            buscarToolStripMenuItem.Enabled = tbBlocText.Text.Length > 0;
            buscarSiguienteToolStripMenuItem.Enabled = tbBlocText.Text.Length > 0;
            buscarAnteriorToolStripMenuItem.Enabled = tbBlocText.Text.Length > 0;

            todoTexto = tbBlocText.Text;
        }

        public void setMemBuscador(string s)
        {
            memBuscador = s;
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.buscIsClosed())
            {
                buscador = new BuscadorForm(this, memBuscador);
                Program.buscOpenWindow();
                buscador.Show();
            }
            else
            {
                if (buscador.WindowState == FormWindowState.Minimized)
                {
                    buscador.WindowState = FormWindowState.Normal;
                }
                buscador.Focus();
            }
        }

        private void buscarSiguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (memBuscador == "")
            {
                buscarToolStripMenuItem_Click(sender, e);
            }
            else
            {
                buscaAdelante(memBuscador);
            }
        }

        private void buscarAnteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (memBuscador == "")
            {
                buscarToolStripMenuItem_Click(sender, e);
            }
            else
            {
                buscaAtras(memBuscador);
            }
        }

        private void acomodaCursor()
        {
            if (tbBlocText.SelectionLength != 0)
            {
                tbBlocText.SelectionStart += tbBlocText.SelectionLength;
            }
        }

        public void buscaAdelante(string txt_aBusc)
        {
            acomodaCursor();
            txtAdelante = todoTexto.Substring(tbBlocText.SelectionStart).ToLower();
            if (txtAdelante.Contains(txt_aBusc))
            {
                int offset = txtAdelante.IndexOf(txt_aBusc);
                tbBlocText.SelectionStart += offset;
                tbBlocText.SelectionLength = txt_aBusc.Length;
                tbBlocText.HideSelection = false; //Mostramos la selección aunque la ventana no esté enfocada
            }
            else
            {
                tbBlocText.SelectionLength = 0;
                string noEnconMssg = "No se encontró \"" + txt_aBusc + "\"";
                MessageBox.Show(noEnconMssg);
            }
        }

        public void buscaAtras(string txt_aBusc)
        {
            txtDetras = todoTexto.Substring(0, tbBlocText.SelectionStart).ToLower();
            if (txtDetras.Contains(txt_aBusc))
            {
                int offset = txtDetras.LastIndexOf(txt_aBusc);
                tbBlocText.SelectionStart = offset;
                tbBlocText.SelectionLength = txt_aBusc.Length;
                tbBlocText.HideSelection = false; //Mostramos la selección aunque la ventana no esté enfocada
            }
            else
            {
                tbBlocText.SelectionLength = 0;
                string noEnconMssg = "No se encontró \"" + txt_aBusc + "\"";
                MessageBox.Show(noEnconMssg);
            }
        }

        public void msjErrorAbre()
        {
            msjErrorisClosing = true;
        }
        public void msjErrorCierra()
        {
            msjErrorisClosing = false;
        }
        public void GuardarForm1(string s)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (camino == "")
            {

                GuardarComo(s);
            }
            else
            {
                GuardarNormal(s);
            }
        }
        private void GuardarNormal(string s)
        {
            textWC = s;
            File.WriteAllText(camino, s);
        }
        private void GuardarComo(string s)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Archivos de texto|*.txt";

            saveFileDialog.AddExtension = true;

            DialogResult res = saveFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                textWC = s;
                camino = saveFileDialog.FileName;
                File.WriteAllText(saveFileDialog.FileName, s);
            }

        }
        public void btnGuardarMensajeError(string s)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (camino == "")
            {
                saveFileDialog.Filter = "Archivos de texto|*.txt";

                saveFileDialog.AddExtension = true;

                DialogResult res = saveFileDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    camino = saveFileDialog.FileName;
                    File.WriteAllText(saveFileDialog.FileName, s);
                    nuevoArch();
                }

                comprobarAbrir();

            }
            else
            {
                File.WriteAllText(camino, s);
                nuevoArch();
               
                comprobarAbrir();
            }
            if (msjErrorisClosing == true)
            {
                Close();
            }
           
        }
        private void comprobarAbrir()
        {
            if (isOpening == true)
            {
                string st;
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Archivos de texto|*.txt";
                op.AddExtension = true;
                DialogResult res = op.ShowDialog();
                if (res == DialogResult.OK)
                {
                    st = File.ReadAllText(op.FileName);
                    camino = op.FileName;
                    tbBlocText.Text = st;
                    this.textWC = st;

                }
            }
            isOpening = false;
        }
        private bool comprobarCambios()
        {
            if (tbBlocText.Text != this.textWC)
            {
                return (true);
            }
            return (false);
        }
        public void MensajeErrorOpen()
        {
            m = new MensajeError(this);
            if (comprobarCambios())
            {
                m.Show();
                m.Focus();

            }
            else
            {
                nuevoArch();
            }
           
            
        }

      
        
        public void ReiniciarCamino()
        {
            camino = "";
            textWC = "";
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoCreando = true;
            MensajeErrorOpen();
        }
        public void nuevoArch()
        {
                tbBlocText.Clear();
            if (msjErrorisClosing == true)
            {
                Close();
            }
            if(nuevoCreando)
            {
                ReiniciarCamino();
            }
            comprobarAbrir();
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarForm1(tbBlocText.Text);
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo(tbBlocText.Text);
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            if (comprobarCambios())
            {
                m = new MensajeError(this);
                m.Show();
                m.Focus();
                isOpening = true;
            }
            else
            {
                string s;
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Archivos de texto|*.txt";
                op.AddExtension = true;
                DialogResult res = op.ShowDialog();
                if (res == DialogResult.OK)
                {
                    s = File.ReadAllText(op.FileName);
                    camino = op.FileName;
                    tbBlocText.Text = s;
                    this.textWC = s;
                }
     
            }
        }
    
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            m = new MensajeError(this);
            if (comprobarCambios())
            {
                 m.Show();
                 m.Focus();
                msjErrorisClosing = true;
                e.Cancel = true;
                   
            
            }else
            {

            }
            

        }
    }
}
