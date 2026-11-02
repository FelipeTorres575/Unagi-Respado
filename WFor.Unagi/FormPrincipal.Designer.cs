namespace WFor.Unagi
{
    partial class FrmPrincipal
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
            PanelMenu = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ButtonVenta = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            ProductoButton = new Button();
            CategoriaButton = new Button();
            TipoButton = new Button();
            MarcaButton = new Button();
            label2 = new Label();
            label3 = new Label();
            EmprendedoresButton = new Button();
            ClienteButton = new Button();
            RepordetButton = new Button();
            PanelCentral = new Panel();
            PanelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = SystemColors.ActiveCaption;
            PanelMenu.Controls.Add(panel1);
            PanelMenu.Controls.Add(flowLayoutPanel1);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.ForeColor = SystemColors.ActiveBorder;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(170, 729);
            PanelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ButtonVenta);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 90);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.Unagi_icono_transparente;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ButtonVenta
            // 
            ButtonVenta.ForeColor = SystemColors.WindowText;
            ButtonVenta.Location = new Point(3, 46);
            ButtonVenta.Name = "ButtonVenta";
            ButtonVenta.Size = new Size(164, 41);
            ButtonVenta.TabIndex = 1;
            ButtonVenta.Text = "Nueva Venta";
            ButtonVenta.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(ProductoButton);
            flowLayoutPanel1.Controls.Add(CategoriaButton);
            flowLayoutPanel1.Controls.Add(TipoButton);
            flowLayoutPanel1.Controls.Add(MarcaButton);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(EmprendedoresButton);
            flowLayoutPanel1.Controls.Add(ClienteButton);
            flowLayoutPanel1.Controls.Add(RepordetButton);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 93);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(164, 465);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 1;
            label1.Text = "Inventario";
            // 
            // ProductoButton
            // 
            ProductoButton.FlatAppearance.BorderSize = 0;
            ProductoButton.FlatStyle = FlatStyle.Flat;
            ProductoButton.Font = new Font("Segoe UI", 10F);
            ProductoButton.ForeColor = SystemColors.WindowText;
            ProductoButton.Location = new Point(0, 25);
            ProductoButton.Margin = new Padding(0);
            ProductoButton.Name = "ProductoButton";
            ProductoButton.Size = new Size(164, 30);
            ProductoButton.TabIndex = 0;
            ProductoButton.Text = "Productos";
            ProductoButton.TextAlign = ContentAlignment.MiddleLeft;
            ProductoButton.UseVisualStyleBackColor = true;
            ProductoButton.Click += ProductoButton_Click;
            // 
            // CategoriaButton
            // 
            CategoriaButton.FlatAppearance.BorderSize = 0;
            CategoriaButton.FlatStyle = FlatStyle.Flat;
            CategoriaButton.Font = new Font("Segoe UI", 10F);
            CategoriaButton.ForeColor = SystemColors.WindowText;
            CategoriaButton.Location = new Point(0, 55);
            CategoriaButton.Margin = new Padding(0);
            CategoriaButton.Name = "CategoriaButton";
            CategoriaButton.Size = new Size(164, 30);
            CategoriaButton.TabIndex = 2;
            CategoriaButton.Text = "Categorias";
            CategoriaButton.TextAlign = ContentAlignment.MiddleLeft;
            CategoriaButton.UseVisualStyleBackColor = true;
            CategoriaButton.Click += CategoriaButton_Click;
            // 
            // TipoButton
            // 
            TipoButton.Dock = DockStyle.Bottom;
            TipoButton.FlatAppearance.BorderSize = 0;
            TipoButton.FlatStyle = FlatStyle.Flat;
            TipoButton.Font = new Font("Segoe UI", 10F);
            TipoButton.ForeColor = SystemColors.WindowText;
            TipoButton.Location = new Point(0, 85);
            TipoButton.Margin = new Padding(0);
            TipoButton.Name = "TipoButton";
            TipoButton.Size = new Size(164, 30);
            TipoButton.TabIndex = 3;
            TipoButton.Text = "Tipos";
            TipoButton.TextAlign = ContentAlignment.MiddleLeft;
            TipoButton.UseVisualStyleBackColor = true;
            TipoButton.Click += TipoButton_Click;
            // 
            // MarcaButton
            // 
            MarcaButton.FlatAppearance.BorderSize = 0;
            MarcaButton.FlatStyle = FlatStyle.Flat;
            MarcaButton.Font = new Font("Segoe UI", 10F);
            MarcaButton.ForeColor = SystemColors.WindowText;
            MarcaButton.Location = new Point(0, 115);
            MarcaButton.Margin = new Padding(0);
            MarcaButton.Name = "MarcaButton";
            MarcaButton.Size = new Size(164, 30);
            MarcaButton.TabIndex = 4;
            MarcaButton.Text = "Marcas";
            MarcaButton.TextAlign = ContentAlignment.MiddleLeft;
            MarcaButton.UseVisualStyleBackColor = true;
            MarcaButton.Click += MarcaButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 145);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(0, 160);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 9;
            label3.Text = "Administracion";
            // 
            // EmprendedoresButton
            // 
            EmprendedoresButton.FlatAppearance.BorderSize = 0;
            EmprendedoresButton.FlatStyle = FlatStyle.Flat;
            EmprendedoresButton.Font = new Font("Segoe UI", 10F);
            EmprendedoresButton.ForeColor = SystemColors.WindowText;
            EmprendedoresButton.Location = new Point(0, 185);
            EmprendedoresButton.Margin = new Padding(0);
            EmprendedoresButton.Name = "EmprendedoresButton";
            EmprendedoresButton.Size = new Size(164, 30);
            EmprendedoresButton.TabIndex = 6;
            EmprendedoresButton.Text = "Emprendedores";
            EmprendedoresButton.TextAlign = ContentAlignment.MiddleLeft;
            EmprendedoresButton.UseVisualStyleBackColor = true;
            EmprendedoresButton.Click += EmprendedoresButton_Click;
            // 
            // ClienteButton
            // 
            ClienteButton.FlatAppearance.BorderSize = 0;
            ClienteButton.FlatStyle = FlatStyle.Flat;
            ClienteButton.Font = new Font("Segoe UI", 10F);
            ClienteButton.ForeColor = SystemColors.WindowText;
            ClienteButton.Location = new Point(0, 215);
            ClienteButton.Margin = new Padding(0);
            ClienteButton.Name = "ClienteButton";
            ClienteButton.Size = new Size(164, 30);
            ClienteButton.TabIndex = 7;
            ClienteButton.Text = "Clientes";
            ClienteButton.TextAlign = ContentAlignment.MiddleLeft;
            ClienteButton.UseVisualStyleBackColor = true;
            // 
            // RepordetButton
            // 
            RepordetButton.FlatAppearance.BorderSize = 0;
            RepordetButton.FlatStyle = FlatStyle.Flat;
            RepordetButton.Font = new Font("Segoe UI", 10F);
            RepordetButton.ForeColor = SystemColors.WindowText;
            RepordetButton.Location = new Point(0, 245);
            RepordetButton.Margin = new Padding(0);
            RepordetButton.Name = "RepordetButton";
            RepordetButton.Size = new Size(164, 30);
            RepordetButton.TabIndex = 8;
            RepordetButton.Text = "Reportes";
            RepordetButton.TextAlign = ContentAlignment.MiddleLeft;
            RepordetButton.UseVisualStyleBackColor = true;
            // 
            // PanelCentral
            // 
            PanelCentral.Dock = DockStyle.Fill;
            PanelCentral.Location = new Point(170, 0);
            PanelCentral.Margin = new Padding(0);
            PanelCentral.Name = "PanelCentral";
            PanelCentral.Size = new Size(838, 729);
            PanelCentral.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(PanelCentral);
            Controls.Add(PanelMenu);
            Name = "FrmPrincipal";
            Text = "FormPrincipal";
            PanelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private PictureBox pictureBox1;
        private Panel PanelCentral;
        private Button ButtonVenta;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button ProductoButton;
        private Label label1;
        private Button CategoriaButton;
        private Button TipoButton;
        private Button MarcaButton;
        private Label label2;
        private Button EmprendedoresButton;
        private Button ClienteButton;
        private Button RepordetButton;
        private Label label3;
        private Panel panel1;
    }
}