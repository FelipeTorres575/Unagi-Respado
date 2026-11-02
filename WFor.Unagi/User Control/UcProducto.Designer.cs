namespace WFor.Unagi
{
    partial class UcProducto
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            PagAnteriorButton = new Button();
            PagSigienteButton = new Button();
            AgregarButton = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            DgvProducto = new DataGridView();
            ColIdProducto = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColTipo = new DataGridViewTextBoxColumn();
            ColMarca = new DataGridViewTextBoxColumn();
            ColDescripcion = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            ColEditar = new DataGridViewButtonColumn();
            ColBorrar = new DataGridViewButtonColumn();
            panel5 = new Panel();
            LPanelAE = new Panel();
            NUDStock = new NumericUpDown();
            NUDPrecio = new NumericUpDown();
            CbxMarca = new ComboBox();
            CbxTipo2 = new ComboBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            TxtDescripcion = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            TxtNombre = new TextBox();
            label3 = new Label();
            CancelarButton = new Button();
            GuardarButton = new Button();
            panel3 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            CbxTipo = new ComboBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvProducto).BeginInit();
            panel5.SuspendLayout();
            LPanelAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDPrecio).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(PagAnteriorButton);
            panel2.Controls.Add(PagSigienteButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 399);
            panel2.Name = "panel2";
            panel2.Size = new Size(861, 60);
            panel2.TabIndex = 1;
            // 
            // PagAnteriorButton
            // 
            PagAnteriorButton.Dock = DockStyle.Left;
            PagAnteriorButton.Image = Properties.Resources.arrow_pointing_left_20px;
            PagAnteriorButton.Location = new Point(0, 0);
            PagAnteriorButton.Name = "PagAnteriorButton";
            PagAnteriorButton.Size = new Size(59, 60);
            PagAnteriorButton.TabIndex = 2;
            PagAnteriorButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            PagAnteriorButton.UseVisualStyleBackColor = true;
            // 
            // PagSigienteButton
            // 
            PagSigienteButton.Dock = DockStyle.Right;
            PagSigienteButton.Image = Properties.Resources.arrow_20px;
            PagSigienteButton.Location = new Point(802, 0);
            PagSigienteButton.Name = "PagSigienteButton";
            PagSigienteButton.Size = new Size(59, 60);
            PagSigienteButton.TabIndex = 1;
            PagSigienteButton.UseVisualStyleBackColor = true;
            // 
            // AgregarButton
            // 
            AgregarButton.Location = new Point(722, 11);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(70, 51);
            AgregarButton.TabIndex = 3;
            AgregarButton.Text = "Agregar";
            AgregarButton.UseVisualStyleBackColor = true;
            AgregarButton.Click += AgregarButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(AgregarButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 68);
            panel1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(331, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Buscar";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(63, 68);
            panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Unagi_icono_transparente;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(69, 13);
            label1.Name = "label1";
            label1.Size = new Size(223, 37);
            label1.TabIndex = 0;
            label1.Text = "Lista de Producto";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DgvProducto
            // 
            DgvProducto.AllowUserToAddRows = false;
            DgvProducto.AllowUserToDeleteRows = false;
            DgvProducto.AllowUserToOrderColumns = true;
            DgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProducto.Columns.AddRange(new DataGridViewColumn[] { ColIdProducto, ColNombre, ColTipo, ColMarca, ColDescripcion, ColPrecio, ColStock, ColEditar, ColBorrar });
            DgvProducto.Dock = DockStyle.Fill;
            DgvProducto.Location = new Point(0, 0);
            DgvProducto.Name = "DgvProducto";
            DgvProducto.ReadOnly = true;
            DgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProducto.Size = new Size(861, 331);
            DgvProducto.TabIndex = 2;
            DgvProducto.CellContentClick += DgvProducto_CellContentClick;
            // 
            // ColIdProducto
            // 
            ColIdProducto.HeaderText = "ID";
            ColIdProducto.Name = "ColIdProducto";
            ColIdProducto.ReadOnly = true;
            ColIdProducto.Visible = false;
            // 
            // ColNombre
            // 
            ColNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            ColNombre.Width = 76;
            // 
            // ColTipo
            // 
            ColTipo.HeaderText = "Tipo";
            ColTipo.Name = "ColTipo";
            ColTipo.ReadOnly = true;
            // 
            // ColMarca
            // 
            ColMarca.HeaderText = "Marca";
            ColMarca.Name = "ColMarca";
            ColMarca.ReadOnly = true;
            // 
            // ColDescripcion
            // 
            ColDescripcion.HeaderText = "Descripcion";
            ColDescripcion.Name = "ColDescripcion";
            ColDescripcion.ReadOnly = true;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            // 
            // ColStock
            // 
            ColStock.HeaderText = "Stock";
            ColStock.Name = "ColStock";
            ColStock.ReadOnly = true;
            // 
            // ColEditar
            // 
            ColEditar.HeaderText = "Editar";
            ColEditar.Name = "ColEditar";
            ColEditar.ReadOnly = true;
            // 
            // ColBorrar
            // 
            ColBorrar.HeaderText = "Borrar";
            ColBorrar.Name = "ColBorrar";
            ColBorrar.ReadOnly = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(LPanelAE);
            panel5.Controls.Add(DgvProducto);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 68);
            panel5.Name = "panel5";
            panel5.Size = new Size(861, 331);
            panel5.TabIndex = 10;
            // 
            // LPanelAE
            // 
            LPanelAE.Controls.Add(CbxTipo);
            LPanelAE.Controls.Add(NUDStock);
            LPanelAE.Controls.Add(NUDPrecio);
            LPanelAE.Controls.Add(CbxMarca);
            LPanelAE.Controls.Add(CbxTipo2);
            LPanelAE.Controls.Add(label2);
            LPanelAE.Controls.Add(textBox2);
            LPanelAE.Controls.Add(label9);
            LPanelAE.Controls.Add(label7);
            LPanelAE.Controls.Add(label5);
            LPanelAE.Controls.Add(TxtDescripcion);
            LPanelAE.Controls.Add(label4);
            LPanelAE.Controls.Add(label6);
            LPanelAE.Controls.Add(label8);
            LPanelAE.Controls.Add(TxtNombre);
            LPanelAE.Controls.Add(label3);
            LPanelAE.Controls.Add(CancelarButton);
            LPanelAE.Controls.Add(GuardarButton);
            LPanelAE.Dock = DockStyle.Right;
            LPanelAE.Location = new Point(661, 0);
            LPanelAE.Name = "LPanelAE";
            LPanelAE.Size = new Size(200, 331);
            LPanelAE.TabIndex = 4;
            LPanelAE.Visible = false;
            // 
            // NUDStock
            // 
            NUDStock.Location = new Point(89, 174);
            NUDStock.Name = "NUDStock";
            NUDStock.Size = new Size(98, 23);
            NUDStock.TabIndex = 36;
            // 
            // NUDPrecio
            // 
            NUDPrecio.DecimalPlaces = 2;
            NUDPrecio.Location = new Point(88, 147);
            NUDPrecio.Name = "NUDPrecio";
            NUDPrecio.Size = new Size(99, 23);
            NUDPrecio.TabIndex = 35;
            // 
            // CbxMarca
            // 
            CbxMarca.FormattingEnabled = true;
            CbxMarca.Location = new Point(87, 93);
            CbxMarca.Name = "CbxMarca";
            CbxMarca.Size = new Size(102, 23);
            CbxMarca.TabIndex = 34;
            // 
            // CbxTipo2
            // 
            CbxTipo2.FormattingEnabled = true;
            CbxTipo2.Location = new Point(87, 69);
            CbxTipo2.Name = "CbxTipo2";
            CbxTipo2.Size = new Size(102, 23);
            CbxTipo2.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 206);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 32;
            label2.Text = "Foto";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 179);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 30;
            label9.Text = "Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 150);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 28;
            label7.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 123);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 26;
            label5.Text = "Descripcion";
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(87, 120);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(100, 23);
            TxtDescripcion.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 96);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 24;
            label4.Text = "Marca";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 72);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 22;
            label6.Text = "Tipo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 47);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 20;
            label8.Text = "Nombre";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(87, 44);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(100, 23);
            TxtNombre.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 20);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 4;
            label3.Text = "Agregar / Editar ";
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(87, 265);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(68, 51);
            CancelarButton.TabIndex = 3;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // GuardarButton
            // 
            GuardarButton.Location = new Point(13, 265);
            GuardarButton.Name = "GuardarButton";
            GuardarButton.Size = new Size(68, 51);
            GuardarButton.TabIndex = 2;
            GuardarButton.Text = "Guardar";
            GuardarButton.UseVisualStyleBackColor = true;
            GuardarButton.Click += GuardarButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(861, 68);
            panel3.TabIndex = 10;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CbxTipo
            // 
            CbxTipo.FormattingEnabled = true;
            CbxTipo.Location = new Point(89, 232);
            CbxTipo.Name = "CbxTipo";
            CbxTipo.Size = new Size(102, 23);
            CbxTipo.TabIndex = 37;
            // 
            // UcProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "UcProducto";
            Size = new Size(861, 459);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvProducto).EndInit();
            panel5.ResumeLayout(false);
            LPanelAE.ResumeLayout(false);
            LPanelAE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDPrecio).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button AgregarButton;
        private Button PagAnteriorButton;
        private Button PagSigienteButton;
        private Panel panel1;
        private TextBox textBox1;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView DgvProducto;
        private Panel panel5;
        private Panel LPanelAE;
        private Label label3;
        private Button CancelarButton;
        private Button GuardarButton;
        private Panel panel3;
        private DataGridViewTextBoxColumn ColIdProducto;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColTipo;
        private DataGridViewTextBoxColumn ColMarca;
        private DataGridViewTextBoxColumn ColDescripcion;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewButtonColumn ColEditar;
        private DataGridViewButtonColumn ColBorrar;
        private Label label7;
        private Label label5;
        private TextBox TxtDescripcion;
        private Label label4;
        private Label label6;
        private Label label8;
        private TextBox TxtNombre;
        private Label label2;
        private TextBox textBox2;
        private Label label9;
        private ComboBox CbxMarca;
        private ErrorProvider errorProvider1;
        private NumericUpDown NUDPrecio;
        private NumericUpDown NUDStock;
        private ComboBox CbxTipo;
        private ComboBox CbxTipo2;
    }
}
