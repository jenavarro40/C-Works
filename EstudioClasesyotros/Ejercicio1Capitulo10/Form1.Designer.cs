namespace Ejercicio1Capitulo10
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
            this.MenuOpciones = new System.Windows.Forms.MenuStrip();
            this.MenuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameLabel = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.MenuOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuOpciones
            // 
            this.MenuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuShow,
            this.MenuClear,
            this.MenuHelp});
            this.MenuOpciones.Location = new System.Drawing.Point(0, 0);
            this.MenuOpciones.Name = "MenuOpciones";
            this.MenuOpciones.Size = new System.Drawing.Size(800, 24);
            this.MenuOpciones.TabIndex = 0;
            this.MenuOpciones.Text = "menuStrip1";
            // 
            // MenuShow
            // 
            this.MenuShow.Name = "MenuShow";
            this.MenuShow.Size = new System.Drawing.Size(114, 20);
            this.MenuShow.Text = "Show Information";
            this.MenuShow.Click += new System.EventHandler(this.MenuShow_Click);
            // 
            // MenuClear
            // 
            this.MenuClear.Name = "MenuClear";
            this.MenuClear.Size = new System.Drawing.Size(46, 20);
            this.MenuClear.Text = "Clear";
            this.MenuClear.Click += new System.EventHandler(this.MenuClear_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuHelp.Text = "Help";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(30, 85);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(108, 78);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(331, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(108, 130);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(331, 20);
            this.textBoxEmail.TabIndex = 4;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(30, 137);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(36, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "E-Mail";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(108, 187);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(331, 20);
            this.textBoxAdress.TabIndex = 6;
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(30, 194);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(39, 13);
            this.AdressLabel.TabIndex = 5;
            this.AdressLabel.Text = "Adress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.MenuOpciones);
            this.MainMenuStrip = this.MenuOpciones;
            this.Name = "Form1";
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuOpciones.ResumeLayout(false);
            this.MenuOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuOpciones;
        private System.Windows.Forms.ToolStripMenuItem MenuShow;
        private System.Windows.Forms.ToolStripMenuItem MenuClear;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label AdressLabel;
    }
}

