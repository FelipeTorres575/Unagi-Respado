using Serv.Unagi;
using WFor.Unagi.User_Control;

namespace WFor.Unagi
{
    public partial class FrmPrincipal : Form
    {

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void CargarUserContol(UserControl uc)
        {
            PanelCentral.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            PanelCentral.Controls.Add(uc);
            uc.BringToFront();
        }

        private void CategoriaButton_Click(object sender, EventArgs e)
        {
            CargarUserContol(new UcCategoria(new Serv_Categoria()));
        }

        private void TipoButton_Click(object sender, EventArgs e)
        {
            CargarUserContol(new UcTipo(new Serv_Tipo()));
        }

        private void MarcaButton_Click(object sender, EventArgs e)
        {
            CargarUserContol(new UcMarca(new Serv_Marca(), new Serv_Emprendedor()));
        }

        private void EmprendedoresButton_Click(object sender, EventArgs e)
        {
            CargarUserContol(new UcEmprendedor(new Serv_Emprendedor()));
        }

        private void ProductoButton_Click(object sender, EventArgs e)
        {
            CargarUserContol(new UcProducto(new Serv_Producto()));
        }
    }
}
