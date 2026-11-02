using Enti.Unagi;
using Serv.Unagi;

namespace WFor.Unagi.User_Control
{
    public partial class UcEmprendedor : UserControl
    {
        private readonly Serv_Emprendedor serv_Emprendedor;
        private List<Emprendedor> Lista;
        private Emprendedor? emprendedor;

        public UcEmprendedor(Serv_Emprendedor serv)
        {
            InitializeComponent();
            serv_Emprendedor = serv;
            try
            {
                Lista = serv_Emprendedor.GetEmprendedors();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al obtener los emprendedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            DgvEmprendedor.Rows.Clear();
            foreach (Emprendedor emprendedor in Lista)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(DgvEmprendedor);
                SetearFila(r, emprendedor);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DgvEmprendedor.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Emprendedor emprendedor)
        {
            r.Cells[0].Value = emprendedor.Id_Emprendedor;
            r.Cells[1].Value = emprendedor.Nombre;
            r.Cells[2].Value = emprendedor.Apellido;
            r.Cells[3].Value = emprendedor.Dni;
            r.Cells[4].Value = emprendedor.Telefono;
            r.Cells[5].Value = emprendedor.Correo;
            r.Tag = emprendedor;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            LPanelAE.Text = "Agregar Emprendedor";
            emprendedor = null;

            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtDni.Clear();
            TxtTelefono.Clear();
            TxtCorreo.Clear();
            errorProvider1.Clear();

            PanelEdicion.Visible = true;

            TxtNombre.Focus();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            PanelEdicion.Visible = false;
            emprendedor = null;
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtDni.Clear();
            TxtTelefono.Clear();
            TxtCorreo.Clear();
            errorProvider1.Clear();
        }

        private void DgvEmprendedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (DgvEmprendedor.Columns[e.ColumnIndex].Name == "ColEditar")
            {
                // verifica si hay una fila seleccionada en la grilla
                if (DgvEmprendedor.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una Emprendedor de la lista para editar.",
                            "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // obtiene el emprendedor seleccionado de la grilla
                emprendedor = (Emprendedor)DgvEmprendedor.CurrentRow.Tag;

                // si el emprendedor no es nulo,
                // se muestra el panel de edicion con los datos del emprendedor
                // creo que presisare una validacion aun que nose cual pero lo intullo 
                if (emprendedor != null)
                {
                    LPanelAE.Text = "Editar Emprendedor";
                    TxtNombre.Text = emprendedor.Nombre;
                    TxtApellido.Text = emprendedor.Apellido;
                    TxtDni.Text = emprendedor.Dni;
                    TxtTelefono.Text = emprendedor.Telefono;
                    TxtCorreo.Text = emprendedor.Correo;
                    errorProvider1.Clear();
                    PanelEdicion.Visible = true;
                    TxtNombre.Focus();
                }

            }

            if (DgvEmprendedor.Columns[e.ColumnIndex].Name == "ColBorrar")
            {
                if (DgvEmprendedor.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una categoría de la lista para eliminar.",
                            "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                emprendedor = (Emprendedor)DgvEmprendedor.CurrentRow.Tag;

                DialogResult dr = MessageBox.Show($"¿Esta Seguro que desea eliminar el emprendedor '{emprendedor.Nombre}'?",
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
                    serv_Emprendedor.EliminarEmprendedor(emprendedor);

                    MessageBox.Show("Emprendedor eliminado correctamente.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Borra la fila directamente de grilla
                    DgvEmprendedor.Rows.Remove(DgvEmprendedor.CurrentRow);
                    // Quita el objeto de tu lista local y resetea la variable
                    Lista.Remove(emprendedor);
                    emprendedor = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al eliminar emprendedor",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                // para diferencias si es un emprendedor nuevo o un existente
                bool esNuevo = (emprendedor is null);


                // si es nuevo, creo una nueva instancia de emprendedor
                if (esNuevo)
                {
                    emprendedor = new Emprendedor();
                }

                // asignar los valores de los controles a el emprendedor
                emprendedor.Nombre = TxtNombre.Text.Trim(); // trim elimina espacios en blanco 
                emprendedor.Apellido = TxtApellido.Text.Trim();
                emprendedor.Dni = TxtDni.Text.Trim();
                emprendedor.Telefono = TxtTelefono.Text.Trim();
                emprendedor.Correo = TxtCorreo.Text.Trim();
                // con el try catch capturamos cualquier error que pueda ocurrir al guardar la categoria
                try
                {
                    if (esNuevo)
                    {
                        // si es nueva, la agrego a la base de datos
                        serv_Emprendedor.AgregarEmprendedor(emprendedor);
                    }
                    else
                    {
                        // si no es nueva, actualizo el emprendedor en la base de datos
                        serv_Emprendedor.EditarEmprendedor(emprendedor);
                    }

                    // se muestra un mensaje de confirmacion 
                    MessageBox.Show("Emprendedor guardado correctamente.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // limpia los controles y oculta el panel de edicion
                    PanelEdicion.Visible = false;
                    emprendedor = null;
                    TxtNombre.Clear();
                    TxtApellido.Clear();
                    TxtDni.Clear();
                    TxtTelefono.Clear();
                    TxtCorreo.Clear();

                    // se actualiza la lista de emprendedores y se muestra en la grilla
                    Lista = serv_Emprendedor.GetEmprendedors();
                    MostrarDatosEnGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al guardar emprendedor",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                errorProvider1.SetError(TxtNombre, "El nombre de la categoría es obligatorio.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtApellido.Text))
            {
                errorProvider1.SetError(TxtApellido, "El apellido del emprendedor es obligatorio.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtDni.Text))
            {
                errorProvider1.SetError(TxtDni, "El DNI del emprendedor es obligatorio.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtTelefono.Text))
            {
                errorProvider1.SetError(TxtTelefono, "El teléfono del emprendedor es obligatorio.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtCorreo.Text))
            {
                errorProvider1.SetError(TxtCorreo, "El correo del emprendedor es obligatorio.");
                return false;
            }
            // si pasa la validacion, retorno true
            return true;
        }

        private void PanelEdicion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
