namespace ProjectFonal
{
    partial class frmReportes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGBalance = new System.Windows.Forms.Button();
            this.btnHMovimientos = new System.Windows.Forms.Button();
            this.btnReporVentas = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pnlVentas = new System.Windows.Forms.Panel();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lbLDesde = new System.Windows.Forms.Label();
            this.datPHastaVentas = new System.Windows.Forms.DateTimePicker();
            this.datPDesdeVentas = new System.Windows.Forms.DateTimePicker();
            this.lblReporVentas = new System.Windows.Forms.Label();
            this.btnCerrarVenta = new System.Windows.Forms.Button();
            this.btnGenerarReporVentas = new System.Windows.Forms.Button();
            this.lblPruebas = new System.Windows.Forms.Label();
            this.lblPruebaHasta = new System.Windows.Forms.Label();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.lblHastaBalance = new System.Windows.Forms.Label();
            this.lblDesdeBalance = new System.Windows.Forms.Label();
            this.datPHastaBalance = new System.Windows.Forms.DateTimePicker();
            this.datPDesdeBalance = new System.Windows.Forms.DateTimePicker();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnCerrarBalance = new System.Windows.Forms.Button();
            this.btnGenerarBalance = new System.Windows.Forms.Button();
            this.pnlMovimientos = new System.Windows.Forms.Panel();
            this.lblHastaMovimientos = new System.Windows.Forms.Label();
            this.lblDesdeMovimientos = new System.Windows.Forms.Label();
            this.datPHastaMovimientos = new System.Windows.Forms.DateTimePicker();
            this.datPDesdeMovimientos = new System.Windows.Forms.DateTimePicker();
            this.lblReporteVentas = new System.Windows.Forms.Label();
            this.btnCerrarMove = new System.Windows.Forms.Button();
            this.btnGenerarReporMovi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlVentas.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.pnlMovimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(705, 396);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(83, 42);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "&Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 423);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnGBalance
            // 
            this.btnGBalance.Location = new System.Drawing.Point(705, 137);
            this.btnGBalance.Name = "btnGBalance";
            this.btnGBalance.Size = new System.Drawing.Size(83, 42);
            this.btnGBalance.TabIndex = 3;
            this.btnGBalance.Text = "&Generar balance";
            this.btnGBalance.UseVisualStyleBackColor = true;
            this.btnGBalance.Click += new System.EventHandler(this.btnGBalance_Click);
            // 
            // btnHMovimientos
            // 
            this.btnHMovimientos.Location = new System.Drawing.Point(705, 12);
            this.btnHMovimientos.Name = "btnHMovimientos";
            this.btnHMovimientos.Size = new System.Drawing.Size(83, 42);
            this.btnHMovimientos.TabIndex = 5;
            this.btnHMovimientos.Text = "&Historial Movimientos";
            this.btnHMovimientos.UseVisualStyleBackColor = true;
            this.btnHMovimientos.Click += new System.EventHandler(this.btnHMovimientos_Click);
            // 
            // btnReporVentas
            // 
            this.btnReporVentas.Location = new System.Drawing.Point(705, 69);
            this.btnReporVentas.Name = "btnReporVentas";
            this.btnReporVentas.Size = new System.Drawing.Size(83, 42);
            this.btnReporVentas.TabIndex = 6;
            this.btnReporVentas.Text = "Reporte &Ventas";
            this.btnReporVentas.UseVisualStyleBackColor = true;
            this.btnReporVentas.Click += new System.EventHandler(this.btnReporVentas_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(578, 396);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(83, 42);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // pnlVentas
            // 
            this.pnlVentas.Controls.Add(this.lblHasta);
            this.pnlVentas.Controls.Add(this.lbLDesde);
            this.pnlVentas.Controls.Add(this.datPHastaVentas);
            this.pnlVentas.Controls.Add(this.datPDesdeVentas);
            this.pnlVentas.Controls.Add(this.lblReporVentas);
            this.pnlVentas.Controls.Add(this.btnCerrarVenta);
            this.pnlVentas.Controls.Add(this.btnGenerarReporVentas);
            this.pnlVentas.Location = new System.Drawing.Point(92, 12);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(396, 166);
            this.pnlVentas.TabIndex = 8;
            this.pnlVentas.Visible = false;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(22, 104);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(44, 15);
            this.lblHasta.TabIndex = 7;
            this.lblHasta.Text = "Hasta";
            // 
            // lbLDesde
            // 
            this.lbLDesde.AutoSize = true;
            this.lbLDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLDesde.Location = new System.Drawing.Point(22, 43);
            this.lbLDesde.Name = "lbLDesde";
            this.lbLDesde.Size = new System.Drawing.Size(48, 15);
            this.lbLDesde.TabIndex = 6;
            this.lbLDesde.Text = "Desde";
            // 
            // datPHastaVentas
            // 
            this.datPHastaVentas.Location = new System.Drawing.Point(25, 127);
            this.datPHastaVentas.Name = "datPHastaVentas";
            this.datPHastaVentas.Size = new System.Drawing.Size(151, 20);
            this.datPHastaVentas.TabIndex = 5;
            this.datPHastaVentas.Value = new System.DateTime(2021, 5, 28, 0, 0, 0, 0);
            // 
            // datPDesdeVentas
            // 
            this.datPDesdeVentas.Location = new System.Drawing.Point(25, 65);
            this.datPDesdeVentas.Name = "datPDesdeVentas";
            this.datPDesdeVentas.Size = new System.Drawing.Size(151, 20);
            this.datPDesdeVentas.TabIndex = 4;
            this.datPDesdeVentas.Value = new System.DateTime(2021, 5, 28, 0, 0, 0, 0);
            // 
            // lblReporVentas
            // 
            this.lblReporVentas.AutoSize = true;
            this.lblReporVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporVentas.Location = new System.Drawing.Point(55, 11);
            this.lblReporVentas.Name = "lblReporVentas";
            this.lblReporVentas.Size = new System.Drawing.Size(105, 15);
            this.lblReporVentas.TabIndex = 3;
            this.lblReporVentas.Text = "Reporte Ventas";
            // 
            // btnCerrarVenta
            // 
            this.btnCerrarVenta.Location = new System.Drawing.Point(272, 118);
            this.btnCerrarVenta.Name = "btnCerrarVenta";
            this.btnCerrarVenta.Size = new System.Drawing.Size(64, 28);
            this.btnCerrarVenta.TabIndex = 1;
            this.btnCerrarVenta.Text = "Cerrar";
            this.btnCerrarVenta.UseVisualStyleBackColor = true;
            this.btnCerrarVenta.Click += new System.EventHandler(this.btnCerrarVenta_Click);
            // 
            // btnGenerarReporVentas
            // 
            this.btnGenerarReporVentas.Location = new System.Drawing.Point(272, 57);
            this.btnGenerarReporVentas.Name = "btnGenerarReporVentas";
            this.btnGenerarReporVentas.Size = new System.Drawing.Size(64, 28);
            this.btnGenerarReporVentas.TabIndex = 0;
            this.btnGenerarReporVentas.Text = "Generar";
            this.btnGenerarReporVentas.UseVisualStyleBackColor = true;
            this.btnGenerarReporVentas.Click += new System.EventHandler(this.btnGenerarReporVentas_Click);
            // 
            // lblPruebas
            // 
            this.lblPruebas.AutoSize = true;
            this.lblPruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPruebas.Location = new System.Drawing.Point(575, 318);
            this.lblPruebas.Name = "lblPruebas";
            this.lblPruebas.Size = new System.Drawing.Size(46, 17);
            this.lblPruebas.TabIndex = 11;
            this.lblPruebas.Text = "label4";
            // 
            // lblPruebaHasta
            // 
            this.lblPruebaHasta.AutoSize = true;
            this.lblPruebaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPruebaHasta.Location = new System.Drawing.Point(575, 345);
            this.lblPruebaHasta.Name = "lblPruebaHasta";
            this.lblPruebaHasta.Size = new System.Drawing.Size(46, 17);
            this.lblPruebaHasta.TabIndex = 12;
            this.lblPruebaHasta.Text = "label4";
            // 
            // pnlBalance
            // 
            this.pnlBalance.Controls.Add(this.lblHastaBalance);
            this.pnlBalance.Controls.Add(this.lblDesdeBalance);
            this.pnlBalance.Controls.Add(this.datPHastaBalance);
            this.pnlBalance.Controls.Add(this.datPDesdeBalance);
            this.pnlBalance.Controls.Add(this.lblBalance);
            this.pnlBalance.Controls.Add(this.btnCerrarBalance);
            this.pnlBalance.Controls.Add(this.btnGenerarBalance);
            this.pnlBalance.Location = new System.Drawing.Point(92, 184);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(396, 166);
            this.pnlBalance.TabIndex = 9;
            this.pnlBalance.Visible = false;
            // 
            // lblHastaBalance
            // 
            this.lblHastaBalance.AutoSize = true;
            this.lblHastaBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaBalance.Location = new System.Drawing.Point(22, 104);
            this.lblHastaBalance.Name = "lblHastaBalance";
            this.lblHastaBalance.Size = new System.Drawing.Size(44, 15);
            this.lblHastaBalance.TabIndex = 7;
            this.lblHastaBalance.Text = "Hasta";
            // 
            // lblDesdeBalance
            // 
            this.lblDesdeBalance.AutoSize = true;
            this.lblDesdeBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesdeBalance.Location = new System.Drawing.Point(22, 43);
            this.lblDesdeBalance.Name = "lblDesdeBalance";
            this.lblDesdeBalance.Size = new System.Drawing.Size(48, 15);
            this.lblDesdeBalance.TabIndex = 6;
            this.lblDesdeBalance.Text = "Desde";
            // 
            // datPHastaBalance
            // 
            this.datPHastaBalance.Location = new System.Drawing.Point(25, 127);
            this.datPHastaBalance.Name = "datPHastaBalance";
            this.datPHastaBalance.Size = new System.Drawing.Size(151, 20);
            this.datPHastaBalance.TabIndex = 5;
            this.datPHastaBalance.Value = new System.DateTime(2021, 5, 28, 0, 0, 0, 0);
            // 
            // datPDesdeBalance
            // 
            this.datPDesdeBalance.Location = new System.Drawing.Point(25, 65);
            this.datPDesdeBalance.Name = "datPDesdeBalance";
            this.datPDesdeBalance.Size = new System.Drawing.Size(151, 20);
            this.datPDesdeBalance.TabIndex = 4;
            this.datPDesdeBalance.Value = new System.DateTime(2021, 5, 28, 0, 0, 0, 0);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(55, 11);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(59, 15);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "Balance";
            // 
            // btnCerrarBalance
            // 
            this.btnCerrarBalance.Location = new System.Drawing.Point(272, 118);
            this.btnCerrarBalance.Name = "btnCerrarBalance";
            this.btnCerrarBalance.Size = new System.Drawing.Size(64, 28);
            this.btnCerrarBalance.TabIndex = 1;
            this.btnCerrarBalance.Text = "Cerrar";
            this.btnCerrarBalance.UseVisualStyleBackColor = true;
            this.btnCerrarBalance.Click += new System.EventHandler(this.btnCerrarBalance_Click);
            // 
            // btnGenerarBalance
            // 
            this.btnGenerarBalance.Location = new System.Drawing.Point(272, 57);
            this.btnGenerarBalance.Name = "btnGenerarBalance";
            this.btnGenerarBalance.Size = new System.Drawing.Size(64, 28);
            this.btnGenerarBalance.TabIndex = 0;
            this.btnGenerarBalance.Text = "Generar";
            this.btnGenerarBalance.UseVisualStyleBackColor = true;
            this.btnGenerarBalance.Click += new System.EventHandler(this.btnGenerarBalance_Click);
            // 
            // pnlMovimientos
            // 
            this.pnlMovimientos.Controls.Add(this.lblHastaMovimientos);
            this.pnlMovimientos.Controls.Add(this.lblDesdeMovimientos);
            this.pnlMovimientos.Controls.Add(this.datPHastaMovimientos);
            this.pnlMovimientos.Controls.Add(this.datPDesdeMovimientos);
            this.pnlMovimientos.Controls.Add(this.lblReporteVentas);
            this.pnlMovimientos.Controls.Add(this.btnCerrarMove);
            this.pnlMovimientos.Controls.Add(this.btnGenerarReporMovi);
            this.pnlMovimientos.Location = new System.Drawing.Point(92, 356);
            this.pnlMovimientos.Name = "pnlMovimientos";
            this.pnlMovimientos.Size = new System.Drawing.Size(396, 166);
            this.pnlMovimientos.TabIndex = 9;
            this.pnlMovimientos.Visible = false;
            // 
            // lblHastaMovimientos
            // 
            this.lblHastaMovimientos.AutoSize = true;
            this.lblHastaMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaMovimientos.Location = new System.Drawing.Point(22, 104);
            this.lblHastaMovimientos.Name = "lblHastaMovimientos";
            this.lblHastaMovimientos.Size = new System.Drawing.Size(44, 15);
            this.lblHastaMovimientos.TabIndex = 7;
            this.lblHastaMovimientos.Text = "Hasta";
            // 
            // lblDesdeMovimientos
            // 
            this.lblDesdeMovimientos.AutoSize = true;
            this.lblDesdeMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesdeMovimientos.Location = new System.Drawing.Point(22, 43);
            this.lblDesdeMovimientos.Name = "lblDesdeMovimientos";
            this.lblDesdeMovimientos.Size = new System.Drawing.Size(48, 15);
            this.lblDesdeMovimientos.TabIndex = 6;
            this.lblDesdeMovimientos.Text = "Desde";
            // 
            // datPHastaMovimientos
            // 
            this.datPHastaMovimientos.Location = new System.Drawing.Point(25, 127);
            this.datPHastaMovimientos.Name = "datPHastaMovimientos";
            this.datPHastaMovimientos.Size = new System.Drawing.Size(151, 20);
            this.datPHastaMovimientos.TabIndex = 5;
            this.datPHastaMovimientos.Value = new System.DateTime(2021, 5, 28, 0, 0, 0, 0);
            // 
            // datPDesdeMovimientos
            // 
            this.datPDesdeMovimientos.Location = new System.Drawing.Point(25, 65);
            this.datPDesdeMovimientos.Name = "datPDesdeMovimientos";
            this.datPDesdeMovimientos.Size = new System.Drawing.Size(151, 20);
            this.datPDesdeMovimientos.TabIndex = 4;
            this.datPDesdeMovimientos.Value = new System.DateTime(2021, 5, 28, 0, 0, 0, 0);
            // 
            // lblReporteVentas
            // 
            this.lblReporteVentas.AutoSize = true;
            this.lblReporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporteVentas.Location = new System.Drawing.Point(55, 11);
            this.lblReporteVentas.Name = "lblReporteVentas";
            this.lblReporteVentas.Size = new System.Drawing.Size(143, 15);
            this.lblReporteVentas.TabIndex = 3;
            this.lblReporteVentas.Text = "Reporte Movimientos";
            // 
            // btnCerrarMove
            // 
            this.btnCerrarMove.Location = new System.Drawing.Point(272, 118);
            this.btnCerrarMove.Name = "btnCerrarMove";
            this.btnCerrarMove.Size = new System.Drawing.Size(64, 28);
            this.btnCerrarMove.TabIndex = 1;
            this.btnCerrarMove.Text = "Cerrar";
            this.btnCerrarMove.UseVisualStyleBackColor = true;
            this.btnCerrarMove.Click += new System.EventHandler(this.btnCerrarMove_Click);
            // 
            // btnGenerarReporMovi
            // 
            this.btnGenerarReporMovi.Location = new System.Drawing.Point(272, 57);
            this.btnGenerarReporMovi.Name = "btnGenerarReporMovi";
            this.btnGenerarReporMovi.Size = new System.Drawing.Size(64, 28);
            this.btnGenerarReporMovi.TabIndex = 0;
            this.btnGenerarReporMovi.Text = "Generar";
            this.btnGenerarReporMovi.UseVisualStyleBackColor = true;
            this.btnGenerarReporMovi.Click += new System.EventHandler(this.btnGenerarReporMovi_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.pnlMovimientos);
            this.Controls.Add(this.pnlBalance);
            this.Controls.Add(this.lblPruebaHasta);
            this.Controls.Add(this.lblPruebas);
            this.Controls.Add(this.pnlVentas);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnReporVentas);
            this.Controls.Add(this.btnHMovimientos);
            this.Controls.Add(this.btnGBalance);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMenu);
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlVentas.ResumeLayout(false);
            this.pnlVentas.PerformLayout();
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            this.pnlMovimientos.ResumeLayout(false);
            this.pnlMovimientos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGBalance;
        private System.Windows.Forms.Button btnReporFinan;
        private System.Windows.Forms.Button btnHMovimientos;
        private System.Windows.Forms.Button btnReporVentas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel pnlVentas;
        private System.Windows.Forms.Button btnCerrarVenta;
        private System.Windows.Forms.Button btnGenerarReporVentas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblReporVentas;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lbLDesde;
        private System.Windows.Forms.DateTimePicker datPHastaVentas;
        private System.Windows.Forms.DateTimePicker datPDesdeVentas;
        private System.Windows.Forms.Label lblPruebas;
        private System.Windows.Forms.Label lblPruebaHasta;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Label lblHastaBalance;
        private System.Windows.Forms.Label lblDesdeBalance;
        private System.Windows.Forms.DateTimePicker datPHastaBalance;
        private System.Windows.Forms.DateTimePicker datPDesdeBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnCerrarBalance;
        private System.Windows.Forms.Button btnGenerarBalance;
        private System.Windows.Forms.Panel pnlMovimientos;
        private System.Windows.Forms.Label lblHastaMovimientos;
        private System.Windows.Forms.Label lblDesdeMovimientos;
        private System.Windows.Forms.DateTimePicker datPHastaMovimientos;
        private System.Windows.Forms.DateTimePicker datPDesdeMovimientos;
        private System.Windows.Forms.Label lblReporteVentas;
        private System.Windows.Forms.Button btnCerrarMove;
        private System.Windows.Forms.Button btnGenerarReporMovi;
    }
}