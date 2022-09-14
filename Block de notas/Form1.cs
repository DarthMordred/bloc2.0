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
        private bool isOpening=false;   
        private bool msjErrorisClosing=false;
        private string camino="";
        private string textWC="";
        public Form1()
        {
            InitializeComponent();
            ReiniciarCamino();
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
                    RTB1.Text = st;
                    this.textWC = st;

                }
            }
            isOpening = false;
        }
        private bool comprobarCambios()
        {
            if (RTB1.Text != this.textWC)
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
                RTB1.Clear();
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
            GuardarForm1(RTB1.Text);
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo(RTB1.Text);
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
                    RTB1.Text = s;
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
