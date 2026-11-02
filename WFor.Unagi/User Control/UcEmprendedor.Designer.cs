namespace WFor.Unagi.User_Control
{
    partial class UcEmprendedor
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
            textBox1 = new TextBox();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            AgregarButton = new Button();
            LPanelAE = new Label();
            CancelarButton = new Button();
            GuardarButton = new Button();
            PanelEdicion = new Panel();
            ButtonGuardar = new Button();
            ButtonCancelar = new Button();
            label7 = new Label();
            TxtCorreo = new TextBox();
            label5 = new Label();
            TxtTelefono = new TextBox();
            label4 = new Label();
            TxtDni = new TextBox();
            label2 = new Label();
            TxtApellido = new TextBox();
            label6 = new Label();
            TxtNombre = new TextBox();
            panel5 = new Panel();
            DgvEmprendedor = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColApellido = new DataGridViewTextBoxColumn();
            ColDni = new DataGridViewTextBoxColumn();
            ColTelefo = new DataGridViewTextBoxColumn();
            ColCorreo = new DataGridViewTextBoxColumn();
            ColEditar = new DataGridViewButtonColumn();
            ColBorrar = new DataGridViewButtonColumn();
            panel2 = new Panel();
            PagAnteriorButton = new Button();
            PagSigienteButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelEdicion.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvEmprendedor).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(AgregarButton);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 62);
            panel1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(395, 27);
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
            panel4.Size = new Size(63, 62);
            panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Unagi_icono_transparente;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 62);
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
            label1.Size = new Size(302, 37);
            label1.TabIndex = 0;
            label1.Text = "Lista de Emprendedores";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AgregarButton
            // 
            AgregarButton.Location = new Point(678, 3);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(70, 51);
            AgregarButton.TabIndex = 3;
            AgregarButton.Text = "Agregar";
            AgregarButton.UseVisualStyleBackColor = true;
            AgregarButton.Click += AgregarButton_Click;
            // 
            // LPanelAE
            // 
            LPanelAE.AutoSize = true;
            LPanelAE.Location = new Point(15, 24);
            LPanelAE.Name = "LPanelAE";
            LPanelAE.Size = new Size(93, 15);
            LPanelAE.TabIndex = 4;
            LPanelAE.Text = "Agregar / Editar ";
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(89, 304);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(68, 51);
            CancelarButton.TabIndex = 3;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            GuardarButton.Location = new Point(15, 304);
            GuardarButton.Name = "GuardarButton";
            GuardarButton.Size = new Size(68, 51);
            GuardarButton.TabIndex = 2;
            GuardarButton.Text = "Guardar";
            GuardarButton.UseVisualStyleBackColor = true;
            // 
            // PanelEdicion
            // 
            PanelEdicion.Controls.Add(ButtonGuardar);
            PanelEdicion.Controls.Add(ButtonCancelar);
            PanelEdicion.Controls.Add(label7);
            PanelEdicion.Controls.Add(TxtCorreo);
            PanelEdicion.Controls.Add(label5);
            PanelEdicion.Controls.Add(TxtTelefono);
            PanelEdicion.Controls.Add(label4);
            PanelEdicion.Controls.Add(TxtDni);
            PanelEdicion.Controls.Add(label2);
            PanelEdicion.Controls.Add(TxtApellido);
            PanelEdicion.Controls.Add(label6);
            PanelEdicion.Controls.Add(TxtNombre);
            PanelEdicion.Controls.Add(LPanelAE);
            PanelEdicion.Controls.Add(CancelarButton);
            PanelEdicion.Controls.Add(GuardarButton);
            PanelEdicion.Dock = DockStyle.Right;
            PanelEdicion.Location = new Point(627, 0);
            PanelEdicion.Name = "PanelEdicion";
            PanelEdicion.Size = new Size(195, 297);
            PanelEdicion.TabIndex = 4;
            PanelEdicion.Visible = false;
            PanelEdicion.Paint += PanelEdicion_Paint;
            // 
            // ButtonGuardar
            // 
            ButtonGuardar.Location = new Point(19, 230);
            ButtonGuardar.Name = "ButtonGuardar";
            ButtonGuardar.Size = new Size(70, 51);
            ButtonGuardar.TabIndex = 4;
            ButtonGuardar.Text = "Guardard";
            ButtonGuardar.UseVisualStyleBackColor = true;
            ButtonGuardar.Click += ButtonGuardar_Click;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Location = new Point(102, 230);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(70, 51);
            ButtonCancelar.TabIndex = 5;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 166);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 18;
            label7.Text = "Correo";
            // 
            // TxtCorreo
            // 
            TxtCorreo.Location = new Point(72, 163);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(100, 23);
            TxtCorreo.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 139);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 16;
            label5.Text = "Telefono";
            // 
            // TxtTelefono
            // 
            TxtTelefono.Location = new Point(72, 136);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(100, 23);
            TxtTelefono.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 112);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 14;
            label4.Text = "Dni";
            // 
            // TxtDni
            // 
            TxtDni.Location = new Point(72, 109);
            TxtDni.Name = "TxtDni";
            TxtDni.Size = new Size(100, 23);
            TxtDni.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 85);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 12;
            label2.Text = "Apelli";
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(72, 82);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(100, 23);
            TxtApellido.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 58);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 10;
            label6.Text = "Nombre";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(72, 55);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(100, 23);
            TxtNombre.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.Controls.Add(PanelEdicion);
            panel5.Controls.Add(DgvEmprendedor);
            panel5.Controls.Add(panel2);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 68);
            panel5.Name = "panel5";
            panel5.Size = new Size(822, 357);
            panel5.TabIndex = 8;
            // 
            // DgvEmprendedor
            // 
            DgvEmprendedor.AllowUserToAddRows = false;
            DgvEmprendedor.AllowUserToDeleteRows = false;
            DgvEmprendedor.AllowUserToOrderColumns = true;
            DgvEmprendedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEmprendedor.Columns.AddRange(new DataGridViewColumn[] { ColId, ColNombre, ColApellido, ColDni, ColTelefo, ColCorreo, ColEditar, ColBorrar });
            DgvEmprendedor.Dock = DockStyle.Fill;
            DgvEmprendedor.Location = new Point(0, 0);
            DgvEmprendedor.Name = "DgvEmprendedor";
            DgvEmprendedor.ReadOnly = true;
            DgvEmprendedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvEmprendedor.Size = new Size(822, 297);
            DgvEmprendedor.TabIndex = 2;
            DgvEmprendedor.CellContentClick += DgvEmprendedor_CellContentClick;
            // 
            // ColId
            // 
            ColId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            // ColApellido
            // 
            ColApellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColApellido.HeaderText = "Apellido";
            ColApellido.Name = "ColApellido";
            ColApellido.ReadOnly = true;
            ColApellido.Width = 76;
            // 
            // ColDni
            // 
            ColDni.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColDni.HeaderText = "Dni";
            ColDni.Name = "ColDni";
            ColDni.ReadOnly = true;
            ColDni.Width = 50;
            // 
            // ColTelefo
            // 
            ColTelefo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColTelefo.HeaderText = "Telefono";
            ColTelefo.Name = "ColTelefo";
            ColTelefo.ReadOnly = true;
            ColTelefo.Width = 77;
            // 
            // ColCorreo
            // 
            ColCorreo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColCorreo.HeaderText = "Correo";
            ColCorreo.Name = "ColCorreo";
            ColCorreo.ReadOnly = true;
            ColCorreo.Width = 68;
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
            // panel2
            // 
            panel2.Controls.Add(PagAnteriorButton);
            panel2.Controls.Add(PagSigienteButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 297);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 60);
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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UcEmprendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel5);
            Name = "UcEmprendedor";
            Size = new Size(822, 425);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelEdicion.ResumeLayout(false);
            PanelEdicion.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvEmprendedor).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label1;
        private Label LPanelAE;
        private Button CancelarButton;
        private Button GuardarButton;
        private Panel PanelEdicion;
        private Panel panel5;
        private DataGridView DgvEmprendedor;
        private Panel panel2;
        private Button ButtonCancelar;
        private Button ButtonGuardar;
        private Button AgregarButton;
        private Button PagAnteriorButton;
        private Button PagSigienteButton;
        private Label label6;
        private TextBox TxtNombre;
        private Label label7;
        private TextBox TxtCorreo;
        private Label label5;
        private TextBox TxtTelefono;
        private Label label4;
        private TextBox TxtDni;
        private Label label2;
        private TextBox TxtApellido;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColDni;
        private DataGridViewTextBoxColumn ColTelefo;
        private DataGridViewTextBoxColumn ColCorreo;
        private DataGridViewButtonColumn ColEditar;
        private DataGridViewButtonColumn ColBorrar;
    }
}
