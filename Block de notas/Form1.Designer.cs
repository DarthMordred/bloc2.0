namespace Block_de_notas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarSiguienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RTB = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbBlocText = new System.Windows.Forms.TextBox();
            this.Nuevo = new System.Windows.Forms.ToolStripButton();
            this.Abrir = new System.Windows.Forms.ToolStripButton();
            this.Guardar = new System.Windows.Forms.ToolStripButton();
            this.Guardar_Como = new System.Windows.Forms.ToolStripButton();
            this.iconBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.iconBtnBuscarSig = new System.Windows.Forms.ToolStripButton();
            this.iconBtnBuscarAnt = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem1,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem1
            // 
            this.abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.abrirToolStripMenuItem1.Text = "Abrir";
            this.abrirToolStripMenuItem1.Click += new System.EventHandler(this.abrirToolStripMenuItem1_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.buscarSiguienteToolStripMenuItem,
            this.buscarAnteriorToolStripMenuItem});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // buscarSiguienteToolStripMenuItem
            // 
            this.buscarSiguienteToolStripMenuItem.Name = "buscarSiguienteToolStripMenuItem";
            this.buscarSiguienteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.buscarSiguienteToolStripMenuItem.Text = "Buscar siguiente";
            this.buscarSiguienteToolStripMenuItem.Click += new System.EventHandler(this.buscarSiguienteToolStripMenuItem_Click);
            // 
            // buscarAnteriorToolStripMenuItem
            // 
            this.buscarAnteriorToolStripMenuItem.Name = "buscarAnteriorToolStripMenuItem";
            this.buscarAnteriorToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.buscarAnteriorToolStripMenuItem.Text = "Buscar anterior";
            this.buscarAnteriorToolStripMenuItem.Click += new System.EventHandler(this.buscarAnteriorToolStripMenuItem_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nuevo,
            this.Abrir,
            this.Guardar,
            this.Guardar_Como,
            this.iconBtnBuscar,
            this.iconBtnBuscarSig,
            this.iconBtnBuscarAnt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // RTB
            // 
            this.RTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB.Location = new System.Drawing.Point(0, 49);
            this.RTB.Name = "RTB";
            this.RTB.Size = new System.Drawing.Size(800, 401);
            this.RTB.TabIndex = 3;
            this.RTB.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbBlocText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 401);
            this.panel1.TabIndex = 4;
            // 
            // tbBlocText
            // 
            this.tbBlocText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlocText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBlocText.Location = new System.Drawing.Point(0, 0);
            this.tbBlocText.Multiline = true;
            this.tbBlocText.Name = "tbBlocText";
            this.tbBlocText.Size = new System.Drawing.Size(800, 401);
            this.tbBlocText.TabIndex = 0;
            this.tbBlocText.TextChanged += new System.EventHandler(this.tbBlocText_TextChanged);
            // 
            // Nuevo
            // 
            this.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
            this.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(23, 22);
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // Abrir
            // 
            this.Abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Abrir.Image = ((System.Drawing.Image)(resources.GetObject("Abrir.Image")));
            this.Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Abrir.Name = "Abrir";
            this.Abrir.Size = new System.Drawing.Size(23, 22);
            this.Abrir.Text = "Abrir";
            this.Abrir.Click += new System.EventHandler(this.abrirToolStripMenuItem1_Click);
            // 
            // Guardar
            // 
            this.Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(23, 22);
            this.Guardar.Text = "Guardar";
            this.Guardar.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // Guardar_Como
            // 
            this.Guardar_Como.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Guardar_Como.Image = ((System.Drawing.Image)(resources.GetObject("Guardar_Como.Image")));
            this.Guardar_Como.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Guardar_Como.Name = "Guardar_Como";
            this.Guardar_Como.Size = new System.Drawing.Size(23, 22);
            this.Guardar_Como.Text = "Guardar Como";
            this.Guardar_Como.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // iconBtnBuscar
            // 
            this.iconBtnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iconBtnBuscar.Image = global::Block_de_notas.Properties.Resources.buscar;
            this.iconBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconBtnBuscar.Name = "iconBtnBuscar";
            this.iconBtnBuscar.Size = new System.Drawing.Size(23, 22);
            this.iconBtnBuscar.Text = "Buscar";
            this.iconBtnBuscar.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // iconBtnBuscarSig
            // 
            this.iconBtnBuscarSig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iconBtnBuscarSig.Image = global::Block_de_notas.Properties.Resources.buscar_sig;
            this.iconBtnBuscarSig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconBtnBuscarSig.Name = "iconBtnBuscarSig";
            this.iconBtnBuscarSig.Size = new System.Drawing.Size(23, 22);
            this.iconBtnBuscarSig.Text = "Buscar Siguiente";
            this.iconBtnBuscarSig.Click += new System.EventHandler(this.buscarSiguienteToolStripMenuItem_Click);
            // 
            // iconBtnBuscarAnt
            // 
            this.iconBtnBuscarAnt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iconBtnBuscarAnt.Image = global::Block_de_notas.Properties.Resources.buscar_ant;
            this.iconBtnBuscarAnt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconBtnBuscarAnt.Name = "iconBtnBuscarAnt";
            this.iconBtnBuscarAnt.Size = new System.Drawing.Size(23, 22);
            this.iconBtnBuscarAnt.Text = "Buscar Anterior";
            this.iconBtnBuscarAnt.Click += new System.EventHandler(this.buscarAnteriorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RTB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bloc de notas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarSiguienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAnteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton Nuevo;
        private System.Windows.Forms.ToolStripButton Abrir;
        private System.Windows.Forms.ToolStripButton Guardar;
        private System.Windows.Forms.ToolStripButton Guardar_Como;
        private System.Windows.Forms.RichTextBox RTB;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox tbBlocText;
        private System.Windows.Forms.ToolStripButton iconBtnBuscar;
        private System.Windows.Forms.ToolStripButton iconBtnBuscarSig;
        private System.Windows.Forms.ToolStripButton iconBtnBuscarAnt;
    }
}

