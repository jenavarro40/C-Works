namespace RectanguleCheck
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
            this.LenghttextBox = new System.Windows.Forms.TextBox();
            this.WidhttextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Perimeterlabel = new System.Windows.Forms.Label();
            this.Arealabel = new System.Windows.Forms.Label();
            this.Diagonallabel = new System.Windows.Forms.Label();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LenghttextBox
            // 
            this.LenghttextBox.Location = new System.Drawing.Point(162, 64);
            this.LenghttextBox.Name = "LenghttextBox";
            this.LenghttextBox.Size = new System.Drawing.Size(169, 20);
            this.LenghttextBox.TabIndex = 0;
            // 
            // WidhttextBox
            // 
            this.WidhttextBox.Location = new System.Drawing.Point(162, 145);
            this.WidhttextBox.Name = "WidhttextBox";
            this.WidhttextBox.Size = new System.Drawing.Size(169, 20);
            this.WidhttextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Widht";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Perimeter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Diagonal";
            // 
            // Perimeterlabel
            // 
            this.Perimeterlabel.AutoSize = true;
            this.Perimeterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perimeterlabel.Location = new System.Drawing.Point(162, 217);
            this.Perimeterlabel.Name = "Perimeterlabel";
            this.Perimeterlabel.Size = new System.Drawing.Size(51, 20);
            this.Perimeterlabel.TabIndex = 8;
            this.Perimeterlabel.Text = "label6";
            this.Perimeterlabel.Visible = false;
            // 
            // Arealabel
            // 
            this.Arealabel.AutoSize = true;
            this.Arealabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arealabel.Location = new System.Drawing.Point(162, 266);
            this.Arealabel.Name = "Arealabel";
            this.Arealabel.Size = new System.Drawing.Size(51, 20);
            this.Arealabel.TabIndex = 9;
            this.Arealabel.Text = "label7";
            this.Arealabel.Visible = false;
            // 
            // Diagonallabel
            // 
            this.Diagonallabel.AutoSize = true;
            this.Diagonallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagonallabel.Location = new System.Drawing.Point(159, 310);
            this.Diagonallabel.Name = "Diagonallabel";
            this.Diagonallabel.Size = new System.Drawing.Size(51, 20);
            this.Diagonallabel.TabIndex = 10;
            this.Diagonallabel.Text = "label8";
            this.Diagonallabel.Visible = false;
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Location = new System.Drawing.Point(153, 357);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(100, 32);
            this.Calculatebutton.TabIndex = 11;
            this.Calculatebutton.Text = "Calculate";
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.Diagonallabel);
            this.Controls.Add(this.Arealabel);
            this.Controls.Add(this.Perimeterlabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WidhttextBox);
            this.Controls.Add(this.LenghttextBox);
            this.Name = "Form1";
            this.Text = "Rectangule Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LenghttextBox;
        private System.Windows.Forms.TextBox WidhttextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Perimeterlabel;
        private System.Windows.Forms.Label Arealabel;
        private System.Windows.Forms.Label Diagonallabel;
        private System.Windows.Forms.Button Calculatebutton;
    }
}

