namespace MiPrimeraAplicacion
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
            this.IngresoMensual = new System.Windows.Forms.Label();
            this.Ingreso_Bruto = new System.Windows.Forms.TextBox();
            this.Impuesto = new System.Windows.Forms.Label();
            this.Impuesto_label = new System.Windows.Forms.Label();
            this.Ingreso_Neto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Boton_Calculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IngresoMensual
            // 
            this.IngresoMensual.AutoSize = true;
            this.IngresoMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresoMensual.Location = new System.Drawing.Point(94, 62);
            this.IngresoMensual.Name = "IngresoMensual";
            this.IngresoMensual.Size = new System.Drawing.Size(196, 20);
            this.IngresoMensual.TabIndex = 0;
            this.IngresoMensual.Text = "Datos de Ingreso Mensual";
            // 
            // Ingreso_Bruto
            // 
            this.Ingreso_Bruto.Location = new System.Drawing.Point(361, 62);
            this.Ingreso_Bruto.Name = "Ingreso_Bruto";
            this.Ingreso_Bruto.Size = new System.Drawing.Size(185, 20);
            this.Ingreso_Bruto.TabIndex = 1;
            // 
            // Impuesto
            // 
            this.Impuesto.AutoSize = true;
            this.Impuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Impuesto.Location = new System.Drawing.Point(365, 97);
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.Size = new System.Drawing.Size(45, 24);
            this.Impuesto.TabIndex = 2;
            this.Impuesto.Text = "12%";
            // 
            // Impuesto_label
            // 
            this.Impuesto_label.AutoSize = true;
            this.Impuesto_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Impuesto_label.Location = new System.Drawing.Point(94, 99);
            this.Impuesto_label.Name = "Impuesto_label";
            this.Impuesto_label.Size = new System.Drawing.Size(117, 20);
            this.Impuesto_label.TabIndex = 3;
            this.Impuesto_label.Text = "Valor Impuesto";
            // 
            // Ingreso_Neto
            // 
            this.Ingreso_Neto.Location = new System.Drawing.Point(361, 134);
            this.Ingreso_Neto.Name = "Ingreso_Neto";
            this.Ingreso_Neto.Size = new System.Drawing.Size(185, 20);
            this.Ingreso_Neto.TabIndex = 5;
            this.Ingreso_Neto.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingreso despues de impuesto";
            // 
            // Boton_Calculo
            // 
            this.Boton_Calculo.Location = new System.Drawing.Point(231, 222);
            this.Boton_Calculo.Name = "Boton_Calculo";
            this.Boton_Calculo.Size = new System.Drawing.Size(226, 65);
            this.Boton_Calculo.TabIndex = 6;
            this.Boton_Calculo.Text = "Calcular";
            this.Boton_Calculo.UseVisualStyleBackColor = true;
            this.Boton_Calculo.Click += new System.EventHandler(this.Boton_Calculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Boton_Calculo);
            this.Controls.Add(this.Ingreso_Neto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Impuesto_label);
            this.Controls.Add(this.Impuesto);
            this.Controls.Add(this.Ingreso_Bruto);
            this.Controls.Add(this.IngresoMensual);
            this.Name = "Form1";
            this.Text = "Mi Primera Aplicacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IngresoMensual;
        private System.Windows.Forms.TextBox Ingreso_Bruto;
        private System.Windows.Forms.Label Impuesto;
        private System.Windows.Forms.Label Impuesto_label;
        private System.Windows.Forms.TextBox Ingreso_Neto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Boton_Calculo;
    }
}

