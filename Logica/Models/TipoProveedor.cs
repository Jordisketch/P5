using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class TipoProveedor
    {
        public int ProveedorTipo { get; set; }
        public string ProveedorTipoDescripcion { get; set; }

        public DataTable Listar()
        {
            // Create a new DataTable and add two columns to it
            DataTable R = new DataTable();

            // Return the DataTable
            return R;
        }


    }
}
