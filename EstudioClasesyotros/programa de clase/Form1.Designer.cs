namespace programa_de_clase
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Advancedradio = new System.Windows.Forms.RadioButton();
            this.MediumradioButton = new System.Windows.Forms.RadioButton();
            this.BeginnerradioButton = new System.Windows.Forms.RadioButton();
            this.CosttextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EasyRouteBasiccheckBox = new System.Windows.Forms.CheckBox();
            this.AdavancedRouteMediumcheckBox = new System.Windows.Forms.CheckBox();
            this.AdavancedRouteAdvancedcheckBox = new System.Windows.Forms.CheckBox();
            this.EasyRouteAdavancedcheckBox = new System.Windows.Forms.CheckBox();
            this.EasyRouteMediumcheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Advancedradio);
            this.groupBox1.Controls.Add(this.MediumradioButton);
            this.groupBox1.Controls.Add(this.BeginnerradioButton);
            this.groupBox1.Location = new System.Drawing.Point(524, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Experience";
            // 
            // Advancedradio
            // 
            this.Advancedradio.AutoSize = true;
            this.Advancedradio.Location = new System.Drawing.Point(6, 120);
            this.Advancedradio.Name = "Advancedradio";
            this.Advancedradio.Size = new System.Drawing.Size(74, 17);
            this.Advancedradio.TabIndex = 2;
            this.Advancedradio.Text = "Advanced";
            this.Advancedradio.UseVisualStyleBackColor = true;
            this.Advancedradio.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // MediumradioButton
            // 
            this.MediumradioButton.AutoSize = true;
            this.MediumradioButton.Location = new System.Drawing.Point(6, 70);
            this.MediumradioButton.Name = "MediumradioButton";
            this.MediumradioButton.Size = new System.Drawing.Size(62, 17);
            this.MediumradioButton.TabIndex = 1;
            this.MediumradioButton.Text = "Medium";
            this.MediumradioButton.UseVisualStyleBackColor = true;
            this.MediumradioButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // BeginnerradioButton
            // 
            this.BeginnerradioButton.AutoSize = true;
            this.BeginnerradioButton.Checked = true;
            this.BeginnerradioButton.Location = new System.Drawing.Point(6, 20);
            this.BeginnerradioButton.Name = "BeginnerradioButton";
            this.BeginnerradioButton.Size = new System.Drawing.Size(61, 17);
            this.BeginnerradioButton.TabIndex = 0;
            this.BeginnerradioButton.TabStop = true;
            this.BeginnerradioButton.Text = "Beginer";
            this.BeginnerradioButton.UseVisualStyleBackColor = true;
            this.BeginnerradioButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // CosttextBox
            // 
            this.CosttextBox.Location = new System.Drawing.Point(119, 316);
            this.CosttextBox.Name = "CosttextBox";
            this.CosttextBox.Size = new System.Drawing.Size(100, 20);
            this.CosttextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Cost";
            // 
            // EasyRouteBasiccheckBox
            // 
            this.EasyRouteBasiccheckBox.AutoSize = true;
            this.EasyRouteBasiccheckBox.Location = new System.Drawing.Point(119, 85);
            this.EasyRouteBasiccheckBox.Name = "EasyRouteBasiccheckBox";
            this.EasyRouteBasiccheckBox.Size = new System.Drawing.Size(163, 17);
            this.EasyRouteBasiccheckBox.TabIndex = 3;
            this.EasyRouteBasiccheckBox.Text = "Easy Route Basic Equipment";
            this.EasyRouteBasiccheckBox.UseVisualStyleBackColor = true;
            this.EasyRouteBasiccheckBox.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // AdavancedRouteMediumcheckBox
            // 
            this.AdavancedRouteMediumcheckBox.AutoSize = true;
            this.AdavancedRouteMediumcheckBox.Location = new System.Drawing.Point(119, 208);
            this.AdavancedRouteMediumcheckBox.Name = "AdavancedRouteMediumcheckBox";
            this.AdavancedRouteMediumcheckBox.Size = new System.Drawing.Size(206, 17);
            this.AdavancedRouteMediumcheckBox.TabIndex = 4;
            this.AdavancedRouteMediumcheckBox.Text = "Adavanced Route Medium Equipment";
            this.AdavancedRouteMediumcheckBox.UseVisualStyleBackColor = true;
            this.AdavancedRouteMediumcheckBox.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // AdavancedRouteAdvancedcheckBox
            // 
            this.AdavancedRouteAdvancedcheckBox.AutoSize = true;
            this.AdavancedRouteAdvancedcheckBox.Location = new System.Drawing.Point(119, 249);
            this.AdavancedRouteAdvancedcheckBox.Name = "AdavancedRouteAdvancedcheckBox";
            this.AdavancedRouteAdvancedcheckBox.Size = new System.Drawing.Size(218, 17);
            this.AdavancedRouteAdvancedcheckBox.TabIndex = 5;
            this.AdavancedRouteAdvancedcheckBox.Text = "Adavanced Route Advanced Equipment";
            this.AdavancedRouteAdvancedcheckBox.UseVisualStyleBackColor = true;
            this.AdavancedRouteAdvancedcheckBox.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // EasyRouteAdavancedcheckBox
            // 
            this.EasyRouteAdavancedcheckBox.AutoSize = true;
            this.EasyRouteAdavancedcheckBox.Location = new System.Drawing.Point(119, 167);
            this.EasyRouteAdavancedcheckBox.Name = "EasyRouteAdavancedcheckBox";
            this.EasyRouteAdavancedcheckBox.Size = new System.Drawing.Size(186, 17);
            this.EasyRouteAdavancedcheckBox.TabIndex = 6;
            this.EasyRouteAdavancedcheckBox.Text = "Easy Route Advanced Equipment";
            this.EasyRouteAdavancedcheckBox.UseVisualStyleBackColor = true;
            this.EasyRouteAdavancedcheckBox.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // EasyRouteMediumcheckBox
            // 
            this.EasyRouteMediumcheckBox.AutoSize = true;
            this.EasyRouteMediumcheckBox.Location = new System.Drawing.Point(119, 126);
            this.EasyRouteMediumcheckBox.Name = "EasyRouteMediumcheckBox";
            this.EasyRouteMediumcheckBox.Size = new System.Drawing.Size(174, 17);
            this.EasyRouteMediumcheckBox.TabIndex = 7;
            this.EasyRouteMediumcheckBox.Text = "Easy Route Medium Equipment";
            this.EasyRouteMediumcheckBox.UseVisualStyleBackColor = true;
            this.EasyRouteMediumcheckBox.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EasyRouteMediumcheckBox);
            this.Controls.Add(this.EasyRouteAdavancedcheckBox);
            this.Controls.Add(this.AdavancedRouteAdvancedcheckBox);
            this.Controls.Add(this.AdavancedRouteMediumcheckBox);
            this.Controls.Add(this.EasyRouteBasiccheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CosttextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Advancedradio;
        private System.Windows.Forms.RadioButton MediumradioButton;
        private System.Windows.Forms.RadioButton BeginnerradioButton;
        private System.Windows.Forms.TextBox CosttextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox EasyRouteBasiccheckBox;
        private System.Windows.Forms.CheckBox AdavancedRouteMediumcheckBox;
        private System.Windows.Forms.CheckBox AdavancedRouteAdvancedcheckBox;
        private System.Windows.Forms.CheckBox EasyRouteAdavancedcheckBox;
        private System.Windows.Forms.CheckBox EasyRouteMediumcheckBox;
    }
}

