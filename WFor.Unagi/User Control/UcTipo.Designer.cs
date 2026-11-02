namespace WFor.Unagi
{
    partial class UcTipo
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
            DgvTipo = new DataGridView();
            textBox1 = new TextBox();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            PagAnteriorButton = new Button();
            PagSigienteButton = new Button();
            AgregarButton = new Button();
            panel5 = new Panel();
            PanelEdicion = new Panel();
            CBoxCategoria = new ComboBox();
            label4 = new Label();
            LPanelAE = new Label();
            CancelarButton = new Button();
            GuardarButton = new Button();
            label2 = new Label();
            TxtNombre = new TextBox();
            panel1 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            IdCategoriaCol = new DataGridViewTextBoxColumn();
            ColTipo = new DataGridViewTextBoxColumn();
            NombreCol = new DataGridViewTextBoxColumn();
            ColEditar = new DataGridViewButtonColumn();
            ColBorrar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)DgvTipo).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            PanelEdicion.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // DgvTipo
            // 
            DgvTipo.AllowUserToAddRows = false;
            DgvTipo.AllowUserToDeleteRows = false;
            DgvTipo.AllowUserToOrderColumns = true;
            DgvTipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvTipo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTipo.Columns.AddRange(new DataGridViewColumn[] { IdCategoriaCol, ColTipo, NombreCol, ColEditar, ColBorrar });
            DgvTipo.Dock = DockStyle.Fill;
            DgvTipo.Location = new Point(0, 0);
            DgvTipo.Name = "DgvTipo";
            DgvTipo.ReadOnly = true;
            DgvTipo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvTipo.Size = new Size(784, 311);
            DgvTipo.TabIndex = 2;
            DgvTipo.CellContentClick += DgvTipo_CellContentClick;
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
            label1.Size = new Size(179, 37);
            label1.TabIndex = 0;
            label1.Text = "Lista de Tipos";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(PagAnteriorButton);
            panel2.Controls.Add(PagSigienteButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 311);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 64);
            panel2.TabIndex = 1;
            // 
            // PagAnteriorButton
            // 
            PagAnteriorButton.Image = Properties.Resources.arrow_pointing_left_20px;
            PagAnteriorButton.Location = new Point(3, 6);
            PagAnteriorButton.Name = "PagAnteriorButton";
            PagAnteriorButton.Size = new Size(59, 51);
            PagAnteriorButton.TabIndex = 2;
            PagAnteriorButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            PagAnteriorButton.UseVisualStyleBackColor = true;
            // 
            // PagSigienteButton
            // 
            PagSigienteButton.Image = Properties.Resources.arrow_20px;
            PagSigienteButton.Location = new Point(722, 6);
            PagSigienteButton.Name = "PagSigienteButton";
            PagSigienteButton.Size = new Size(59, 51);
            PagSigienteButton.TabIndex = 1;
            PagSigienteButton.UseVisualStyleBackColor = true;
            // 
            // AgregarButton
            // 
            AgregarButton.Location = new Point(607, 11);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(70, 51);
            AgregarButton.TabIndex = 3;
            AgregarButton.Text = "Agregar";
            AgregarButton.UseVisualStyleBackColor = true;
            AgregarButton.Click += AgregarButton_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(PanelEdicion);
            panel5.Controls.Add(DgvTipo);
            panel5.Controls.Add(panel2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 68);
            panel5.Name = "panel5";
            panel5.Size = new Size(784, 375);
            panel5.TabIndex = 6;
            // 
            // PanelEdicion
            // 
            PanelEdicion.Controls.Add(CBoxCategoria);
            PanelEdicion.Controls.Add(label4);
            PanelEdicion.Controls.Add(LPanelAE);
            PanelEdicion.Controls.Add(CancelarButton);
            PanelEdicion.Controls.Add(GuardarButton);
            PanelEdicion.Controls.Add(label2);
            PanelEdicion.Controls.Add(TxtNombre);
            PanelEdicion.Dock = DockStyle.Right;
            PanelEdicion.Location = new Point(607, 0);
            PanelEdicion.Name = "PanelEdicion";
            PanelEdicion.Size = new Size(177, 311);
            PanelEdicion.TabIndex = 4;
            PanelEdicion.Visible = false;
            // 
            // CBoxCategoria
            // 
            CBoxCategoria.FormattingEnabled = true;
            CBoxCategoria.Location = new Point(14, 120);
            CBoxCategoria.Name = "CBoxCategoria";
            CBoxCategoria.Size = new Size(121, 23);
            CBoxCategoria.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 100);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 5;
            label4.Text = "Categoria";
            // 
            // LPanelAE
            // 
            LPanelAE.AutoSize = true;
            LPanelAE.Location = new Point(15, 20);
            LPanelAE.Name = "LPanelAE";
            LPanelAE.Size = new Size(93, 15);
            LPanelAE.TabIndex = 4;
            LPanelAE.Text = "Agregar / Editar ";
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(97, 219);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(68, 51);
            CancelarButton.TabIndex = 3;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // GuardarButton
            // 
            GuardarButton.Location = new Point(13, 219);
            GuardarButton.Name = "GuardarButton";
            GuardarButton.Size = new Size(68, 51);
            GuardarButton.TabIndex = 2;
            GuardarButton.Text = "Guardar";
            GuardarButton.UseVisualStyleBackColor = true;
            GuardarButton.Click += GuardarButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 56);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(13, 74);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(100, 23);
            TxtNombre.TabIndex = 0;
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
            panel1.Size = new Size(784, 68);
            panel1.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // IdCategoriaCol
            // 
            IdCategoriaCol.HeaderText = "ID";
            IdCategoriaCol.Name = "IdCategoriaCol";
            IdCategoriaCol.ReadOnly = true;
            IdCategoriaCol.Visible = false;
            // 
            // ColTipo
            // 
            ColTipo.HeaderText = "Nombre";
            ColTipo.Name = "ColTipo";
            ColTipo.ReadOnly = true;
            // 
            // NombreCol
            // 
            NombreCol.HeaderText = "Categoria";
            NombreCol.Name = "NombreCol";
            NombreCol.ReadOnly = true;
            // 
            // ColEditar
            // 
            ColEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColEditar.HeaderText = "Editar";
            ColEditar.Name = "ColEditar";
            ColEditar.ReadOnly = true;
            ColEditar.Text = "Editar";
            ColEditar.Width = 43;
            // 
            // ColBorrar
            // 
            ColBorrar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColBorrar.HeaderText = "Borrar";
            ColBorrar.Name = "ColBorrar";
            ColBorrar.ReadOnly = true;
            ColBorrar.Text = "Borrar";
            ColBorrar.Width = 45;
            // 
            // UcTipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "UcTipo";
            Size = new Size(784, 443);
            ((System.ComponentModel.ISupportInitialize)DgvTipo).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            PanelEdicion.ResumeLayout(false);
            PanelEdicion.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvTipo;
        private TextBox textBox1;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button AgregarButton;
        private Button PagAnteriorButton;
        private Button PagSigienteButton;
        private Panel panel5;
        private Panel panel1;
        private Panel PanelEdicion;
        private Label LPanelAE;
        private Button CancelarButton;
        private Button GuardarButton;
        private Label label2;
        private TextBox TxtNombre;
        private Label label4;
        private ComboBox CBoxCategoria;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn IdCategoriaCol;
        private DataGridViewTextBoxColumn ColTipo;
        private DataGridViewTextBoxColumn NombreCol;
        private DataGridViewButtonColumn ColEditar;
        private DataGridViewButtonColumn ColBorrar;
    }
}
