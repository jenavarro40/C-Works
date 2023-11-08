namespace estudiodelistbox
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
            this.Escojer = new System.Windows.Forms.ListBox();
            this.Escribirseleccion = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.TextBox();
            this.ingresarnewname = new System.Windows.Forms.TextBox();
            this.ingresar = new System.Windows.Forms.Button();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.textdelcombobox = new System.Windows.Forms.TextBox();
            this.textcombo1 = new System.Windows.Forms.TextBox();
            this.textcombo2 = new System.Windows.Forms.TextBox();
            this.textcombo3 = new System.Windows.Forms.TextBox();
            this.nuevo_nombre_2 = new System.Windows.Forms.Button();
            this.Resultados = new System.Windows.Forms.TabControl();
            this.Resultado1 = new System.Windows.Forms.TabPage();
            this.textBoxResultado1 = new System.Windows.Forms.TextBox();
            this.Resultado2 = new System.Windows.Forms.TabPage();
            this.textBoxResultado2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuprograma = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Insertar = new System.Windows.Forms.ToolStripTextBox();
            this.corregirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carolinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Resultados.SuspendLayout();
            this.Resultado1.SuspendLayout();
            this.Resultado2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Escojer
            // 
            this.Escojer.FormattingEnabled = true;
            this.Escojer.Items.AddRange(new object[] {
            "Angela",
            "Carolina",
            "Sara"});
            this.Escojer.Location = new System.Drawing.Point(318, 69);
            this.Escojer.Name = "Escojer";
            this.Escojer.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Escojer.Size = new System.Drawing.Size(120, 69);
            this.Escojer.Sorted = true;
            this.Escojer.TabIndex = 0;
            this.Escojer.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Escribirseleccion
            // 
            this.Escribirseleccion.AutoSize = true;
            this.Escribirseleccion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Escribirseleccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Escribirseleccion.Location = new System.Drawing.Point(316, 159);
            this.Escribirseleccion.Name = "Escribirseleccion";
            this.Escribirseleccion.Size = new System.Drawing.Size(0, 13);
            this.Escribirseleccion.TabIndex = 1;
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.SystemColors.InfoText;
            this.resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultado.ForeColor = System.Drawing.SystemColors.Info;
            this.resultado.Location = new System.Drawing.Point(285, 214);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(208, 13);
            this.resultado.TabIndex = 2;
            // 
            // ingresarnewname
            // 
            this.ingresarnewname.Location = new System.Drawing.Point(583, 67);
            this.ingresarnewname.Name = "ingresarnewname";
            this.ingresarnewname.Size = new System.Drawing.Size(175, 20);
            this.ingresarnewname.TabIndex = 3;
            // 
            // ingresar
            // 
            this.ingresar.Location = new System.Drawing.Point(585, 105);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(172, 32);
            this.ingresar.TabIndex = 4;
            this.ingresar.Text = "Ingresar Nuevo Nombre";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // combo1
            // 
            this.combo1.FormattingEnabled = true;
            this.combo1.Location = new System.Drawing.Point(94, 83);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(121, 21);
            this.combo1.TabIndex = 5;
            this.combo1.SelectedIndexChanged += new System.EventHandler(this.combo1_SelectedIndexChanged);
            // 
            // textdelcombobox
            // 
            this.textdelcombobox.Location = new System.Drawing.Point(295, 276);
            this.textdelcombobox.Name = "textdelcombobox";
            this.textdelcombobox.Size = new System.Drawing.Size(206, 20);
            this.textdelcombobox.TabIndex = 6;
            // 
            // textcombo1
            // 
            this.textcombo1.Location = new System.Drawing.Point(39, 213);
            this.textcombo1.Name = "textcombo1";
            this.textcombo1.Size = new System.Drawing.Size(175, 20);
            this.textcombo1.TabIndex = 7;
            // 
            // textcombo2
            // 
            this.textcombo2.Location = new System.Drawing.Point(39, 258);
            this.textcombo2.Name = "textcombo2";
            this.textcombo2.Size = new System.Drawing.Size(175, 20);
            this.textcombo2.TabIndex = 8;
            // 
            // textcombo3
            // 
            this.textcombo3.Location = new System.Drawing.Point(39, 306);
            this.textcombo3.Name = "textcombo3";
            this.textcombo3.Size = new System.Drawing.Size(175, 20);
            this.textcombo3.TabIndex = 9;
            // 
            // nuevo_nombre_2
            // 
            this.nuevo_nombre_2.Location = new System.Drawing.Point(604, 169);
            this.nuevo_nombre_2.Name = "nuevo_nombre_2";
            this.nuevo_nombre_2.Size = new System.Drawing.Size(142, 44);
            this.nuevo_nombre_2.TabIndex = 10;
            this.nuevo_nombre_2.Text = "Ingrese nombre combox";
            this.nuevo_nombre_2.UseVisualStyleBackColor = true;
            this.nuevo_nombre_2.Click += new System.EventHandler(this.nuevo_nombre_2_Click);
            // 
            // Resultados
            // 
            this.Resultados.Controls.Add(this.Resultado1);
            this.Resultados.Controls.Add(this.Resultado2);
            this.Resultados.Location = new System.Drawing.Point(583, 226);
            this.Resultados.Name = "Resultados";
            this.Resultados.SelectedIndex = 0;
            this.Resultados.Size = new System.Drawing.Size(200, 100);
            this.Resultados.TabIndex = 11;
            // 
            // Resultado1
            // 
            this.Resultado1.Controls.Add(this.textBoxResultado1);
            this.Resultado1.Location = new System.Drawing.Point(4, 22);
            this.Resultado1.Name = "Resultado1";
            this.Resultado1.Padding = new System.Windows.Forms.Padding(3);
            this.Resultado1.Size = new System.Drawing.Size(192, 74);
            this.Resultado1.TabIndex = 0;
            this.Resultado1.Text = "Resultado1";
            this.Resultado1.UseVisualStyleBackColor = true;
            // 
            // textBoxResultado1
            // 
            this.textBoxResultado1.Location = new System.Drawing.Point(15, 11);
            this.textBoxResultado1.Name = "textBoxResultado1";
            this.textBoxResultado1.Size = new System.Drawing.Size(103, 20);
            this.textBoxResultado1.TabIndex = 0;
            this.textBoxResultado1.TextChanged += new System.EventHandler(this.textBoxResultado1_TextChanged);
            // 
            // Resultado2
            // 
            this.Resultado2.Controls.Add(this.textBoxResultado2);
            this.Resultado2.Location = new System.Drawing.Point(4, 22);
            this.Resultado2.Name = "Resultado2";
            this.Resultado2.Padding = new System.Windows.Forms.Padding(3);
            this.Resultado2.Size = new System.Drawing.Size(192, 74);
            this.Resultado2.TabIndex = 1;
            this.Resultado2.Text = "Resultado2";
            this.Resultado2.UseVisualStyleBackColor = true;
            // 
            // textBoxResultado2
            // 
            this.textBoxResultado2.Location = new System.Drawing.Point(45, 27);
            this.textBoxResultado2.Name = "textBoxResultado2";
            this.textBoxResultado2.Size = new System.Drawing.Size(103, 20);
            this.textBoxResultado2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuprograma,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 13;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuprograma
            // 
            this.menuprograma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.Insertar,
            this.corregirToolStripMenuItem,
            this.mamaToolStripMenuItem,
            this.estudiarToolStripMenuItem});
            this.menuprograma.Name = "menuprograma";
            this.menuprograma.Size = new System.Drawing.Size(50, 20);
            this.menuprograma.Text = "Menu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // Insertar
            // 
            this.Insertar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(100, 23);
            this.Insertar.Text = "Insertar";
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // corregirToolStripMenuItem
            // 
            this.corregirToolStripMenuItem.Name = "corregirToolStripMenuItem";
            this.corregirToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.corregirToolStripMenuItem.Text = "Corregir";
            this.corregirToolStripMenuItem.Click += new System.EventHandler(this.corregirToolStripMenuItem_Click);
            // 
            // mamaToolStripMenuItem
            // 
            this.mamaToolStripMenuItem.Name = "mamaToolStripMenuItem";
            this.mamaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.mamaToolStripMenuItem.Text = "Mama";
            this.mamaToolStripMenuItem.Click += new System.EventHandler(this.mamaToolStripMenuItem_Click);
            // 
            // estudiarToolStripMenuItem
            // 
            this.estudiarToolStripMenuItem.Name = "estudiarToolStripMenuItem";
            this.estudiarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.estudiarToolStripMenuItem.Text = "Estudiar";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.angelaToolStripMenuItem,
            this.saraToolStripMenuItem,
            this.carolinaToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // angelaToolStripMenuItem
            // 
            this.angelaToolStripMenuItem.Name = "angelaToolStripMenuItem";
            this.angelaToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.angelaToolStripMenuItem.Text = "Angela";
            // 
            // saraToolStripMenuItem
            // 
            this.saraToolStripMenuItem.Name = "saraToolStripMenuItem";
            this.saraToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.saraToolStripMenuItem.Text = "Sara";
            // 
            // carolinaToolStripMenuItem
            // 
            this.carolinaToolStripMenuItem.Name = "carolinaToolStripMenuItem";
            this.carolinaToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.carolinaToolStripMenuItem.Text = "Carolina";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultados);
            this.Controls.Add(this.nuevo_nombre_2);
            this.Controls.Add(this.textcombo3);
            this.Controls.Add(this.textcombo2);
            this.Controls.Add(this.textcombo1);
            this.Controls.Add(this.textdelcombobox);
            this.Controls.Add(this.combo1);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.ingresarnewname);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.Escribirseleccion);
            this.Controls.Add(this.Escojer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resultados.ResumeLayout(false);
            this.Resultado1.ResumeLayout(false);
            this.Resultado1.PerformLayout();
            this.Resultado2.ResumeLayout(false);
            this.Resultado2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Escojer;
        private System.Windows.Forms.Label Escribirseleccion;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.TextBox ingresarnewname;
        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.ComboBox combo1;
        private System.Windows.Forms.TextBox textdelcombobox;
        private System.Windows.Forms.TextBox textcombo1;
        private System.Windows.Forms.TextBox textcombo2;
        private System.Windows.Forms.TextBox textcombo3;
        private System.Windows.Forms.Button nuevo_nombre_2;
        private System.Windows.Forms.TabControl Resultados;
        private System.Windows.Forms.TabPage Resultado1;
        private System.Windows.Forms.TabPage Resultado2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuprograma;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox Insertar;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corregirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carolinaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxResultado1;
        private System.Windows.Forms.TextBox textBoxResultado2;
    }
}

