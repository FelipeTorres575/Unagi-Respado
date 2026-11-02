namespace WFor.Unagi
{
    partial class UcCategoria
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
            panel1 = new Panel();
            AgregarButton = new Button();
            TextBox = new TextBox();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            PagAnteriorButton = new Button();
            PagSigienteButton = new Button();
            panel5 = new Panel();
            PanelEdicion = new Panel();
            LPanelAE = new Label();
            CancelarButton = new Button();
            GuardarButton = new Button();
            label2 = new Label();
            NombreTxt = new TextBox();
            DgvCategoria = new DataGridView();
            IdCategoriaCol = new DataGridViewTextBoxColumn();
            NombreCol = new DataGridViewTextBoxColumn();
            colEditar = new DataGridViewButtonColumn();
            colBorrar = new DataGridViewButtonColumn();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            PanelEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(AgregarButton);
            panel1.Controls.Add(TextBox);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 61);
            panel1.TabIndex = 0;
            // 
            // AgregarButton
            // 
            AgregarButton.Location = new Point(661, 12);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(110, 43);
            AgregarButton.TabIndex = 3;
            AgregarButton.Text = "Agregar";
            AgregarButton.UseVisualStyleBackColor = true;
            AgregarButton.Click += AgregarButton_Click;
            // 
            // TextBox
            // 
            TextBox.Location = new Point(343, 23);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(233, 23);
            TextBox.TabIndex = 2;
            TextBox.Text = "Buscar";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(63, 61);
            panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Unagi_icono_transparente;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 61);
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
            label1.Size = new Size(242, 37);
            label1.TabIndex = 0;
            label1.Text = "Lista de Categorias";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(PagAnteriorButton);
            panel2.Controls.Add(PagSigienteButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 322);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 60);
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
            PagSigienteButton.Location = new Point(722, 3);
            PagSigienteButton.Name = "PagSigienteButton";
            PagSigienteButton.Size = new Size(59, 51);
            PagSigienteButton.TabIndex = 1;
            PagSigienteButton.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(PanelEdicion);
            panel5.Controls.Add(DgvCategoria);
            panel5.Controls.Add(panel2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 61);
            panel5.Name = "panel5";
            panel5.Size = new Size(784, 382);
            panel5.TabIndex = 4;
            // 
            // PanelEdicion
            // 
            PanelEdicion.Controls.Add(LPanelAE);
            PanelEdicion.Controls.Add(CancelarButton);
            PanelEdicion.Controls.Add(GuardarButton);
            PanelEdicion.Controls.Add(label2);
            PanelEdicion.Controls.Add(NombreTxt);
            PanelEdicion.Dock = DockStyle.Right;
            PanelEdicion.Location = new Point(616, 0);
            PanelEdicion.Name = "PanelEdicion";
            PanelEdicion.Size = new Size(168, 322);
            PanelEdicion.TabIndex = 3;
            PanelEdicion.Visible = false;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 56);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // NombreTxt
            // 
            NombreTxt.Location = new Point(13, 74);
            NombreTxt.Name = "NombreTxt";
            NombreTxt.Size = new Size(100, 23);
            NombreTxt.TabIndex = 0;
            // 
            // DgvCategoria
            // 
            DgvCategoria.AllowUserToAddRows = false;
            DgvCategoria.AllowUserToDeleteRows = false;
            DgvCategoria.AllowUserToOrderColumns = true;
            DgvCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCategoria.Columns.AddRange(new DataGridViewColumn[] { IdCategoriaCol, NombreCol, colEditar, colBorrar });
            DgvCategoria.Dock = DockStyle.Fill;
            DgvCategoria.Location = new Point(0, 0);
            DgvCategoria.Name = "DgvCategoria";
            DgvCategoria.ReadOnly = true;
            DgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvCategoria.Size = new Size(784, 322);
            DgvCategoria.TabIndex = 2;
            DgvCategoria.CellContentClick += DgvCategoria_CellContentClick;
            // 
            // IdCategoriaCol
            // 
            IdCategoriaCol.HeaderText = "ID";
            IdCategoriaCol.Name = "IdCategoriaCol";
            IdCategoriaCol.ReadOnly = true;
            IdCategoriaCol.Visible = false;
            // 
            // NombreCol
            // 
            NombreCol.HeaderText = "Categoria";
            NombreCol.Name = "NombreCol";
            NombreCol.ReadOnly = true;
            // 
            // colEditar
            // 
            colEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colEditar.HeaderText = "Editar";
            colEditar.Name = "colEditar";
            colEditar.ReadOnly = true;
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true;
            colEditar.Width = 43;
            // 
            // colBorrar
            // 
            colBorrar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colBorrar.HeaderText = "Borrar";
            colBorrar.Name = "colBorrar";
            colBorrar.ReadOnly = true;
            colBorrar.Text = "Borrar";
            colBorrar.UseColumnTextForButtonValue = true;
            colBorrar.Width = 45;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UcCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "UcCategoria";
            Size = new Size(784, 443);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            PanelEdicion.ResumeLayout(false);
            PanelEdicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox TextBox;
        private DataGridView DgvCategoria;
        private Button utton;
        private Button PagSigienteButton;
        private Button AgregarButton;
        private Button PagAnteriorButton;
        private Panel PanelEdicion;
        private Button CancelarButton;
        private Button GuardarButton;
        private Label label2;
        private TextBox NombreTxt;
        private Label LPanelAE;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn IdCategoriaCol;
        private DataGridViewTextBoxColumn NombreCol;
        private DataGridViewButtonColumn colEditar;
        private DataGridViewButtonColumn colBorrar;
    }
}
