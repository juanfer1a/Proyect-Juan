
namespace ProjectFonal
{
    partial class frmInventario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNombreInsumo = new System.Windows.Forms.TextBox();
            this.lblNombreInsumo = new System.Windows.Forms.Label();
            this.lblMarcaInsumo = new System.Windows.Forms.Label();
            this.lblPrecioInsumo = new System.Windows.Forms.Label();
            this.lblCantidadInsumo = new System.Windows.Forms.Label();
            this.txtCantidadInsumo = new System.Windows.Forms.TextBox();
            this.lblCrearInsumo = new System.Windows.Forms.Label();
            this.btnCrearInsumo = new System.Windows.Forms.Button();
            this.cxbCategoria = new MaterialSkin.Controls.MaterialComboBox();
            this.cxbProduct = new MaterialSkin.Controls.MaterialComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(361, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 378);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtNombreInsumo
            // 
            this.txtNombreInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreInsumo.Location = new System.Drawing.Point(133, 224);
            this.txtNombreInsumo.Name = "txtNombreInsumo";
            this.txtNombreInsumo.Size = new System.Drawing.Size(165, 21);
            this.txtNombreInsumo.TabIndex = 4;
            // 
            // lblNombreInsumo
            // 
            this.lblNombreInsumo.AutoSize = true;
            this.lblNombreInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInsumo.Location = new System.Drawing.Point(39, 227);
            this.lblNombreInsumo.Name = "lblNombreInsumo";
            this.lblNombreInsumo.Size = new System.Drawing.Size(58, 15);
            this.lblNombreInsumo.TabIndex = 6;
            this.lblNombreInsumo.Text = "Nombre";
            // 
            // lblMarcaInsumo
            // 
            this.lblMarcaInsumo.AutoSize = true;
            this.lblMarcaInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaInsumo.Location = new System.Drawing.Point(39, 110);
            this.lblMarcaInsumo.Name = "lblMarcaInsumo";
            this.lblMarcaInsumo.Size = new System.Drawing.Size(69, 15);
            this.lblMarcaInsumo.TabIndex = 9;
            this.lblMarcaInsumo.Text = "Categoria";
            // 
            // lblPrecioInsumo
            // 
            this.lblPrecioInsumo.AutoSize = true;
            this.lblPrecioInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioInsumo.Location = new System.Drawing.Point(39, 162);
            this.lblPrecioInsumo.Name = "lblPrecioInsumo";
            this.lblPrecioInsumo.Size = new System.Drawing.Size(64, 15);
            this.lblPrecioInsumo.TabIndex = 11;
            this.lblPrecioInsumo.Text = "Producto";
            // 
            // lblCantidadInsumo
            // 
            this.lblCantidadInsumo.AutoSize = true;
            this.lblCantidadInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadInsumo.Location = new System.Drawing.Point(39, 264);
            this.lblCantidadInsumo.Name = "lblCantidadInsumo";
            this.lblCantidadInsumo.Size = new System.Drawing.Size(64, 15);
            this.lblCantidadInsumo.TabIndex = 13;
            this.lblCantidadInsumo.Text = "Cantidad";
            // 
            // txtCantidadInsumo
            // 
            this.txtCantidadInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadInsumo.Location = new System.Drawing.Point(133, 264);
            this.txtCantidadInsumo.Name = "txtCantidadInsumo";
            this.txtCantidadInsumo.Size = new System.Drawing.Size(165, 21);
            this.txtCantidadInsumo.TabIndex = 12;
            // 
            // lblCrearInsumo
            // 
            this.lblCrearInsumo.AutoSize = true;
            this.lblCrearInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearInsumo.Location = new System.Drawing.Point(119, 53);
            this.lblCrearInsumo.Name = "lblCrearInsumo";
            this.lblCrearInsumo.Size = new System.Drawing.Size(124, 17);
            this.lblCrearInsumo.TabIndex = 16;
            this.lblCrearInsumo.Text = "Ingresar Insumo";
            // 
            // btnCrearInsumo
            // 
            this.btnCrearInsumo.Location = new System.Drawing.Point(47, 320);
            this.btnCrearInsumo.Name = "btnCrearInsumo";
            this.btnCrearInsumo.Size = new System.Drawing.Size(95, 29);
            this.btnCrearInsumo.TabIndex = 17;
            this.btnCrearInsumo.Text = "Agregar";
            this.btnCrearInsumo.UseVisualStyleBackColor = true;
            this.btnCrearInsumo.Click += new System.EventHandler(this.btnCrearInsumo_Click);
            // 
            // cxbCategoria
            // 
            this.cxbCategoria.AutoResize = false;
            this.cxbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cxbCategoria.Depth = 0;
            this.cxbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cxbCategoria.DropDownHeight = 174;
            this.cxbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cxbCategoria.DropDownWidth = 121;
            this.cxbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cxbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cxbCategoria.FormattingEnabled = true;
            this.cxbCategoria.IntegralHeight = false;
            this.cxbCategoria.ItemHeight = 43;
            this.cxbCategoria.Location = new System.Drawing.Point(133, 89);
            this.cxbCategoria.MaxDropDownItems = 4;
            this.cxbCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.cxbCategoria.Name = "cxbCategoria";
            this.cxbCategoria.Size = new System.Drawing.Size(166, 49);
            this.cxbCategoria.StartIndex = 0;
            this.cxbCategoria.TabIndex = 18;
            this.cxbCategoria.SelectedValueChanged += new System.EventHandler(this.cxbCategoria_SelectedValueChanged);
            // 
            // cxbProduct
            // 
            this.cxbProduct.AutoResize = false;
            this.cxbProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cxbProduct.Depth = 0;
            this.cxbProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cxbProduct.DropDownHeight = 174;
            this.cxbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cxbProduct.DropDownWidth = 121;
            this.cxbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cxbProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cxbProduct.FormattingEnabled = true;
            this.cxbProduct.IntegralHeight = false;
            this.cxbProduct.ItemHeight = 43;
            this.cxbProduct.Location = new System.Drawing.Point(133, 144);
            this.cxbProduct.MaxDropDownItems = 4;
            this.cxbProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.cxbProduct.Name = "cxbProduct";
            this.cxbProduct.Size = new System.Drawing.Size(166, 49);
            this.cxbProduct.StartIndex = 0;
            this.cxbProduct.TabIndex = 19;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.cxbProduct);
            this.Controls.Add(this.cxbCategoria);
            this.Controls.Add(this.btnCrearInsumo);
            this.Controls.Add(this.lblCrearInsumo);
            this.Controls.Add(this.lblCantidadInsumo);
            this.Controls.Add(this.txtCantidadInsumo);
            this.Controls.Add(this.lblPrecioInsumo);
            this.Controls.Add(this.lblMarcaInsumo);
            this.Controls.Add(this.lblNombreInsumo);
            this.Controls.Add(this.txtNombreInsumo);
            this.Controls.Add(this.panel1);
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInventario";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombreInsumo;
        private System.Windows.Forms.Label lblNombreInsumo;
        private System.Windows.Forms.Label lblMarcaInsumo;
        private System.Windows.Forms.Label lblPrecioInsumo;
        private System.Windows.Forms.Label lblCantidadInsumo;
        private System.Windows.Forms.TextBox txtCantidadInsumo;
        private System.Windows.Forms.Label lblCrearInsumo;
        private System.Windows.Forms.Button btnCrearInsumo;
        private MaterialSkin.Controls.MaterialComboBox cxbCategoria;
        private MaterialSkin.Controls.MaterialComboBox cxbProduct;
    }
}