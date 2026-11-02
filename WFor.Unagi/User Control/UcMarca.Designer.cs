namespace WFor.Unagi
{
    partial class UcMarca
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
            DgvMarca = new DataGridView();
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
            BtmBuscarLogo = new Button();
            PicBoxLogo = new PictureBox();
            CboxEmprendedores = new ComboBox();
            label4 = new Label();
            LPanelAE = new Label();
            CancelarButton = new Button();
            GuardarButton = new Button();
            label2 = new Label();
            TxtNombre = new TextBox();
            panel1 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            ColId = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColEmprendedor = new DataGridViewTextBoxColumn();
            ColEditar = new DataGridViewButtonColumn();
            ColBorrar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)DgvMarca).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            PanelEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // DgvMarca
            // 
            DgvMarca.AllowUserToAddRows = false;
            DgvMarca.AllowUserToDeleteRows = false;
            DgvMarca.AllowUserToOrderColumns = true;
            DgvMarca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMarca.Columns.AddRange(new DataGridViewColumn[] { ColId, ColNombre, ColEmprendedor, ColEditar, ColBorrar });
            DgvMarca.Dock = DockStyle.Fill;
            DgvMarca.Location = new Point(0, 0);
            DgvMarca.Name = "DgvMarca";
            DgvMarca.ReadOnly = true;
            DgvMarca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvMarca.Size = new Size(804, 304);
            DgvMarca.TabIndex = 2;
            DgvMarca.CellContentClick += DgvMarca_CellContentClick;
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
            label1.Size = new Size(188, 37);
            label1.TabIndex = 0;
            label1.Text = "Lista de Marca";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(PagAnteriorButton);
            panel2.Controls.Add(PagSigienteButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 304);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 60);
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
            AgregarButton.Location = new Point(669, 4);
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
            panel5.Controls.Add(DgvMarca);
            panel5.Controls.Add(panel2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 61);
            panel5.Name = "panel5";
            panel5.Size = new Size(804, 364);
            panel5.TabIndex = 6;
            // 
            // PanelEdicion
            // 
            PanelEdicion.Controls.Add(BtmBuscarLogo);
            PanelEdicion.Controls.Add(PicBoxLogo);
            PanelEdicion.Controls.Add(CboxEmprendedores);
            PanelEdicion.Controls.Add(label4);
            PanelEdicion.Controls.Add(LPanelAE);
            PanelEdicion.Controls.Add(CancelarButton);
            PanelEdicion.Controls.Add(GuardarButton);
            PanelEdicion.Controls.Add(label2);
            PanelEdicion.Controls.Add(TxtNombre);
            PanelEdicion.Dock = DockStyle.Right;
            PanelEdicion.Location = new Point(575, 0);
            PanelEdicion.Name = "PanelEdicion";
            PanelEdicion.Size = new Size(229, 304);
            PanelEdicion.TabIndex = 4;
            PanelEdicion.Visible = false;
            // 
            // BtmBuscarLogo
            // 
            BtmBuscarLogo.Location = new Point(59, 150);
            BtmBuscarLogo.Name = "BtmBuscarLogo";
            BtmBuscarLogo.Size = new Size(105, 47);
            BtmBuscarLogo.TabIndex = 9;
            BtmBuscarLogo.Text = "Insertar Imagen";
            BtmBuscarLogo.UseVisualStyleBackColor = true;
            BtmBuscarLogo.Click += BtmBuscarLogo_Click;
            // 
            // PicBoxLogo
            // 
            PicBoxLogo.Location = new Point(52, 121);
            PicBoxLogo.Name = "PicBoxLogo";
            PicBoxLogo.Size = new Size(120, 109);
            PicBoxLogo.TabIndex = 8;
            PicBoxLogo.TabStop = false;
            // 
            // CboxEmprendedores
            // 
            CboxEmprendedores.FormattingEnabled = true;
            CboxEmprendedores.Location = new Point(93, 82);
            CboxEmprendedores.Name = "CboxEmprendedores";
            CboxEmprendedores.Size = new Size(121, 23);
            CboxEmprendedores.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 85);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 6;
            label4.Text = "Emprendedor";
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
            CancelarButton.Location = new Point(126, 247);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(68, 51);
            CancelarButton.TabIndex = 3;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // GuardarButton
            // 
            GuardarButton.Location = new Point(52, 247);
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
            TxtNombre.Location = new Point(94, 53);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(100, 23);
            TxtNombre.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(AgregarButton);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 61);
            panel1.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ColId
            // 
            ColId.HeaderText = "ID";
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Visible = false;
            // 
            // ColNombre
            // 
            ColNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            ColNombre.Width = 76;
            // 
            // ColEmprendedor
            // 
            ColEmprendedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColEmprendedor.HeaderText = "Emprendedor";
            ColEmprendedor.Name = "ColEmprendedor";
            ColEmprendedor.ReadOnly = true;
            ColEmprendedor.Width = 104;
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
            // UcMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "UcMarca";
            Size = new Size(804, 425);
            ((System.ComponentModel.ISupportInitialize)DgvMarca).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            PanelEdicion.ResumeLayout(false);
            PanelEdicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvMarca;
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
        private ComboBox CboxEmprendedores;
        private Label label4;
        private ErrorProvider errorProvider1;
        private Button BtmBuscarLogo;
        private PictureBox PicBoxLogo;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColEmprendedor;
        private DataGridViewButtonColumn ColEditar;
        private DataGridViewButtonColumn ColBorrar;
    }
}
