using Enti.Unagi;
using Serv.Unagi;

namespace WFor.Unagi
{
    public partial class UcCategoria : UserControl
    {
        private readonly Serv_Categoria serv_Categoria;
        private List<Categoria> categorias;
        private Categoria? categoria;

        public UcCategoria(Serv_Categoria _serv_Categoria)
        {
            InitializeComponent();
            serv_Categoria = _serv_Categoria;
            try
            {
                categorias = serv_Categoria.GetCategorias();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar categorías",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            DgvCategoria.Rows.Clear();
            foreach (Categoria categoria in categorias)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(DgvCategoria);
                SetearFila(r, categoria);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DgvCategoria.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Categoria categoria)
        {
            r.Cells[0].Value = categoria.Id_Categoria;
            r.Cells[1].Value = categoria.Nombre;

            r.Tag = categoria;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                // para diferencias si es una categoria nueva o una existente
                bool esNuevo = (categoria is null);

                // si es nueva, creo una nueva instancia de categoria
                if (esNuevo)
                {
                    categoria = new Categoria();
                }

                // asignar los valores de los controles a la categoria
                categoria.Nombre = NombreTxt.Text.Trim(); // trim elimina espacios en blanco 

                // con el try catch capturamos cualquier error que pueda ocurrir al guardar la categoria
                try
                {
                    if (esNuevo)
                    {
                        // si es nueva, la agrego a la base de datos
                        serv_Categoria.AgregarCategoria(categoria);
                    }
                    else
                    {
                        // si no es nueva, actualizo la categoria en la base de datos
                        serv_Categoria.EditarCategoria(categoria);
                    }

                    // se muestra un mensaje de confirmacion 
                    MessageBox.Show("Categoria guardada correctamente.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // limpia los controles y oculta el panel de edicion
                    PanelEdicion.Visible = false;
                    categoria = null;
                    NombreTxt.Clear();

                    // se actualiza la lista de categorias y se muestra en la grilla
                    categorias = serv_Categoria.GetCategorias();
                    MostrarDatosEnGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al guardar categoría",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            // reviso si el nombre de la categoria esta vacio o nulo
            if (string.IsNullOrWhiteSpace(NombreTxt.Text))
            {
                // si es nulo o vacio, muestro un mensaje de error y retorno false
                errorProvider1.SetError(NombreTxt, "El nombre de la categoría es obligatorio.");
                return false;
            }
            // si pasa la validacion, retorno true
            return true;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            // al presionar agregar, se limpia el panel de edicion y
            // se muestra para ingresar una nueva categoria
            LPanelAE.Text = "Agregar Categoria";
            categoria = null;

            // limpiar los controles del panel de edicion
            NombreTxt.Clear();
            errorProvider1.Clear();

            // mostrar el panel de edicion
            PanelEdicion.Visible = true;

            // poner el foco en el control de nombre
            NombreTxt.Focus();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            // al presionar cancelar, se oculta el panel de edicion
            // y se limpia la categoria seleccionada
            PanelEdicion.Visible = false;

            categoria = null;

            NombreTxt.Clear();
            errorProvider1.Clear();
        }

        private void DgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if(DgvCategoria.Columns[e.ColumnIndex].Name== "colEditar")
            {
                // verifica si hay una fila seleccionada en la grilla
                if (DgvCategoria.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una categoría de la lista para editar.",
                            "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // obtiene la categoria seleccionada de la grilla
                categoria = (Categoria)DgvCategoria.CurrentRow.Tag;

                // si la categoria no es nula,
                // se muestra el panel de edicion con los datos de la categoria
                // creo que presisare una validacion aun que nose cual pero lo intullo 
                if (categoria != null)
                {
                    LPanelAE.Text = "Editar Categoria";
                    NombreTxt.Text = categoria.Nombre;
                    errorProvider1.Clear();
                    PanelEdicion.Visible = true;
                    NombreTxt.Focus();
                }
            }

            if(DgvCategoria.Columns[e.ColumnIndex].Name== "colBorrar")
            {
                if (DgvCategoria.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una categoría de la lista para eliminar.",
                            "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                categoria = (Categoria)DgvCategoria.CurrentRow.Tag;

                DialogResult dr = MessageBox.Show($"¿Esta Seguro que desea eliminar la categoría '{categoria.Nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.No)
                {
                    return;
                }

                try
                {
                    // Elimina en la Base de Datos
                    serv_Categoria.EliminarCategoria(categoria);

                    MessageBox.Show("Categoría eliminada correctamente.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Borra la fila directamente de grilla
                    DgvCategoria.Rows.Remove(DgvCategoria.CurrentRow);

                    // Quita el objeto de tu lista local y resetea la variable
                    categorias.Remove(categoria);
                    categoria = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al eliminar categoría",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
