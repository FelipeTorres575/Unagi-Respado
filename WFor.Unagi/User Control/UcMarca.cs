using Enti.Unagi;
using Serv.Unagi;

namespace WFor.Unagi
{
    public partial class UcMarca : UserControl
    {
        private readonly Serv_Marca servMarca;
        private readonly Serv_Emprendedor servEmprendedor;
        private List<Marca> listaMarcas;
        private Marca? marca;
        public UcMarca(Serv_Marca serv_Marca, Serv_Emprendedor serv_Emprendedor)
        {
            servMarca = serv_Marca;
            servEmprendedor = serv_Emprendedor;
            InitializeComponent();
            try
            {
                listaMarcas = servMarca.GetMarcas();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar Marca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            DgvMarca.Rows.Clear();
            foreach (Marca marca in listaMarcas)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(DgvMarca);
                SetearFila(r, marca);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DgvMarca.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Marca marca)
        {
            r.Cells[0].Value = marca.Id_Marca;
            r.Cells[1].Value = marca.Nombre;
            // llama a la propiedad de navegacion
            r.Cells[2].Value = marca.emprendedor.NombreCompleto;
            r.Tag = marca;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            LPanelAE.Text = "Agregar Marca";

            TxtNombre.Clear();
            CargarComboEmprendedor();
            errorProvider1.Clear();

            PanelEdicion.Visible = true;
            TxtNombre.Focus();

        }

        private void CargarComboEmprendedor()
        {
            try
            {
                List<Emprendedor> listaEmprendedores = servEmprendedor.GetEmprendedors();

                CboxEmprendedores.DisplayMember = "NombreCompleto";
                CboxEmprendedores.ValueMember = "Id_Emprendedor";

                CboxEmprendedores.DataSource = listaEmprendedores;
                CboxEmprendedores.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar Emprendedor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DgvMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (DgvMarca.Columns[e.ColumnIndex].Name == "ColEditar")
            {
                if (DgvMarca.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una marca de la lista para editar.",
                            "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                marca = (Marca)DgvMarca.CurrentRow.Tag;
                if (marca != null)
                {
                    LPanelAE.Text = "Editar Marca";
                    TxtNombre.Text = marca.Nombre;
                    CargarComboEmprendedor();
                    CboxEmprendedores.SelectedValue = marca.Id_Emprendedor;
                    errorProvider1.Clear();
                    PanelEdicion.Visible = true;
                    TxtNombre.Focus();
                }

            }
            // borrar marca
            if (DgvMarca.Columns[e.ColumnIndex].Name == "ColBorrar")
            {
                if (DgvMarca.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una marca de la lista para eliminar.",
                            "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                marca = (Marca)DgvMarca.CurrentRow.Tag;
                if (marca != null)
                {
                    DialogResult dr = MessageBox.Show($"¿Desea eliminar la marca {marca.Nombre}?",
                        "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            servMarca.EliminarMarca(marca);
                            listaMarcas.Remove(marca);
                            DgvMarca.Rows.Remove(DgvMarca.CurrentRow);
                            MessageBox.Show("Marca eliminada correctamente.", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error al eliminar Marca",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                bool esNuevo = marca == null;

                if (esNuevo)
                {
                    marca = new Marca();
                }

                Emprendedor emprendedorSeleccionado = (Emprendedor)CboxEmprendedores.SelectedItem;

                marca.Nombre = TxtNombre.Text;
                marca.Id_Emprendedor = emprendedorSeleccionado.Id_Emprendedor;
                // marca.Logo ya se asigna cuando se selecciona el archivo de imagen
                // por lo tanto no es necesario reasignarlo aquí

                try
                {
                    if (esNuevo)
                    {
                        servMarca.AgregarMarca(marca);
                    }
                    else
                    {
                        servMarca.EditarMarca(marca);
                        // posible actualizacion de la fila en el DataGridView
                        // este sirve para actualizar la fila en el DataGridView
                        //DataGridViewRow r = DgvTipo.SelectedRows[0];
                        //SetearFila(r, tipo);
                    }

                    MessageBox.Show("Marca guardada correctamente.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // limpia los controles y oculta el panel de edicion
                    PanelEdicion.Visible = false;
                    marca = null;
                    TxtNombre.Clear();

                    // se actualiza la lista de marcas y se muestra en la grilla
                    listaMarcas = servMarca.GetMarcas();
                    MostrarDatosEnGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al guardar Marca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            PanelEdicion.Visible = false;

            marca = null;

            TxtNombre.Clear();
            CboxEmprendedores.SelectedIndex = -1;
            errorProvider1.Clear();
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            // reviso si el nombre de la categoria esta vacio o nulo
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                // si es nulo o vacio, muestro un mensaje de error y retorno false
                errorProvider1.SetError(TxtNombre, "El nombre de la Tipo es obligatorio.");
                return false;
            }
            // si pasa la validacion, retorno true
            return true;
        }

        private void BtmBuscarLogo_Click(object sender, EventArgs e)
        {
            //buscar como hacer esto
        }
    }
}
