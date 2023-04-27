using Logica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5.Formularios
{
    public partial class FrmProveedor : Form
    {

        private Logica.Models.Proveedor MiProveedor { get; set; }
        private Logica.Models.TipoProveedor TipoProveedor { get; set; }


        private DataTable ListaProveedores { get; set; }
        public FrmProveedor() => InitializeComponent();

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            cargarProveedores();
            cargarTiposProveedores();
        }

        private void cargarProveedores()
        {
            DataTable dataTable = MiProveedor.Listar();
            dataGridView1.DataSource = dataTable;
        }

        private void cargarTiposProveedores()
        {
            DataTable dataTable = TipoProveedor.Listar();
            ComboTipoProveedor.DataSource = dataTable;
        }

        private void guardarClick(object sender, EventArgs e)
        {
            // valida que el formulario venga completo
            if (string.IsNullOrEmpty(TxtDireccionProveedor.Text.Trim())||string.IsNullOrEmpty(TxtCedulaProveedor.Text.Trim())|| (string.IsNullOrEmpty(TxtEmailProveedor.Text.Trim()) || string.IsNullOrEmpty(TxtNombreProveedor.Text.Trim()) || string.IsNullOrEmpty(TxtNotasProveedor.Text.Trim()) || !RadioActivoProveedorNo.Checked && !RadioActivoProveedorSi.Checked || ComboTipoProveedor.SelectedIndex == -1))
            {
                MessageBox.Show("Debe llenar el formulario", "Error de validación", MessageBoxButtons.OK);
                return;
            }

            //crea el objeto proveedor para despues guardarlo
            Proveedor proveedor = new Proveedor();

            proveedor.ProveedorCedula = TxtCedulaProveedor.Text.Trim();
            proveedor.ProveedorDireccion = TxtDireccionProveedor.Text.Trim();
            proveedor.ProveedorNombre = TxtNombreProveedor.Text.Trim();
            proveedor.ProveedorNotas = TxtNotasProveedor.Text.Trim();
            proveedor.Activo = RadioActivoProveedorNo.Checked;
            proveedor.MiTipoProveedor.ProveedorTipo = Convert.ToInt32(ComboTipoProveedor.SelectedValue);

            if (Globales.MiProveedorGlobal.Agregar(proveedor))
            {
                MessageBox.Show("Datos guardados correctamente", "Datos guardados", MessageBoxButtons.OK);
                cargarProveedores();
            }
            else
            {
                MessageBox.Show("Error al guardar los datos, intente de nuevo", "Error al guardar los datos", MessageBoxButtons.OK);

            }

        }

        private void LimpiarFormulario(object sender, EventArgs e)
        {
            TxtCedulaProveedor.Clear();
            TxtDireccionProveedor.Clear();
            TxtNombreProveedor.Clear();
            TxtNotasProveedor.Clear();
            RadioActivoProveedorNo.Checked = true;
            RadioActivoProveedorSi.Checked = false;
        }
    }
}
