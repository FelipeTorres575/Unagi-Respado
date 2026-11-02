using Enti.Unagi;
using Serv.Unagi;

namespace WFor.Unagi
{
    public partial class UcProducto : UserControl
    {
        private readonly Serv_Producto servProducto;
        private readonly Serv_Marca servMarca = new Serv_Marca();
        private readonly Serv_Tipo servTipo = new Serv_Tipo();
        private List<Producto> listaProductos;
        private Producto? producto;

        public UcProducto(Serv_Producto _servProducto)
        {
            servProducto = _servProducto;
            InitializeComponent();

            try
            {
                listaProductos = servProducto.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar Producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void MostrarDatosEnGrilla()
        {
            DgvProducto.Rows.Clear();
            foreach (Producto producto in listaProductos)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(DgvProducto);
                SetearFila(r, producto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DgvProducto.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Producto producto)
        {
            r.Cells[0].Value = producto.Id_Productos;
            r.Cells[1].Value = producto.Nombre;

            r.Cells[4].Value = producto.Descripcion;
            r.Cells[5].Value = producto.Precio;
            r.Cells[6].Value = producto.Stock;
            // llama a la propiedad de navegacion
            r.Cells[2].Value = producto.tipo.Nombre;
            r.Cells[3].Value = producto.marca.Nombre;
            r.Tag = producto;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            LPanelAE.Text = "Agregar Producto";
            producto = null;

            //Inicializar

            TxtNombre.Clear();
            CargarComboMarca();
            CargarComboTipo();
            TxtDescripcion.Clear();
            NUDPrecio.Value = 0;
            NUDStock.Value = 0;
            //Fotos 

            errorProvider1.Clear();

            LPanelAE.Visible = true;

            TxtNombre.Focus();
        }

        private void CargarComboTipo()
        {
            try
            {
                List<Tipo> listaTipo = servTipo.GetTipos();

                CbxTipo2.DisplayMember = "Nombre";
                CbxTipo2.ValueMember = "Id_Categoria";

                CbxTipo2.DataSource = listaTipo;
                CbxTipo2.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar Tipos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarComboMarca()
        {
            try
            {
                List<Marca> lista = servMarca.GetMarcas();

                CbxMarca.DisplayMember = "Nombre";
                CbxMarca.ValueMember = "Id_Marca";

                CbxMarca.DataSource = lista;
                CbxMarca.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar Marca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void DgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            // editar tipo
            if (DgvProducto.Columns[e.ColumnIndex].Name == "ColEditar")
            {
                if (DgvProducto.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un producto de la lista para editar.",
                            "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                producto = (Producto)DgvProducto.CurrentRow.Tag;

                if (producto != null)
                {
                    LPanelAE.Text = "Editar Producto";
                    TxtNombre.Text = producto.Nombre;

                    CargarComboTipo();
                    CbxTipo2.SelectedValue = producto.Id_Tipo;
                    CargarComboMarca();
                    CbxMarca.SelectedValue = producto.Id_Marca;
                    
                    TxtDescripcion.Text=producto.Descripcion;

                    NUDPrecio.Value = producto.Precio;
                    NUDStock.Value = producto.Stock;

                    errorProvider1.Clear();
                    LPanelAE.Visible = true;
                    TxtNombre.Focus();
                }

            }
            // borrar tipo
            if (DgvProducto.Columns[e.ColumnIndex].Name == "ColBorrar")
            {
                if (DgvProducto.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un producto de la lista para eliminar.",
                            "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                producto = (Producto)DgvProducto.CurrentRow.Tag;

                if (producto != null)
                {
                    DialogResult dr = MessageBox.Show($"¿Desea eliminar el producto {producto.Nombre}?",
                        "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            servProducto.Eliminar(producto.Id_Productos);
                            listaProductos.Remove(producto);
                            DgvProducto.Rows.Remove(DgvProducto.CurrentRow);
                            MessageBox.Show("Producto eliminado correctamente.", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error al eliminar Producto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            LPanelAE.Visible = false;

            producto = null;

            TxtNombre.Clear();
            errorProvider1.Clear();

            // CBoxCategoria.SelectedIndex = -1;
            // ya esta en el metodo CargarComboCategorias() 
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                bool esNuevo = producto == null;

                if (esNuevo)
                {
                    producto = new Producto();
                }

                Tipo tipoSeleccionada = (Tipo)CbxTipo2.SelectedItem;
                Marca marcaSeleccionada = (Marca)CbxMarca.SelectedItem;

                producto.Nombre = TxtNombre.Text;
                producto.Id_Marca = marcaSeleccionada.Id_Marca;
                producto.Id_Tipo = tipoSeleccionada.Id_Tipo;

                try
                {
                    if (esNuevo)
                    {
                        servProducto.Agregar(producto);
                    }
                    else
                    {
                        servProducto.Editar(producto);
                    }

                    MessageBox.Show("Producto guardado correctamente.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // limpia los controles y oculta el panel de edicion
                    LPanelAE.Visible = false;
                    producto = null;
                    TxtNombre.Clear();

                    // se actualiza la lista de productos y se muestra en la grilla
                    listaProductos = servProducto.GetLista();
                    MostrarDatosEnGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al guardar Producto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            // reviso si el nombre de la categoria esta vacio o nulo
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                // si es nulo o vacio, muestro un mensaje de error y retorno false
                errorProvider1.SetError(TxtNombre, "El nombre del Producto es obligatorio.");
                return false;
            }
            // si pasa la validacion, retorno true
            return true;
        }


    }
}

