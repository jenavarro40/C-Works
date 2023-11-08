namespace Ejercicio4Chapter10
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
            this.FutbolcheckBox = new System.Windows.Forms.CheckBox();
            this.BasketcheckBox = new System.Windows.Forms.CheckBox();
            this.SwimmingcheckBox = new System.Windows.Forms.CheckBox();
            this.BaseballcheckBox = new System.Windows.Forms.CheckBox();
            this.TaekondocheckBox = new System.Windows.Forms.CheckBox();
            this.KidNametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SportPictureBox = new System.Windows.Forms.PictureBox();
            this.Sendbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SportPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FutbolcheckBox
            // 
            this.FutbolcheckBox.AutoSize = true;
            this.FutbolcheckBox.Location = new System.Drawing.Point(36, 43);
            this.FutbolcheckBox.Name = "FutbolcheckBox";
            this.FutbolcheckBox.Size = new System.Drawing.Size(55, 17);
            this.FutbolcheckBox.TabIndex = 0;
            this.FutbolcheckBox.Text = "Futbol";
            this.FutbolcheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.FutbolcheckBox.UseVisualStyleBackColor = true;
            this.FutbolcheckBox.CheckedChanged += new System.EventHandler(this.FutbolcheckBox_CheckedChanged);
            // 
            // BasketcheckBox
            // 
            this.BasketcheckBox.AutoSize = true;
            this.BasketcheckBox.Location = new System.Drawing.Point(36, 76);
            this.BasketcheckBox.Name = "BasketcheckBox";
            this.BasketcheckBox.Size = new System.Drawing.Size(59, 17);
            this.BasketcheckBox.TabIndex = 1;
            this.BasketcheckBox.Text = "Basket";
            this.BasketcheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BasketcheckBox.UseVisualStyleBackColor = true;
            this.BasketcheckBox.CheckedChanged += new System.EventHandler(this.BasketcheckBox_CheckedChanged);
            // 
            // SwimmingcheckBox
            // 
            this.SwimmingcheckBox.AutoSize = true;
            this.SwimmingcheckBox.Location = new System.Drawing.Point(36, 109);
            this.SwimmingcheckBox.Name = "SwimmingcheckBox";
            this.SwimmingcheckBox.Size = new System.Drawing.Size(81, 17);
            this.SwimmingcheckBox.TabIndex = 2;
            this.SwimmingcheckBox.Text = "Swwimming";
            this.SwimmingcheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SwimmingcheckBox.UseVisualStyleBackColor = true;
            this.SwimmingcheckBox.CheckedChanged += new System.EventHandler(this.SwimmingcheckBox_CheckedChanged);
            // 
            // BaseballcheckBox
            // 
            this.BaseballcheckBox.AutoSize = true;
            this.BaseballcheckBox.Location = new System.Drawing.Point(36, 142);
            this.BaseballcheckBox.Name = "BaseballcheckBox";
            this.BaseballcheckBox.Size = new System.Drawing.Size(66, 17);
            this.BaseballcheckBox.TabIndex = 3;
            this.BaseballcheckBox.Text = "Baseball";
            this.BaseballcheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BaseballcheckBox.UseVisualStyleBackColor = true;
            this.BaseballcheckBox.CheckedChanged += new System.EventHandler(this.BaseballcheckBox_CheckedChanged);
            // 
            // TaekondocheckBox
            // 
            this.TaekondocheckBox.AutoSize = true;
            this.TaekondocheckBox.Location = new System.Drawing.Point(36, 175);
            this.TaekondocheckBox.Name = "TaekondocheckBox";
            this.TaekondocheckBox.Size = new System.Drawing.Size(75, 17);
            this.TaekondocheckBox.TabIndex = 4;
            this.TaekondocheckBox.Text = "Taekondo";
            this.TaekondocheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TaekondocheckBox.UseVisualStyleBackColor = true;
            this.TaekondocheckBox.CheckedChanged += new System.EventHandler(this.TaekondocheckBox_CheckedChanged);
            // 
            // KidNametextBox
            // 
            this.KidNametextBox.Location = new System.Drawing.Point(36, 304);
            this.KidNametextBox.Name = "KidNametextBox";
            this.KidNametextBox.Size = new System.Drawing.Size(382, 20);
            this.KidNametextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kid Name:";
            // 
            // SportPictureBox
            // 
            this.SportPictureBox.Location = new System.Drawing.Point(357, 43);
            this.SportPictureBox.Name = "SportPictureBox";
            this.SportPictureBox.Size = new System.Drawing.Size(252, 207);
            this.SportPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SportPictureBox.TabIndex = 5;
            this.SportPictureBox.TabStop = false;
            // 
            // Sendbutton
            // 
            this.Sendbutton.Location = new System.Drawing.Point(461, 304);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(75, 23);
            this.Sendbutton.TabIndex = 8;
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KidNametextBox);
            this.Controls.Add(this.SportPictureBox);
            this.Controls.Add(this.TaekondocheckBox);
            this.Controls.Add(this.BaseballcheckBox);
            this.Controls.Add(this.SwimmingcheckBox);
            this.Controls.Add(this.BasketcheckBox);
            this.Controls.Add(this.FutbolcheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SportPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox FutbolcheckBox;
        private System.Windows.Forms.CheckBox BasketcheckBox;
        private System.Windows.Forms.CheckBox SwimmingcheckBox;
        private System.Windows.Forms.CheckBox BaseballcheckBox;
        private System.Windows.Forms.CheckBox TaekondocheckBox;
        private System.Windows.Forms.PictureBox SportPictureBox;
        private System.Windows.Forms.TextBox KidNametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sendbutton;
    }
}

