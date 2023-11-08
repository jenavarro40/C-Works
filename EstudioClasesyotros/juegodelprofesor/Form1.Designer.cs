namespace juegodelprofesor
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
            this.card1button = new System.Windows.Forms.Button();
            this.card2button = new System.Windows.Forms.Button();
            this.card3button = new System.Windows.Forms.Button();
            this.Betbutton = new System.Windows.Forms.Button();
            this.WintextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Playbutton = new System.Windows.Forms.Button();
            this.Moneybutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // card1button
            // 
            this.card1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card1button.Location = new System.Drawing.Point(150, 12);
            this.card1button.Name = "card1button";
            this.card1button.Size = new System.Drawing.Size(156, 242);
            this.card1button.TabIndex = 0;
            this.card1button.Text = "E";
            this.card1button.UseVisualStyleBackColor = true;
            // 
            // card2button
            // 
            this.card2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card2button.Location = new System.Drawing.Point(322, 12);
            this.card2button.Name = "card2button";
            this.card2button.Size = new System.Drawing.Size(156, 242);
            this.card2button.TabIndex = 1;
            this.card2button.Text = "E";
            this.card2button.UseVisualStyleBackColor = true;
            // 
            // card3button
            // 
            this.card3button.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card3button.Location = new System.Drawing.Point(494, 12);
            this.card3button.Name = "card3button";
            this.card3button.Size = new System.Drawing.Size(156, 242);
            this.card3button.TabIndex = 2;
            this.card3button.Text = "E";
            this.card3button.UseVisualStyleBackColor = true;
            // 
            // Betbutton
            // 
            this.Betbutton.Enabled = false;
            this.Betbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Betbutton.Location = new System.Drawing.Point(150, 290);
            this.Betbutton.Name = "Betbutton";
            this.Betbutton.Size = new System.Drawing.Size(75, 35);
            this.Betbutton.TabIndex = 3;
            this.Betbutton.Text = "Bet";
            this.Betbutton.UseVisualStyleBackColor = true;
            this.Betbutton.Click += new System.EventHandler(this.Betbutton_Click);
            // 
            // WintextBox
            // 
            this.WintextBox.Location = new System.Drawing.Point(550, 290);
            this.WintextBox.Name = "WintextBox";
            this.WintextBox.Size = new System.Drawing.Size(100, 20);
            this.WintextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "win";
            // 
            // Playbutton
            // 
            this.Playbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playbutton.Location = new System.Drawing.Point(150, 349);
            this.Playbutton.Name = "Playbutton";
            this.Playbutton.Size = new System.Drawing.Size(75, 35);
            this.Playbutton.TabIndex = 6;
            this.Playbutton.Text = "Play";
            this.Playbutton.UseVisualStyleBackColor = true;
            this.Playbutton.Visible = false;
            this.Playbutton.Click += new System.EventHandler(this.Playbutton_Click);
            // 
            // Moneybutton
            // 
            this.Moneybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Moneybutton.Location = new System.Drawing.Point(322, 290);
            this.Moneybutton.Name = "Moneybutton";
            this.Moneybutton.Size = new System.Drawing.Size(156, 35);
            this.Moneybutton.TabIndex = 7;
            this.Moneybutton.Text = "Charge Money";
            this.Moneybutton.UseVisualStyleBackColor = true;
            this.Moneybutton.Click += new System.EventHandler(this.Moneybutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 406);
            this.Controls.Add(this.Moneybutton);
            this.Controls.Add(this.Playbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WintextBox);
            this.Controls.Add(this.Betbutton);
            this.Controls.Add(this.card3button);
            this.Controls.Add(this.card2button);
            this.Controls.Add(this.card1button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button card1button;
        private System.Windows.Forms.Button card2button;
        private System.Windows.Forms.Button card3button;
        private System.Windows.Forms.Button Betbutton;
        private System.Windows.Forms.TextBox WintextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Playbutton;
        private System.Windows.Forms.Button Moneybutton;
    }
}

