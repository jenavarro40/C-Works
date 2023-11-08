namespace EstudioExamen
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
            this.datalistBox = new System.Windows.Forms.ListBox();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DowntextBox = new System.Windows.Forms.TextBox();
            this.LoancomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PalceOrderbutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.valuelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datalistBox
            // 
            this.datalistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalistBox.FormattingEnabled = true;
            this.datalistBox.ItemHeight = 15;
            this.datalistBox.Location = new System.Drawing.Point(13, 89);
            this.datalistBox.Name = "datalistBox";
            this.datalistBox.Size = new System.Drawing.Size(763, 184);
            this.datalistBox.TabIndex = 0;
            this.datalistBox.SelectedIndexChanged += new System.EventHandler(this.datalistBox_SelectedIndexChanged);
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculatebutton.Location = new System.Drawing.Point(243, 320);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(142, 39);
            this.Calculatebutton.TabIndex = 1;
            this.Calculatebutton.Text = "Calculate";
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EstudioExamen.Properties.Resources.piano_1_;
            this.pictureBox1.Location = new System.Drawing.Point(47, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DowntextBox
            // 
            this.DowntextBox.Location = new System.Drawing.Point(147, 32);
            this.DowntextBox.Name = "DowntextBox";
            this.DowntextBox.Size = new System.Drawing.Size(151, 20);
            this.DowntextBox.TabIndex = 5;
            // 
            // LoancomboBox
            // 
            this.LoancomboBox.FormattingEnabled = true;
            this.LoancomboBox.Items.AddRange(new object[] {
            "12 Months",
            "24 Months"});
            this.LoancomboBox.Location = new System.Drawing.Point(438, 32);
            this.LoancomboBox.Name = "LoancomboBox";
            this.LoancomboBox.Size = new System.Drawing.Size(121, 21);
            this.LoancomboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Down Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Loan Duration";
            // 
            // PalceOrderbutton
            // 
            this.PalceOrderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PalceOrderbutton.Location = new System.Drawing.Point(243, 399);
            this.PalceOrderbutton.Name = "PalceOrderbutton";
            this.PalceOrderbutton.Size = new System.Drawing.Size(142, 39);
            this.PalceOrderbutton.TabIndex = 9;
            this.PalceOrderbutton.Text = "Place Order";
            this.PalceOrderbutton.UseVisualStyleBackColor = true;
            this.PalceOrderbutton.Click += new System.EventHandler(this.PalceOrderbutton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbutton.Location = new System.Drawing.Point(447, 320);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(142, 39);
            this.Clearbutton.TabIndex = 10;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Value";
            // 
            // valuelabel
            // 
            this.valuelabel.AutoSize = true;
            this.valuelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuelabel.Location = new System.Drawing.Point(629, 390);
            this.valuelabel.Name = "valuelabel";
            this.valuelabel.Size = new System.Drawing.Size(19, 20);
            this.valuelabel.TabIndex = 12;
            this.valuelabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valuelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.PalceOrderbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoancomboBox);
            this.Controls.Add(this.DowntextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.datalistBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.load_info);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox datalistBox;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox DowntextBox;
        private System.Windows.Forms.ComboBox LoancomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PalceOrderbutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label valuelabel;
    }
}

