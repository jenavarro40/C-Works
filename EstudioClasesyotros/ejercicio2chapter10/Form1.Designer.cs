namespace ejercicio2chapter10
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
            this.MenuAplication = new System.Windows.Forms.MenuStrip();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.placeAnOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PedidotabControl = new System.Windows.Forms.TabControl();
            this.OrdertabPage = new System.Windows.Forms.TabPage();
            this.QuantitytextBox = new System.Windows.Forms.TextBox();
            this.Quantitylabel = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.ChooseSizes = new System.Windows.Forms.CheckedListBox();
            this.ShowtabPage = new System.Windows.Forms.TabPage();
            this.Orderlabel = new System.Windows.Forms.Label();
            this.MenuAplication.SuspendLayout();
            this.PedidotabControl.SuspendLayout();
            this.OrdertabPage.SuspendLayout();
            this.ShowtabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuAplication
            // 
            this.MenuAplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processToolStripMenuItem});
            this.MenuAplication.Location = new System.Drawing.Point(0, 0);
            this.MenuAplication.Name = "MenuAplication";
            this.MenuAplication.Size = new System.Drawing.Size(800, 24);
            this.MenuAplication.TabIndex = 0;
            this.MenuAplication.Text = "menuStrip1";
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.placeAnOrderToolStripMenuItem,
            this.displayOrderToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.addToCarToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // placeAnOrderToolStripMenuItem
            // 
            this.placeAnOrderToolStripMenuItem.Name = "placeAnOrderToolStripMenuItem";
            this.placeAnOrderToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.placeAnOrderToolStripMenuItem.Text = "Place an Order";
            this.placeAnOrderToolStripMenuItem.Click += new System.EventHandler(this.placeAnOrderToolStripMenuItem_Click);
            // 
            // displayOrderToolStripMenuItem
            // 
            this.displayOrderToolStripMenuItem.Name = "displayOrderToolStripMenuItem";
            this.displayOrderToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.displayOrderToolStripMenuItem.Text = "Display Order";
            this.displayOrderToolStripMenuItem.Click += new System.EventHandler(this.displayOrderToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addToCarToolStripMenuItem
            // 
            this.addToCarToolStripMenuItem.Name = "addToCarToolStripMenuItem";
            this.addToCarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addToCarToolStripMenuItem.Text = "Add to Car";
            this.addToCarToolStripMenuItem.Click += new System.EventHandler(this.addToCarToolStripMenuItem_Click);
            // 
            // PedidotabControl
            // 
            this.PedidotabControl.Controls.Add(this.OrdertabPage);
            this.PedidotabControl.Controls.Add(this.ShowtabPage);
            this.PedidotabControl.Location = new System.Drawing.Point(24, 27);
            this.PedidotabControl.Name = "PedidotabControl";
            this.PedidotabControl.SelectedIndex = 0;
            this.PedidotabControl.Size = new System.Drawing.Size(776, 411);
            this.PedidotabControl.TabIndex = 5;
            // 
            // OrdertabPage
            // 
            this.OrdertabPage.Controls.Add(this.QuantitytextBox);
            this.OrdertabPage.Controls.Add(this.Quantitylabel);
            this.OrdertabPage.Controls.Add(this.labelSize);
            this.OrdertabPage.Controls.Add(this.ChooseSizes);
            this.OrdertabPage.Location = new System.Drawing.Point(4, 22);
            this.OrdertabPage.Name = "OrdertabPage";
            this.OrdertabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdertabPage.Size = new System.Drawing.Size(768, 385);
            this.OrdertabPage.TabIndex = 0;
            this.OrdertabPage.Text = "Order";
            this.OrdertabPage.UseVisualStyleBackColor = true;
            this.OrdertabPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // QuantitytextBox
            // 
            this.QuantitytextBox.Location = new System.Drawing.Point(6, 162);
            this.QuantitytextBox.Name = "QuantitytextBox";
            this.QuantitytextBox.Size = new System.Drawing.Size(43, 20);
            this.QuantitytextBox.TabIndex = 8;
            this.QuantitytextBox.Visible = false;
            // 
            // Quantitylabel
            // 
            this.Quantitylabel.AutoSize = true;
            this.Quantitylabel.Location = new System.Drawing.Point(3, 136);
            this.Quantitylabel.Name = "Quantitylabel";
            this.Quantitylabel.Size = new System.Drawing.Size(172, 13);
            this.Quantitylabel.TabIndex = 7;
            this.Quantitylabel.Text = "Quantity(Max 10  Pieces per Order)";
            this.Quantitylabel.Visible = false;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(3, 13);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(30, 13);
            this.labelSize.TabIndex = 6;
            this.labelSize.Text = "Sise:";
            this.labelSize.Visible = false;
            // 
            // ChooseSizes
            // 
            this.ChooseSizes.FormattingEnabled = true;
            this.ChooseSizes.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.ChooseSizes.Location = new System.Drawing.Point(6, 29);
            this.ChooseSizes.Name = "ChooseSizes";
            this.ChooseSizes.Size = new System.Drawing.Size(120, 94);
            this.ChooseSizes.TabIndex = 5;
            this.ChooseSizes.Visible = false;
            // 
            // ShowtabPage
            // 
            this.ShowtabPage.Controls.Add(this.Orderlabel);
            this.ShowtabPage.Location = new System.Drawing.Point(4, 22);
            this.ShowtabPage.Name = "ShowtabPage";
            this.ShowtabPage.Size = new System.Drawing.Size(768, 385);
            this.ShowtabPage.TabIndex = 1;
            this.ShowtabPage.Text = "OrderSend";
            this.ShowtabPage.UseVisualStyleBackColor = true;
            // 
            // Orderlabel
            // 
            this.Orderlabel.AutoSize = true;
            this.Orderlabel.Location = new System.Drawing.Point(12, 13);
            this.Orderlabel.Name = "Orderlabel";
            this.Orderlabel.Size = new System.Drawing.Size(33, 13);
            this.Orderlabel.TabIndex = 0;
            this.Orderlabel.Text = "Order";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuAplication);
            this.Controls.Add(this.PedidotabControl);
            this.MainMenuStrip = this.MenuAplication;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuAplication.ResumeLayout(false);
            this.MenuAplication.PerformLayout();
            this.PedidotabControl.ResumeLayout(false);
            this.OrdertabPage.ResumeLayout(false);
            this.OrdertabPage.PerformLayout();
            this.ShowtabPage.ResumeLayout(false);
            this.ShowtabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuAplication;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem displayOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeAnOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TabControl PedidotabControl;
        private System.Windows.Forms.TabPage OrdertabPage;
        private System.Windows.Forms.TextBox QuantitytextBox;
        private System.Windows.Forms.Label Quantitylabel;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.CheckedListBox ChooseSizes;
        private System.Windows.Forms.TabPage ShowtabPage;
        private System.Windows.Forms.Label Orderlabel;
        private System.Windows.Forms.ToolStripMenuItem addToCarToolStripMenuItem;
    }
}

