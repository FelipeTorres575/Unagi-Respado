using Enti.Unagi;
using Serv.Unagi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFor.Unagi
{
    public partial class FrmCategoria : Form
    {
        // instaciar el servicio de categoria
        private readonly Serv_Categoria _serv_Categoria;
        // instaciar la lista de categorias
        private List<Categoria> _categorias = new();

        // constructor de la clase FrmCategoria sobrecargado
        public FrmCategoria(Serv_Categoria serv_Categoria)
        {
            _serv_Categoria = serv_Categoria;
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            _categorias = _serv_Categoria.GetCategorias();
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            //limpio la grilla
            dvg_Categoria.Rows.Clear();
            
            foreach (var categoria in _categorias)
            {
                // genero una fila por cada categoria
                DataGridViewRow r = new DataGridViewRow();

                // 
                r.CreateCells(dvg_Categoria);
                SetearFila(r, categoria);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dvg_Categoria.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Categoria categoria)
        {
            r.Cells[0].Value = categoria.Id_Categoria;
            r.Cells[1].Value = categoria.Nombre;
        }
    }
}
