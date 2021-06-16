
namespace ProjectFonal
{
    partial class frmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.pnlVentas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(897, 471);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(105, 103);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.Location = new System.Drawing.Point(897, 49);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(105, 103);
            this.btnRealizarVenta.TabIndex = 1;
            this.btnRealizarVenta.Text = "Venta";
            this.btnRealizarVenta.UseVisualStyleBackColor = true;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(897, 203);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(105, 103);
            this.btnFactura.TabIndex = 2;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // pnlVentas
            // 
            this.pnlVentas.Location = new System.Drawing.Point(44, 52);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(818, 563);
            this.pnlVentas.TabIndex = 3;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.pnlVentas);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnRealizarVenta);
            this.Controls.Add(this.btnMenu);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Panel pnlVentas;
    }
}