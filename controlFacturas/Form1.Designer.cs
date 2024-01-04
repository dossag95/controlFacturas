namespace controlFacturas
{
    partial class frmFacturas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblFecha = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblMonto = new Label();
            txtUnidades = new TextBox();
            txtVendedor = new TextBox();
            txtNumFact = new TextBox();
            btnRegistrarItem = new Button();
            btnNuevaFact = new Button();
            lvRegistro = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lvEstadisticas = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            groupBox1 = new GroupBox();
            cboTipo = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 15);
            label1.TabIndex = 0;
            label1.Text = "CONTROL REGISTRO FACTURAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 24);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE VENDENDOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 42);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "FECHA";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BorderStyle = BorderStyle.FixedSingle;
            lblFecha.Location = new Point(342, 42);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(2, 17);
            lblFecha.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 26);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 4;
            label5.Text = "Nº FACTURA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(119, 26);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 5;
            label6.Text = "TIPO DE LICENCIA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 26);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 6;
            label7.Text = "UNIDADES";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 172);
            label8.Name = "label8";
            label8.Size = new Size(124, 15);
            label8.TabIndex = 7;
            label8.Text = "LISTADO DE REGISTRO";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 347);
            label9.Name = "label9";
            label9.Size = new Size(129, 15);
            label9.TabIndex = 8;
            label9.Text = "ESTADISTICA DE VENTA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(363, 299);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 9;
            label10.Text = "MONTO TOTAL";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BorderStyle = BorderStyle.FixedSingle;
            lblMonto.Location = new Point(454, 299);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(2, 17);
            lblMonto.TabIndex = 10;
            // 
            // txtUnidades
            // 
            txtUnidades.Location = new Point(256, 44);
            txtUnidades.Name = "txtUnidades";
            txtUnidades.Size = new Size(100, 23);
            txtUnidades.TabIndex = 11;
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(12, 42);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(165, 23);
            txtVendedor.TabIndex = 12;
            // 
            // txtNumFact
            // 
            txtNumFact.Location = new Point(7, 44);
            txtNumFact.Name = "txtNumFact";
            txtNumFact.Size = new Size(100, 23);
            txtNumFact.TabIndex = 13;
            // 
            // btnRegistrarItem
            // 
            btnRegistrarItem.Location = new Point(368, 61);
            btnRegistrarItem.Name = "btnRegistrarItem";
            btnRegistrarItem.Size = new Size(125, 23);
            btnRegistrarItem.TabIndex = 14;
            btnRegistrarItem.Text = "REGISTRAR ITEM";
            btnRegistrarItem.UseVisualStyleBackColor = true;
            btnRegistrarItem.Click += btnRegistrarItem_Click;
            // 
            // btnNuevaFact
            // 
            btnNuevaFact.Location = new Point(368, 22);
            btnNuevaFact.Name = "btnNuevaFact";
            btnNuevaFact.Size = new Size(125, 23);
            btnNuevaFact.TabIndex = 15;
            btnNuevaFact.Text = "OTRA FACTURA";
            btnNuevaFact.UseVisualStyleBackColor = true;
            btnNuevaFact.Click += btnNuevaFact_Click;
            // 
            // lvRegistro
            // 
            lvRegistro.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvRegistro.GridLines = true;
            lvRegistro.Location = new Point(8, 190);
            lvRegistro.Name = "lvRegistro";
            lvRegistro.Size = new Size(499, 97);
            lvRegistro.TabIndex = 16;
            lvRegistro.UseCompatibleStateImageBehavior = false;
            lvRegistro.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Num Fact";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo de licencia";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Unidades";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Subtotal";
            columnHeader4.Width = 100;
            // 
            // lvEstadisticas
            // 
            lvEstadisticas.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7 });
            lvEstadisticas.GridLines = true;
            lvEstadisticas.Location = new Point(8, 375);
            lvEstadisticas.Name = "lvEstadisticas";
            lvEstadisticas.Size = new Size(499, 97);
            lvEstadisticas.TabIndex = 17;
            lvEstadisticas.UseCompatibleStateImageBehavior = false;
            lvEstadisticas.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tipo de licencia";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Total unidades";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Monto total";
            columnHeader7.Width = 100;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboTipo);
            groupBox1.Controls.Add(btnNuevaFact);
            groupBox1.Controls.Add(btnRegistrarItem);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtUnidades);
            groupBox1.Controls.Add(txtNumFact);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(8, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 90);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "REGISTRO DE FACTURAS";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Cobre", "Bronce", "Silver", "Gold" });
            cboTipo.Location = new Point(119, 44);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 19;
            // 
            // frmFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 484);
            Controls.Add(groupBox1);
            Controls.Add(lvEstadisticas);
            Controls.Add(lvRegistro);
            Controls.Add(txtVendedor);
            Controls.Add(lblMonto);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lblFecha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmFacturas";
            Text = "Control de registro de facturas";
            Load += frmFacturas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblFecha;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblMonto;
        private TextBox txtUnidades;
        private TextBox txtVendedor;
        private TextBox txtNumFact;
        private Button btnRegistrarItem;
        private Button btnNuevaFact;
        private ListView lvRegistro;
        private ListView lvEstadisticas;
        private GroupBox groupBox1;
        private ComboBox cboTipo;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}
