namespace Ejercicio9Chapter10
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
            this.FloortabControl = new System.Windows.Forms.TabControl();
            this.HardWoodtabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CherryradioButton = new System.Windows.Forms.RadioButton();
            this.WalnutradioButton = new System.Windows.Forms.RadioButton();
            this.MapleradioButton = new System.Windows.Forms.RadioButton();
            this.OakradioButton = new System.Windows.Forms.RadioButton();
            this.LaminatetabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HardradioButton = new System.Windows.Forms.RadioButton();
            this.SoftradioButton = new System.Windows.Forms.RadioButton();
            this.StandarradioButton = new System.Windows.Forms.RadioButton();
            this.CarpettabPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ThickradioButton = new System.Windows.Forms.RadioButton();
            this.MediumradioButton = new System.Windows.Forms.RadioButton();
            this.ThinradioButton = new System.Windows.Forms.RadioButton();
            this.WidthtextBox = new System.Windows.Forms.TextBox();
            this.LengthtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.Label();
            this.Totallabel = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.DataErroneaLabel = new System.Windows.Forms.Label();
            this.FloortabControl.SuspendLayout();
            this.HardWoodtabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.LaminatetabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.CarpettabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // FloortabControl
            // 
            this.FloortabControl.Controls.Add(this.HardWoodtabPage);
            this.FloortabControl.Controls.Add(this.LaminatetabPage);
            this.FloortabControl.Controls.Add(this.CarpettabPage);
            this.FloortabControl.Location = new System.Drawing.Point(-1, 12);
            this.FloortabControl.Name = "FloortabControl";
            this.FloortabControl.SelectedIndex = 0;
            this.FloortabControl.Size = new System.Drawing.Size(226, 226);
            this.FloortabControl.TabIndex = 0;
            // 
            // HardWoodtabPage
            // 
            this.HardWoodtabPage.Controls.Add(this.groupBox1);
            this.HardWoodtabPage.Location = new System.Drawing.Point(4, 22);
            this.HardWoodtabPage.Name = "HardWoodtabPage";
            this.HardWoodtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HardWoodtabPage.Size = new System.Drawing.Size(218, 200);
            this.HardWoodtabPage.TabIndex = 0;
            this.HardWoodtabPage.Text = "Hard Wood";
            this.HardWoodtabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CherryradioButton);
            this.groupBox1.Controls.Add(this.WalnutradioButton);
            this.groupBox1.Controls.Add(this.MapleradioButton);
            this.groupBox1.Controls.Add(this.OakradioButton);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CherryradioButton
            // 
            this.CherryradioButton.AutoSize = true;
            this.CherryradioButton.Location = new System.Drawing.Point(7, 155);
            this.CherryradioButton.Name = "CherryradioButton";
            this.CherryradioButton.Size = new System.Drawing.Size(55, 17);
            this.CherryradioButton.TabIndex = 3;
            this.CherryradioButton.Text = "Cherry";
            this.CherryradioButton.UseVisualStyleBackColor = true;
            this.CherryradioButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // WalnutradioButton
            // 
            this.WalnutradioButton.AutoSize = true;
            this.WalnutradioButton.Location = new System.Drawing.Point(7, 116);
            this.WalnutradioButton.Name = "WalnutradioButton";
            this.WalnutradioButton.Size = new System.Drawing.Size(59, 17);
            this.WalnutradioButton.TabIndex = 2;
            this.WalnutradioButton.Text = "Walnut";
            this.WalnutradioButton.UseVisualStyleBackColor = true;
            this.WalnutradioButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // MapleradioButton
            // 
            this.MapleradioButton.AutoSize = true;
            this.MapleradioButton.Location = new System.Drawing.Point(7, 77);
            this.MapleradioButton.Name = "MapleradioButton";
            this.MapleradioButton.Size = new System.Drawing.Size(54, 17);
            this.MapleradioButton.TabIndex = 1;
            this.MapleradioButton.Text = "Maple";
            this.MapleradioButton.UseVisualStyleBackColor = true;
            this.MapleradioButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // OakradioButton
            // 
            this.OakradioButton.AutoSize = true;
            this.OakradioButton.Checked = true;
            this.OakradioButton.Location = new System.Drawing.Point(7, 38);
            this.OakradioButton.Name = "OakradioButton";
            this.OakradioButton.Size = new System.Drawing.Size(45, 17);
            this.OakradioButton.TabIndex = 0;
            this.OakradioButton.TabStop = true;
            this.OakradioButton.Text = "Oak";
            this.OakradioButton.UseVisualStyleBackColor = true;
            this.OakradioButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // LaminatetabPage
            // 
            this.LaminatetabPage.Controls.Add(this.groupBox2);
            this.LaminatetabPage.Location = new System.Drawing.Point(4, 22);
            this.LaminatetabPage.Name = "LaminatetabPage";
            this.LaminatetabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LaminatetabPage.Size = new System.Drawing.Size(218, 200);
            this.LaminatetabPage.TabIndex = 1;
            this.LaminatetabPage.Text = "Laminate";
            this.LaminatetabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HardradioButton);
            this.groupBox2.Controls.Add(this.SoftradioButton);
            this.groupBox2.Controls.Add(this.StandarradioButton);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // HardradioButton
            // 
            this.HardradioButton.AutoSize = true;
            this.HardradioButton.Location = new System.Drawing.Point(7, 116);
            this.HardradioButton.Name = "HardradioButton";
            this.HardradioButton.Size = new System.Drawing.Size(81, 17);
            this.HardradioButton.TabIndex = 2;
            this.HardradioButton.Text = "Hard Traffic";
            this.HardradioButton.UseVisualStyleBackColor = true;
            this.HardradioButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // SoftradioButton
            // 
            this.SoftradioButton.AutoSize = true;
            this.SoftradioButton.Location = new System.Drawing.Point(7, 77);
            this.SoftradioButton.Name = "SoftradioButton";
            this.SoftradioButton.Size = new System.Drawing.Size(77, 17);
            this.SoftradioButton.TabIndex = 1;
            this.SoftradioButton.Text = "Soft Traffic";
            this.SoftradioButton.UseVisualStyleBackColor = true;
            this.SoftradioButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // StandarradioButton
            // 
            this.StandarradioButton.AutoSize = true;
            this.StandarradioButton.Checked = true;
            this.StandarradioButton.Location = new System.Drawing.Point(7, 38);
            this.StandarradioButton.Name = "StandarradioButton";
            this.StandarradioButton.Size = new System.Drawing.Size(68, 17);
            this.StandarradioButton.TabIndex = 0;
            this.StandarradioButton.TabStop = true;
            this.StandarradioButton.Text = "Standard";
            this.StandarradioButton.UseVisualStyleBackColor = true;
            this.StandarradioButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // CarpettabPage
            // 
            this.CarpettabPage.Controls.Add(this.groupBox3);
            this.CarpettabPage.Location = new System.Drawing.Point(4, 22);
            this.CarpettabPage.Name = "CarpettabPage";
            this.CarpettabPage.Size = new System.Drawing.Size(218, 200);
            this.CarpettabPage.TabIndex = 2;
            this.CarpettabPage.Text = "Carpet";
            this.CarpettabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ThickradioButton);
            this.groupBox3.Controls.Add(this.MediumradioButton);
            this.groupBox3.Controls.Add(this.ThinradioButton);
            this.groupBox3.Location = new System.Drawing.Point(9, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 189);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // ThickradioButton
            // 
            this.ThickradioButton.AutoSize = true;
            this.ThickradioButton.Location = new System.Drawing.Point(7, 116);
            this.ThickradioButton.Name = "ThickradioButton";
            this.ThickradioButton.Size = new System.Drawing.Size(52, 17);
            this.ThickradioButton.TabIndex = 2;
            this.ThickradioButton.Text = "Thick";
            this.ThickradioButton.UseVisualStyleBackColor = true;
            this.ThickradioButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // MediumradioButton
            // 
            this.MediumradioButton.AutoSize = true;
            this.MediumradioButton.Location = new System.Drawing.Point(7, 77);
            this.MediumradioButton.Name = "MediumradioButton";
            this.MediumradioButton.Size = new System.Drawing.Size(62, 17);
            this.MediumradioButton.TabIndex = 1;
            this.MediumradioButton.Text = "Medium";
            this.MediumradioButton.UseVisualStyleBackColor = true;
            this.MediumradioButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // ThinradioButton
            // 
            this.ThinradioButton.AutoSize = true;
            this.ThinradioButton.Checked = true;
            this.ThinradioButton.Location = new System.Drawing.Point(7, 38);
            this.ThinradioButton.Name = "ThinradioButton";
            this.ThinradioButton.Size = new System.Drawing.Size(46, 17);
            this.ThinradioButton.TabIndex = 0;
            this.ThinradioButton.TabStop = true;
            this.ThinradioButton.Text = "Thin";
            this.ThinradioButton.UseVisualStyleBackColor = true;
            this.ThinradioButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // WidthtextBox
            // 
            this.WidthtextBox.Location = new System.Drawing.Point(334, 34);
            this.WidthtextBox.Name = "WidthtextBox";
            this.WidthtextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthtextBox.TabIndex = 1;
            // 
            // LengthtextBox
            // 
            this.LengthtextBox.Location = new System.Drawing.Point(334, 75);
            this.LengthtextBox.Name = "LengthtextBox";
            this.LengthtextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthtextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Location = new System.Drawing.Point(288, 75);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(40, 13);
            this.Length.TabIndex = 4;
            this.Length.Text = "Length";
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallabel.Location = new System.Drawing.Point(334, 141);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(40, 20);
            this.Totallabel.TabIndex = 5;
            this.Totallabel.Text = "0.00";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(288, 145);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 6;
            this.Total.Text = "Total";
            // 
            // DataErroneaLabel
            // 
            this.DataErroneaLabel.AutoSize = true;
            this.DataErroneaLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataErroneaLabel.Location = new System.Drawing.Point(251, 105);
            this.DataErroneaLabel.Name = "DataErroneaLabel";
            this.DataErroneaLabel.Size = new System.Drawing.Size(34, 23);
            this.DataErroneaLabel.TabIndex = 7;
            this.DataErroneaLabel.Text = "\"0\"";
            this.DataErroneaLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 257);
            this.Controls.Add(this.DataErroneaLabel);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Totallabel);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LengthtextBox);
            this.Controls.Add(this.WidthtextBox);
            this.Controls.Add(this.FloortabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FloortabControl.ResumeLayout(false);
            this.HardWoodtabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.LaminatetabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.CarpettabPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl FloortabControl;
        private System.Windows.Forms.TabPage HardWoodtabPage;
        private System.Windows.Forms.TabPage LaminatetabPage;
        private System.Windows.Forms.TabPage CarpettabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CherryradioButton;
        private System.Windows.Forms.RadioButton WalnutradioButton;
        private System.Windows.Forms.RadioButton MapleradioButton;
        private System.Windows.Forms.RadioButton OakradioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton HardradioButton;
        private System.Windows.Forms.RadioButton SoftradioButton;
        private System.Windows.Forms.RadioButton StandarradioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton ThickradioButton;
        private System.Windows.Forms.RadioButton MediumradioButton;
        private System.Windows.Forms.RadioButton ThinradioButton;
        private System.Windows.Forms.TextBox WidthtextBox;
        private System.Windows.Forms.TextBox LengthtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.Label Total;
        public System.Windows.Forms.Label DataErroneaLabel;
    }
}

