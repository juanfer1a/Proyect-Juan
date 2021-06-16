
namespace ProjectFonal
{
    partial class frmUsuarios
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
            this.txtProveedor = new System.Windows.Forms.Button();
            this.btnRegresarMenu = new System.Windows.Forms.Button();
            this.txtEmpleado = new System.Windows.Forms.Button();
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(952, 91);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(100, 91);
            this.txtProveedor.TabIndex = 1;
            this.txtProveedor.Text = "Proveedor";
            this.txtProveedor.UseVisualStyleBackColor = true;
            this.txtProveedor.Click += new System.EventHandler(this.txtProveedor_Click);
            // 
            // btnRegresarMenu
            // 
            this.btnRegresarMenu.Location = new System.Drawing.Point(952, 302);
            this.btnRegresarMenu.Name = "btnRegresarMenu";
            this.btnRegresarMenu.Size = new System.Drawing.Size(100, 87);
            this.btnRegresarMenu.TabIndex = 2;
            this.btnRegresarMenu.Text = "Menú";
            this.btnRegresarMenu.UseVisualStyleBackColor = true;
            this.btnRegresarMenu.Click += new System.EventHandler(this.btnRegresarMenu_Click);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(952, 188);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(100, 93);
            this.txtEmpleado.TabIndex = 3;
            this.txtEmpleado.Text = "Empleado";
            this.txtEmpleado.UseVisualStyleBackColor = true;
            this.txtEmpleado.Click += new System.EventHandler(this.txtEmpleado_Click);
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.Location = new System.Drawing.Point(12, 31);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(915, 578);
            this.pnlUsuarios.TabIndex = 4;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btnRegresarMenu);
            this.Controls.Add(this.pnlUsuarios);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtProveedor);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button txtProveedor;
        private System.Windows.Forms.Button btnRegresarMenu;
        private System.Windows.Forms.Button txtEmpleado;
        private System.Windows.Forms.Panel pnlUsuarios;
    }
}