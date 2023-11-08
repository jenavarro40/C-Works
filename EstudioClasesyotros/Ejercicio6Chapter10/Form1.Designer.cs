namespace Ejercicio6Chapter10
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
            this.ItemlistBox = new System.Windows.Forms.ListBox();
            this.QuantitycomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.ExittextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemlistBox
            // 
            this.ItemlistBox.FormattingEnabled = true;
            this.ItemlistBox.Items.AddRange(new object[] {
            "Full Decorative",
            "Beaded",
            "Pirate Design",
            "Fringed",
            "Leather",
            "Plain",
            ""});
            this.ItemlistBox.Location = new System.Drawing.Point(170, 49);
            this.ItemlistBox.Name = "ItemlistBox";
            this.ItemlistBox.Size = new System.Drawing.Size(120, 95);
            this.ItemlistBox.TabIndex = 0;
            // 
            // QuantitycomboBox
            // 
            this.QuantitycomboBox.FormattingEnabled = true;
            this.QuantitycomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.QuantitycomboBox.Location = new System.Drawing.Point(15, 49);
            this.QuantitycomboBox.Name = "QuantitycomboBox";
            this.QuantitycomboBox.Size = new System.Drawing.Size(121, 21);
            this.QuantitycomboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Styles:";
            // 
            // Sendbutton
            // 
            this.Sendbutton.Location = new System.Drawing.Point(18, 195);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(75, 23);
            this.Sendbutton.TabIndex = 5;
            this.Sendbutton.Text = "Send Order";
            this.Sendbutton.UseVisualStyleBackColor = true;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // ExittextBox
            // 
            this.ExittextBox.AutoSize = true;
            this.ExittextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExittextBox.Location = new System.Drawing.Point(326, 51);
            this.ExittextBox.MinimumSize = new System.Drawing.Size(10, 0);
            this.ExittextBox.Name = "ExittextBox";
            this.ExittextBox.Size = new System.Drawing.Size(33, 13);
            this.ExittextBox.TabIndex = 6;
            this.ExittextBox.Text = "Order";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExittextBox);
            this.Controls.Add(this.Sendbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuantitycomboBox);
            this.Controls.Add(this.ItemlistBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemlistBox;
        private System.Windows.Forms.ComboBox QuantitycomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Sendbutton;
        private System.Windows.Forms.Label ExittextBox;
    }
}

