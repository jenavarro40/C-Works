namespace page696ex4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SportpictureBox = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sportgroupBox = new System.Windows.Forms.GroupBox();
            this.TenisradioButton = new System.Windows.Forms.RadioButton();
            this.TaekradioButton = new System.Windows.Forms.RadioButton();
            this.BasketradioButton = new System.Windows.Forms.RadioButton();
            this.BikeradioButton = new System.Windows.Forms.RadioButton();
            this.FutbolradioButton = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cleanbutton = new System.Windows.Forms.Button();
            this.Vallabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.impcheckBox = new System.Windows.Forms.CheckBox();
            this.sendbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SportpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.sportgroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SportpictureBox
            // 
            this.SportpictureBox.Image = global::page696ex4.Properties.Resources.sports;
            this.SportpictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("SportpictureBox.InitialImage")));
            this.SportpictureBox.Location = new System.Drawing.Point(114, 33);
            this.SportpictureBox.Name = "SportpictureBox";
            this.SportpictureBox.Size = new System.Drawing.Size(246, 242);
            this.SportpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SportpictureBox.TabIndex = 0;
            this.SportpictureBox.TabStop = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // sportgroupBox
            // 
            this.sportgroupBox.Controls.Add(this.TenisradioButton);
            this.sportgroupBox.Controls.Add(this.TaekradioButton);
            this.sportgroupBox.Controls.Add(this.BasketradioButton);
            this.sportgroupBox.Controls.Add(this.BikeradioButton);
            this.sportgroupBox.Controls.Add(this.FutbolradioButton);
            this.sportgroupBox.Location = new System.Drawing.Point(6, 75);
            this.sportgroupBox.Name = "sportgroupBox";
            this.sportgroupBox.Size = new System.Drawing.Size(102, 138);
            this.sportgroupBox.TabIndex = 1;
            this.sportgroupBox.TabStop = false;
            this.sportgroupBox.Text = "Sports";
            // 
            // TenisradioButton
            // 
            this.TenisradioButton.AutoSize = true;
            this.TenisradioButton.Location = new System.Drawing.Point(7, 112);
            this.TenisradioButton.Name = "TenisradioButton";
            this.TenisradioButton.Size = new System.Drawing.Size(51, 17);
            this.TenisradioButton.TabIndex = 4;
            this.TenisradioButton.TabStop = true;
            this.TenisradioButton.Text = "Tenis";
            this.TenisradioButton.UseVisualStyleBackColor = true;
            this.TenisradioButton.CheckedChanged += new System.EventHandler(this.allradioButton_CheckedChanged);
            // 
            // TaekradioButton
            // 
            this.TaekradioButton.AutoSize = true;
            this.TaekradioButton.Location = new System.Drawing.Point(7, 89);
            this.TaekradioButton.Name = "TaekradioButton";
            this.TaekradioButton.Size = new System.Drawing.Size(82, 17);
            this.TaekradioButton.TabIndex = 3;
            this.TaekradioButton.TabStop = true;
            this.TaekradioButton.Text = "Taekondow";
            this.TaekradioButton.UseVisualStyleBackColor = true;
            this.TaekradioButton.CheckedChanged += new System.EventHandler(this.allradioButton_CheckedChanged);
            // 
            // BasketradioButton
            // 
            this.BasketradioButton.AutoSize = true;
            this.BasketradioButton.Location = new System.Drawing.Point(7, 66);
            this.BasketradioButton.Name = "BasketradioButton";
            this.BasketradioButton.Size = new System.Drawing.Size(74, 17);
            this.BasketradioButton.TabIndex = 2;
            this.BasketradioButton.TabStop = true;
            this.BasketradioButton.Text = "Basketball";
            this.BasketradioButton.UseVisualStyleBackColor = true;
            this.BasketradioButton.CheckedChanged += new System.EventHandler(this.allradioButton_CheckedChanged);
            // 
            // BikeradioButton
            // 
            this.BikeradioButton.AutoSize = true;
            this.BikeradioButton.Location = new System.Drawing.Point(7, 43);
            this.BikeradioButton.Name = "BikeradioButton";
            this.BikeradioButton.Size = new System.Drawing.Size(46, 17);
            this.BikeradioButton.TabIndex = 1;
            this.BikeradioButton.TabStop = true;
            this.BikeradioButton.Text = "Bike";
            this.BikeradioButton.UseVisualStyleBackColor = true;
            this.BikeradioButton.CheckedChanged += new System.EventHandler(this.allradioButton_CheckedChanged);
            // 
            // FutbolradioButton
            // 
            this.FutbolradioButton.AutoSize = true;
            this.FutbolradioButton.Location = new System.Drawing.Point(7, 20);
            this.FutbolradioButton.Name = "FutbolradioButton";
            this.FutbolradioButton.Size = new System.Drawing.Size(54, 17);
            this.FutbolradioButton.TabIndex = 0;
            this.FutbolradioButton.TabStop = true;
            this.FutbolradioButton.Text = "Futbol";
            this.FutbolradioButton.UseVisualStyleBackColor = true;
            this.FutbolradioButton.CheckedChanged += new System.EventHandler(this.allradioButton_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(387, 355);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sportgroupBox);
            this.tabPage1.Controls.Add(this.SportpictureBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(379, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sports";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cleanbutton);
            this.tabPage2.Controls.Add(this.Vallabel);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.NametextBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.impcheckBox);
            this.tabPage2.Controls.Add(this.sendbutton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(379, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inscription";
            // 
            // cleanbutton
            // 
            this.cleanbutton.Location = new System.Drawing.Point(152, 153);
            this.cleanbutton.Name = "cleanbutton";
            this.cleanbutton.Size = new System.Drawing.Size(75, 23);
            this.cleanbutton.TabIndex = 6;
            this.cleanbutton.Text = "Clean";
            this.cleanbutton.UseVisualStyleBackColor = true;
            this.cleanbutton.Click += new System.EventHandler(this.cleanbutton_Click);
            // 
            // Vallabel
            // 
            this.Vallabel.AutoSize = true;
            this.Vallabel.Location = new System.Drawing.Point(76, 109);
            this.Vallabel.Name = "Vallabel";
            this.Vallabel.Size = new System.Drawing.Size(22, 13);
            this.Vallabel.TabIndex = 5;
            this.Vallabel.Text = "$ 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Value:";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(47, 56);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(256, 20);
            this.NametextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // impcheckBox
            // 
            this.impcheckBox.AutoSize = true;
            this.impcheckBox.Location = new System.Drawing.Point(9, 21);
            this.impcheckBox.Name = "impcheckBox";
            this.impcheckBox.Size = new System.Drawing.Size(118, 17);
            this.impcheckBox.TabIndex = 1;
            this.impcheckBox.Text = "Buy Implementation";
            this.impcheckBox.UseVisualStyleBackColor = true;
            this.impcheckBox.CheckedChanged += new System.EventHandler(this.allradioButton_CheckedChanged);
            // 
            // sendbutton
            // 
            this.sendbutton.Location = new System.Drawing.Point(9, 154);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(75, 23);
            this.sendbutton.TabIndex = 0;
            this.sendbutton.Text = "Send";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 331);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Sports";
            ((System.ComponentModel.ISupportInitialize)(this.SportpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.sportgroupBox.ResumeLayout(false);
            this.sportgroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SportpictureBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox sportgroupBox;
        private System.Windows.Forms.RadioButton TenisradioButton;
        private System.Windows.Forms.RadioButton TaekradioButton;
        private System.Windows.Forms.RadioButton BasketradioButton;
        private System.Windows.Forms.RadioButton BikeradioButton;
        private System.Windows.Forms.RadioButton FutbolradioButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox impcheckBox;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Vallabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cleanbutton;
    }
}

