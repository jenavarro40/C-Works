namespace Ejercicio3Capitulo10
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
            this.SkiescheckBox = new System.Windows.Forms.CheckBox();
            this.GooglescheckBox = new System.Windows.Forms.CheckBox();
            this.GloovescheckBox = new System.Windows.Forms.CheckBox();
            this.earmuffscheckBox = new System.Windows.Forms.CheckBox();
            this.ClothescheckBox1 = new System.Windows.Forms.CheckBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Valuebutton = new System.Windows.Forms.Button();
            this.ValuetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SkiescheckBox
            // 
            this.SkiescheckBox.AutoSize = true;
            this.SkiescheckBox.Location = new System.Drawing.Point(22, 55);
            this.SkiescheckBox.Name = "SkiescheckBox";
            this.SkiescheckBox.Size = new System.Drawing.Size(52, 17);
            this.SkiescheckBox.TabIndex = 0;
            this.SkiescheckBox.Text = "Skies";
            this.SkiescheckBox.UseVisualStyleBackColor = true;
            // 
            // GooglescheckBox
            // 
            this.GooglescheckBox.AutoSize = true;
            this.GooglescheckBox.Location = new System.Drawing.Point(22, 96);
            this.GooglescheckBox.Name = "GooglescheckBox";
            this.GooglescheckBox.Size = new System.Drawing.Size(65, 17);
            this.GooglescheckBox.TabIndex = 1;
            this.GooglescheckBox.Text = "Googles";
            this.GooglescheckBox.UseVisualStyleBackColor = true;
            // 
            // GloovescheckBox
            // 
            this.GloovescheckBox.AutoSize = true;
            this.GloovescheckBox.Location = new System.Drawing.Point(22, 137);
            this.GloovescheckBox.Name = "GloovescheckBox";
            this.GloovescheckBox.Size = new System.Drawing.Size(89, 17);
            this.GloovescheckBox.TabIndex = 2;
            this.GloovescheckBox.Text = "Snow Gloves";
            this.GloovescheckBox.UseVisualStyleBackColor = true;
            // 
            // earmuffscheckBox
            // 
            this.earmuffscheckBox.AutoSize = true;
            this.earmuffscheckBox.Location = new System.Drawing.Point(22, 178);
            this.earmuffscheckBox.Name = "earmuffscheckBox";
            this.earmuffscheckBox.Size = new System.Drawing.Size(67, 17);
            this.earmuffscheckBox.TabIndex = 3;
            this.earmuffscheckBox.Text = "Earmuffs";
            this.earmuffscheckBox.UseVisualStyleBackColor = true;
            // 
            // ClothescheckBox1
            // 
            this.ClothescheckBox1.AutoSize = true;
            this.ClothescheckBox1.Location = new System.Drawing.Point(22, 219);
            this.ClothescheckBox1.Name = "ClothescheckBox1";
            this.ClothescheckBox1.Size = new System.Drawing.Size(61, 17);
            this.ClothescheckBox1.TabIndex = 4;
            this.ClothescheckBox1.Text = "Clothes";
            this.ClothescheckBox1.UseVisualStyleBackColor = true;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(68, 265);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(308, 20);
            this.NametextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // Valuebutton
            // 
            this.Valuebutton.Location = new System.Drawing.Point(504, 261);
            this.Valuebutton.Name = "Valuebutton";
            this.Valuebutton.Size = new System.Drawing.Size(75, 23);
            this.Valuebutton.TabIndex = 7;
            this.Valuebutton.Text = "Value Total";
            this.Valuebutton.UseVisualStyleBackColor = true;
            this.Valuebutton.Click += new System.EventHandler(this.Valuebutton_Click);
            // 
            // ValuetextBox
            // 
            this.ValuetextBox.Location = new System.Drawing.Point(68, 322);
            this.ValuetextBox.Name = "ValuetextBox";
            this.ValuetextBox.Size = new System.Drawing.Size(100, 20);
            this.ValuetextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Value:";
            // 
            // Sendbutton
            // 
            this.Sendbutton.Location = new System.Drawing.Point(504, 319);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(75, 23);
            this.Sendbutton.TabIndex = 10;
            this.Sendbutton.Text = "Send";
            this.Sendbutton.UseVisualStyleBackColor = true;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sendbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ValuetextBox);
            this.Controls.Add(this.Valuebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.ClothescheckBox1);
            this.Controls.Add(this.earmuffscheckBox);
            this.Controls.Add(this.GloovescheckBox);
            this.Controls.Add(this.GooglescheckBox);
            this.Controls.Add(this.SkiescheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SkiescheckBox;
        private System.Windows.Forms.CheckBox GooglescheckBox;
        private System.Windows.Forms.CheckBox GloovescheckBox;
        private System.Windows.Forms.CheckBox earmuffscheckBox;
        private System.Windows.Forms.CheckBox ClothescheckBox1;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Valuebutton;
        private System.Windows.Forms.TextBox ValuetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Sendbutton;
    }
}

