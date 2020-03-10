namespace Semana02
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboAnios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.dgDetalle = new System.Windows.Forms.DataGridView();
            this.txtMonDetalle = new System.Windows.Forms.TextBox();
            this.txtNumPedidos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar el año del pedido";
            // 
            // cboAnios
            // 
            this.cboAnios.FormattingEnabled = true;
            this.cboAnios.Location = new System.Drawing.Point(412, 27);
            this.cboAnios.Name = "cboAnios";
            this.cboAnios.Size = new System.Drawing.Size(121, 21);
            this.cboAnios.TabIndex = 1;
            this.cboAnios.SelectionChangeCommitted += new System.EventHandler(this.cboAnios_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista de pedidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nro. de pedidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lista de detalle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Monto del detalle";
            // 
            // dgPedidos
            // 
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Location = new System.Drawing.Point(37, 87);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.Size = new System.Drawing.Size(705, 133);
            this.dgPedidos.TabIndex = 6;
            this.dgPedidos.DoubleClick += new System.EventHandler(this.dgPedidos_DoubleClick);
            // 
            // dgDetalle
            // 
            this.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalle.Location = new System.Drawing.Point(37, 288);
            this.dgDetalle.Name = "dgDetalle";
            this.dgDetalle.Size = new System.Drawing.Size(705, 160);
            this.dgDetalle.TabIndex = 7;
            // 
            // txtMonDetalle
            // 
            this.txtMonDetalle.Location = new System.Drawing.Point(642, 458);
            this.txtMonDetalle.Name = "txtMonDetalle";
            this.txtMonDetalle.Size = new System.Drawing.Size(100, 20);
            this.txtMonDetalle.TabIndex = 8;
            // 
            // txtNumPedidos
            // 
            this.txtNumPedidos.Location = new System.Drawing.Point(642, 229);
            this.txtNumPedidos.Name = "txtNumPedidos";
            this.txtNumPedidos.Size = new System.Drawing.Size(100, 20);
            this.txtNumPedidos.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 501);
            this.Controls.Add(this.txtNumPedidos);
            this.Controls.Add(this.txtMonDetalle);
            this.Controls.Add(this.dgDetalle);
            this.Controls.Add(this.dgPedidos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboAnios);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAnios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.DataGridView dgDetalle;
        private System.Windows.Forms.TextBox txtMonDetalle;
        private System.Windows.Forms.TextBox txtNumPedidos;
    }
}

