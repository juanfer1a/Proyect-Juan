namespace ProjectFonal
{
    partial class frmCategorias
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
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreCategoria = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCrearCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombre.Location = new System.Drawing.Point(65, 67);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre\r\n";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCategoria.Depth = 0;
            this.txtNombreCategoria.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreCategoria.LeadingIcon = null;
            this.txtNombreCategoria.Location = new System.Drawing.Point(150, 37);
            this.txtNombreCategoria.MaxLength = 50;
            this.txtNombreCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreCategoria.Multiline = false;
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(116, 50);
            this.txtNombreCategoria.TabIndex = 1;
            this.txtNombreCategoria.Text = "";
            this.txtNombreCategoria.TrailingIcon = null;
            // 
            // btnCrearCategoria
            // 
            this.btnCrearCategoria.Location = new System.Drawing.Point(324, 45);
            this.btnCrearCategoria.Name = "btnCrearCategoria";
            this.btnCrearCategoria.Size = new System.Drawing.Size(90, 40);
            this.btnCrearCategoria.TabIndex = 2;
            this.btnCrearCategoria.Text = "Crear";
            this.btnCrearCategoria.UseVisualStyleBackColor = true;
            this.btnCrearCategoria.Click += new System.EventHandler(this.btnCrearCategoria_Click);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 171);
            this.Controls.Add(this.btnCrearCategoria);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmCategorias";
            this.Text = "frmCategorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialTextBox txtNombreCategoria;
        private System.Windows.Forms.Button btnCrearCategoria;
    }
}