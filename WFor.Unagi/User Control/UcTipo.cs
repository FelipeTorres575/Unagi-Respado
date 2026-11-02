using Enti.Unagi;
using Serv.Unagi;

namespace WFor.Unagi
{
    public partial class UcTipo : UserControl
    {
        private readonly Serv_Tipo servTipo;
        private readonly Serv_Categoria servCategoria = new Serv_Categoria();
        private List<Tipo> listaTipos;
        private Tipo? tipo;

        public UcTipo(Serv_Tipo _servTipo)
        {
            InitializeComponent();
            servTipo = _servTipo;

            try
            {
                listaTipos = servTipo.GetTipos();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar Tipo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void MostrarDatosEnGrilla()
        {
            DgvTipo.Rows.Clear();
            foreach (Tipo tipo in listaTipos)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(DgvTipo);
                SetearFila(r, tipo);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DgvTipo.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Tipo tipo)
        {
            r.Cells[0].Value = tipo.Id_Tipo;
            r.Cells[1].Value = tipo.Nombre;
            // llama a la propiedad de navegacion
            r.Cells[2].Value = tipo.categoria.Nombre;
            r.Tag = tipo;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            LPanelAE.Text = "Agregar Tipo";
            tipo = null;

            TxtNombre.Clear();
            CargarComboCategorias();
            errorProvider1.Clear();

            PanelEdicion.Visible = true;

            TxtNombre.Focus();
        }

        private void CargarComboCategorias()
        {
            try
            {
                List<Categoria> listaCategorias = servCategoria.GetCategorias();

                CBoxCategoria.DisplayMember = "Nombre";
                CBoxCategoria.ValueMember = "Id_Categoria";

                CBoxCategoria.DataSource = listaCategorias;
                CBoxCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar Categorías",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DgvTipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            // editar tipo
            if (DgvTipo.Columns[e.ColumnIndex].Name == "ColEditar") 
            {
                if(DgvTipo.CurrentRow == null) 
                {
                    MessageBox.Show("Seleccione una tipo de la lista para editar.",
                            "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                tipo=(Tipo)DgvTipo.CurrentRow.Tag;

                if (tipo != null)
                {
                    LPanelAE.Text = "Editar Tipo";
                    TxtNombre.Text = tipo.Nombre;
                    CargarComboCategorias();
                    CBoxCategoria.SelectedValue = tipo.Id_Categoria;
                    errorProvider1.Clear();
                    PanelEdicion.Visible = true;
                    TxtNombre.Focus();
                }
                
            }
            // borrar tipo
            if (DgvTipo.Columns[e.ColumnIndex].Name== "ColBorrar")
            {
                if (DgvTipo.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una tipo de la lista para eliminar.",
                            "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
             
                tipo = (Tipo)DgvTipo.CurrentRow.Tag;
                
                if (tipo != null)
                {
                    DialogResult dr = MessageBox.Show($"¿Desea eliminar el tipo {tipo.Nombre}?",
                        "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            servTipo.EliminarTipo(tipo.Id_Tipo);
                            listaTipos.Remove(tipo);
                            DgvTipo.Rows.Remove(DgvTipo.CurrentRow);
                            MessageBox.Show("Tipo eliminada correctamente.", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error al eliminar Tipo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            PanelEdicion.Visible = false;

            tipo = null;

            TxtNombre.Clear();
            errorProvider1.Clear();

            // CBoxCategoria.SelectedIndex = -1;
            // ya esta en el metodo CargarComboCategorias() 
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                bool esNuevo = tipo == null;

                if (esNuevo)
                {
                    tipo = new Tipo();
                }

                Categoria categoriaSeleccionada = (Categoria)CBoxCategoria.SelectedItem;

                tipo.Nombre = TxtNombre.Text;
                tipo.Id_Categoria = categoriaSeleccionada.Id_Categoria;
                try
                {
                    if (esNuevo)
                    {
                        servTipo.AgregarTipo(tipo);
                    }
                    else
                    {
                        servTipo.EditarTipo(tipo);
                        // posible actualizacion de la fila en el DataGridView
                        // este sirve para actualizar la fila en el DataGridView
                        //DataGridViewRow r = DgvTipo.SelectedRows[0];
                        //SetearFila(r, tipo);
                    }

                    MessageBox.Show("Tipo guardada correctamente.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // limpia los controles y oculta el panel de edicion
                    PanelEdicion.Visible = false;
                    tipo = null;
                    TxtNombre.Clear();

                    // se actualiza la lista de tipos y se muestra en la grilla
                    listaTipos = servTipo.GetTipos();
                    MostrarDatosEnGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al guardar Tipo",
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
                errorProvider1.SetError(TxtNombre, "El nombre de la Tipo es obligatorio.");
                return false;
            }
            // si pasa la validacion, retorno true
            return true;
        }
    }
}
