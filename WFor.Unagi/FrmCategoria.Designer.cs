namespace WFor.Unagi
{
    partial class FrmCategoria
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
            errorProvider1 = new ErrorProvider(components);
            toolStrip1 = new ToolStrip();
            Button_Agregar = new ToolStripButton();
            Button_Editar = new ToolStripButton();
            Button_Borrar = new ToolStripButton();
            panel1 = new Panel();
            dvg_Categoria = new DataGridView();
            ColIdCategoria = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvg_Categoria).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { Button_Agregar, Button_Editar, Button_Borrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 62);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // Button_Agregar
            // 
            Button_Agregar.Image = (Image)resources.GetObject("Button_Agregar.Image");
            Button_Agregar.ImageScaling = ToolStripItemImageScaling.None;
            Button_Agregar.ImageTransparentColor = Color.Magenta;
            Button_Agregar.Name = "Button_Agregar";
            Button_Agregar.Size = new Size(53, 59);
            Button_Agregar.Text = "Agregar";
            Button_Agregar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // Button_Editar
            // 
            Button_Editar.Image = (Image)resources.GetObject("Button_Editar.Image");
            Button_Editar.ImageScaling = ToolStripItemImageScaling.None;
            Button_Editar.ImageTransparentColor = Color.Magenta;
            Button_Editar.Name = "Button_Editar";
            Button_Editar.Size = new Size(44, 59);
            Button_Editar.Text = "Editar";
            Button_Editar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // Button_Borrar
            // 
            Button_Borrar.Image = (Image)resources.GetObject("Button_Borrar.Image");
            Button_Borrar.ImageScaling = ToolStripItemImageScaling.None;
            Button_Borrar.ImageTransparentColor = Color.Magenta;
            Button_Borrar.Name = "Button_Borrar";
            Button_Borrar.Size = new Size(44, 59);
            Button_Borrar.Text = "Borrar";
            Button_Borrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // panel1
            // 
            panel1.Controls.Add(dvg_Categoria);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 388);
            panel1.TabIndex = 1;
            // 
            // dvg_Categoria
            // 
            dvg_Categoria.AllowUserToAddRows = false;
            dvg_Categoria.AllowUserToDeleteRows = false;
            dvg_Categoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_Categoria.Columns.AddRange(new DataGridViewColumn[] { ColIdCategoria, ColNombre });
            dvg_Categoria.Dock = DockStyle.Fill;
            dvg_Categoria.Location = new Point(0, 0);
            dvg_Categoria.Name = "dvg_Categoria";
            dvg_Categoria.ReadOnly = true;
            dvg_Categoria.RowHeadersVisible = false;
            dvg_Categoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvg_Categoria.Size = new Size(800, 388);
            dvg_Categoria.TabIndex = 0;
            // 
            // ColIdCategoria
            // 
            ColIdCategoria.HeaderText = "Id Categoria";
            ColIdCategoria.Name = "ColIdCategoria";
            ColIdCategoria.ReadOnly = true;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "FrmCategoria";
            Text = "Categoria";
            Load += FrmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvg_Categoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Panel panel1;
        private DataGridView dvg_Categoria;
        private ToolStrip toolStrip1;
        private ToolStripButton Button_Agregar;
        private ToolStripButton Button_Editar;
        private ToolStripButton Button_Borrar;
        private DataGridViewTextBoxColumn ColIdCategoria;
        private DataGridViewTextBoxColumn ColNombre;
    }
}