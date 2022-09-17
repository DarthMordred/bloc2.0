namespace Block_de_notas
{
    partial class BuscadorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.btnBuscSig = new System.Windows.Forms.Button();
            this.btnBuscAnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(30, 22);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(174, 20);
            this.tbBusca.TabIndex = 0;
            this.tbBusca.TextChanged += new System.EventHandler(this.tbBusca_TextChanged);
            // 
            // btnBuscSig
            // 
            this.btnBuscSig.Location = new System.Drawing.Point(221, 21);
            this.btnBuscSig.Name = "btnBuscSig";
            this.btnBuscSig.Size = new System.Drawing.Size(75, 23);
            this.btnBuscSig.TabIndex = 1;
            this.btnBuscSig.Text = "Busc Sig";
            this.btnBuscSig.UseVisualStyleBackColor = true;
            this.btnBuscSig.Click += new System.EventHandler(this.btnBuscSig_Click);
            // 
            // btnBuscAnt
            // 
            this.btnBuscAnt.Location = new System.Drawing.Point(302, 21);
            this.btnBuscAnt.Name = "btnBuscAnt";
            this.btnBuscAnt.Size = new System.Drawing.Size(75, 23);
            this.btnBuscAnt.TabIndex = 2;
            this.btnBuscAnt.Text = "Busc Ant";
            this.btnBuscAnt.UseVisualStyleBackColor = true;
            this.btnBuscAnt.Click += new System.EventHandler(this.btnBuscAnt_Click);
            // 
            // BuscadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 65);
            this.Controls.Add(this.btnBuscAnt);
            this.Controls.Add(this.btnBuscSig);
            this.Controls.Add(this.tbBusca);
            this.MaximizeBox = false;
            this.Name = "BuscadorForm";
            this.Text = "BuscadorForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuscadorForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Button btnBuscSig;
        private System.Windows.Forms.Button btnBuscAnt;
    }
}