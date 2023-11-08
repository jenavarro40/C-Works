namespace Ejercicio10Chapter10
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DataInfotabPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhonetextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.AdresstextBox = new System.Windows.Forms.TextBox();
            this.TopicstabPage = new System.Windows.Forms.TabPage();
            this.TopicscheckedListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FlavorcomboBox = new System.Windows.Forms.ComboBox();
            this.SizecomboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OtherProductstabPage = new System.Windows.Forms.TabPage();
            this.OthercheckedListBox = new System.Windows.Forms.ListBox();
            this.BevaragetabPage = new System.Windows.Forms.TabPage();
            this.BevaragecheckedListBox = new System.Windows.Forms.ListBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.SendtabPage = new System.Windows.Forms.TabPage();
            this.OutrichTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.DataInfotabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TopicstabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.OtherProductstabPage.SuspendLayout();
            this.BevaragetabPage.SuspendLayout();
            this.SendtabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DataInfotabPage);
            this.tabControl1.Controls.Add(this.TopicstabPage);
            this.tabControl1.Controls.Add(this.OtherProductstabPage);
            this.tabControl1.Controls.Add(this.BevaragetabPage);
            this.tabControl1.Controls.Add(this.SendtabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 283);
            this.tabControl1.TabIndex = 0;
            // 
            // DataInfotabPage
            // 
            this.DataInfotabPage.Controls.Add(this.label4);
            this.DataInfotabPage.Controls.Add(this.NametextBox);
            this.DataInfotabPage.Controls.Add(this.pictureBox2);
            this.DataInfotabPage.Controls.Add(this.label3);
            this.DataInfotabPage.Controls.Add(this.label2);
            this.DataInfotabPage.Controls.Add(this.label1);
            this.DataInfotabPage.Controls.Add(this.PhonetextBox);
            this.DataInfotabPage.Controls.Add(this.EmailtextBox);
            this.DataInfotabPage.Controls.Add(this.AdresstextBox);
            this.DataInfotabPage.Location = new System.Drawing.Point(4, 22);
            this.DataInfotabPage.Name = "DataInfotabPage";
            this.DataInfotabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DataInfotabPage.Size = new System.Drawing.Size(628, 257);
            this.DataInfotabPage.TabIndex = 0;
            this.DataInfotabPage.Text = "Data Information";
            this.DataInfotabPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone Number";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(122, 44);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(182, 20);
            this.NametextBox.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ejercicio10Chapter10.Properties.Resources.Ajiaco;
            this.pictureBox2.Location = new System.Drawing.Point(425, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // PhonetextBox
            // 
            this.PhonetextBox.Location = new System.Drawing.Point(125, 199);
            this.PhonetextBox.Name = "PhonetextBox";
            this.PhonetextBox.Size = new System.Drawing.Size(182, 20);
            this.PhonetextBox.TabIndex = 2;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(122, 141);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(182, 20);
            this.EmailtextBox.TabIndex = 1;
            // 
            // AdresstextBox
            // 
            this.AdresstextBox.Location = new System.Drawing.Point(125, 91);
            this.AdresstextBox.Name = "AdresstextBox";
            this.AdresstextBox.Size = new System.Drawing.Size(182, 20);
            this.AdresstextBox.TabIndex = 0;
            // 
            // TopicstabPage
            // 
            this.TopicstabPage.Controls.Add(this.TopicscheckedListBox);
            this.TopicstabPage.Controls.Add(this.label5);
            this.TopicstabPage.Controls.Add(this.FlavorcomboBox);
            this.TopicstabPage.Controls.Add(this.SizecomboBox);
            this.TopicstabPage.Controls.Add(this.pictureBox1);
            this.TopicstabPage.Location = new System.Drawing.Point(4, 22);
            this.TopicstabPage.Name = "TopicstabPage";
            this.TopicstabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TopicstabPage.Size = new System.Drawing.Size(628, 257);
            this.TopicstabPage.TabIndex = 1;
            this.TopicstabPage.Text = "Topics and Size";
            this.TopicstabPage.UseVisualStyleBackColor = true;
            // 
            // TopicscheckedListBox
            // 
            this.TopicscheckedListBox.FormattingEnabled = true;
            this.TopicscheckedListBox.Items.AddRange(new object[] {
            "Onion",
            "Marinan Sauce",
            "Cheese",
            "Tomato",
            "Pesto",
            "Meats",
            "Non Sauce-No extra charge"});
            this.TopicscheckedListBox.Location = new System.Drawing.Point(41, 129);
            this.TopicscheckedListBox.Name = "TopicscheckedListBox";
            this.TopicscheckedListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.TopicscheckedListBox.Size = new System.Drawing.Size(140, 95);
            this.TopicscheckedListBox.TabIndex = 6;
            this.TopicscheckedListBox.SelectedIndexChanged += new System.EventHandler(this.Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Topics-$1.1 each one";
            // 
            // FlavorcomboBox
            // 
            this.FlavorcomboBox.FormattingEnabled = true;
            this.FlavorcomboBox.Items.AddRange(new object[] {
            "Supreme",
            "Veggie",
            "Meats",
            "Peperoni",
            "Mexican",
            "Hawian",
            "sweet"});
            this.FlavorcomboBox.Location = new System.Drawing.Point(201, 42);
            this.FlavorcomboBox.Name = "FlavorcomboBox";
            this.FlavorcomboBox.Size = new System.Drawing.Size(121, 21);
            this.FlavorcomboBox.TabIndex = 3;
            this.FlavorcomboBox.Text = "Flavor:";
            this.FlavorcomboBox.SelectedIndexChanged += new System.EventHandler(this.Changed);
            // 
            // SizecomboBox
            // 
            this.SizecomboBox.FormattingEnabled = true;
            this.SizecomboBox.Items.AddRange(new object[] {
            "Personal-$7.5",
            "Small-$14.95",
            "Medium-$18.99",
            "Large-$21.45",
            "Familiar-$27.99"});
            this.SizecomboBox.Location = new System.Drawing.Point(41, 42);
            this.SizecomboBox.Name = "SizecomboBox";
            this.SizecomboBox.Size = new System.Drawing.Size(121, 21);
            this.SizecomboBox.TabIndex = 2;
            this.SizecomboBox.Text = "Size:";
            this.SizecomboBox.SelectedIndexChanged += new System.EventHandler(this.Changed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ejercicio10Chapter10.Properties.Resources.Ajiaco;
            this.pictureBox1.Location = new System.Drawing.Point(534, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // OtherProductstabPage
            // 
            this.OtherProductstabPage.Controls.Add(this.OthercheckedListBox);
            this.OtherProductstabPage.Location = new System.Drawing.Point(4, 22);
            this.OtherProductstabPage.Name = "OtherProductstabPage";
            this.OtherProductstabPage.Size = new System.Drawing.Size(628, 257);
            this.OtherProductstabPage.TabIndex = 2;
            this.OtherProductstabPage.Text = "Other Products";
            this.OtherProductstabPage.UseVisualStyleBackColor = true;
            // 
            // OthercheckedListBox
            // 
            this.OthercheckedListBox.FormattingEnabled = true;
            this.OthercheckedListBox.Items.AddRange(new object[] {
            "Hamburger-$14",
            "Wings-$10.99",
            "Hot Dog-$8.95",
            "Bread Strick-No Charge",
            "Chicken Sticks-$11"});
            this.OthercheckedListBox.Location = new System.Drawing.Point(3, 15);
            this.OthercheckedListBox.Name = "OthercheckedListBox";
            this.OthercheckedListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.OthercheckedListBox.Size = new System.Drawing.Size(140, 69);
            this.OthercheckedListBox.TabIndex = 7;
            this.OthercheckedListBox.SelectedIndexChanged += new System.EventHandler(this.Changed);
            // 
            // BevaragetabPage
            // 
            this.BevaragetabPage.Controls.Add(this.BevaragecheckedListBox);
            this.BevaragetabPage.Location = new System.Drawing.Point(4, 22);
            this.BevaragetabPage.Name = "BevaragetabPage";
            this.BevaragetabPage.Size = new System.Drawing.Size(628, 257);
            this.BevaragetabPage.TabIndex = 3;
            this.BevaragetabPage.Text = "Bevarage";
            this.BevaragetabPage.UseVisualStyleBackColor = true;
            // 
            // BevaragecheckedListBox
            // 
            this.BevaragecheckedListBox.FormattingEnabled = true;
            this.BevaragecheckedListBox.Items.AddRange(new object[] {
            "Coke-$2",
            "Pepsi-$2",
            "Beer-$3",
            "Tap Water-Non Charge"});
            this.BevaragecheckedListBox.Location = new System.Drawing.Point(3, 13);
            this.BevaragecheckedListBox.Name = "BevaragecheckedListBox";
            this.BevaragecheckedListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.BevaragecheckedListBox.Size = new System.Drawing.Size(140, 56);
            this.BevaragecheckedListBox.TabIndex = 8;
            this.BevaragecheckedListBox.SelectedIndexChanged += new System.EventHandler(this.Changed);
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(110, 307);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(133, 20);
            this.TotaltextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total:";
            // 
            // Sendbutton
            // 
            this.Sendbutton.Location = new System.Drawing.Point(297, 307);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(144, 45);
            this.Sendbutton.TabIndex = 3;
            this.Sendbutton.Text = "Send the Order";
            this.Sendbutton.UseVisualStyleBackColor = true;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // SendtabPage
            // 
            this.SendtabPage.Controls.Add(this.OutrichTextBox);
            this.SendtabPage.Location = new System.Drawing.Point(4, 22);
            this.SendtabPage.Name = "SendtabPage";
            this.SendtabPage.Size = new System.Drawing.Size(628, 257);
            this.SendtabPage.TabIndex = 4;
            this.SendtabPage.Text = "Send Info";
            this.SendtabPage.UseVisualStyleBackColor = true;
            // 
            // OutrichTextBox
            // 
            this.OutrichTextBox.Location = new System.Drawing.Point(13, 19);
            this.OutrichTextBox.Name = "OutrichTextBox";
            this.OutrichTextBox.Size = new System.Drawing.Size(203, 126);
            this.OutrichTextBox.TabIndex = 0;
            this.OutrichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.Sendbutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.DataInfotabPage.ResumeLayout(false);
            this.DataInfotabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TopicstabPage.ResumeLayout(false);
            this.TopicstabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.OtherProductstabPage.ResumeLayout(false);
            this.BevaragetabPage.ResumeLayout(false);
            this.SendtabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DataInfotabPage;
        private System.Windows.Forms.TabPage TopicstabPage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PhonetextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox AdresstextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.ComboBox FlavorcomboBox;
        private System.Windows.Forms.ComboBox SizecomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage OtherProductstabPage;
        private System.Windows.Forms.TabPage BevaragetabPage;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Sendbutton;
        private System.Windows.Forms.ListBox TopicscheckedListBox;
        private System.Windows.Forms.ListBox OthercheckedListBox;
        private System.Windows.Forms.ListBox BevaragecheckedListBox;
        private System.Windows.Forms.TabPage SendtabPage;
        private System.Windows.Forms.RichTextBox OutrichTextBox;
    }
}

