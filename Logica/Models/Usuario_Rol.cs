using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario_Rol
    {
        //Primero se digitan las propiedades de la clase 

        public int UsuarioRolID { get; set; }

        //private int usuarioRolID;
        //public int UsuarioRolID
        //{
        //    get { return usuarioRolID; }
        //    set { usuarioRolID = value; }
        //}

        public string UsuarioRolDescripcion { get; set; }

        //luego de escribir las propiedades simples se digitan 
        //las propiedades compuestas (en este caso no hay)  

        //Por ultimo se escriben las funciones y métodos. 
        public DataTable Listar()
        {
            DataTable R = new DataTable();

            //aquí va la programacion indicada en el diagrama de
            //secuencias.
            
            return R;

        }




    }
}
