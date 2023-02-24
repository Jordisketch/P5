using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {
        //propiedades simples
        public int UsuarioID { get; set; }
        public string UsuarioCorreo { get; set; }
        public string UsuarioContrasennia { get; set; }
        public string UsuarioNombre { get; set; }
        public string UsuarioCedula { get; set; }
        public string UsuarioTelefono { get; set; }
        public string  UsuarioDireccion { get; set; }
        public bool Activo { get; set; }

        //propiedaes compuestas 
        Usuario_Rol MiRolTipo { get; set; }

        //normalmente cuando tenemos propiedades compuestas con tipos que 
        //hemos programado nosotros mismos, debemos instanciar dichas propiedaes
        //ya que son Objetos. 
        //para esto recomiendo hacerlo en el constructor de la clase 
        public Usuario()
        {
            //al crear una nueva instancia de la clase Usuario, se ejecuta el código
            //de este constructor, y también se crea una nueva instacia de la clase
            //usuario_rol para el objeto MiRolTipo.
            MiRolTipo = new Usuario_Rol();
        }

        //Funciones y métodos 
        public bool Agregar()
        {
            //cuando la función devuelve un bool me gusta inicializar la variable de 
            //retorno en false (tiende a negativo el resultado de la fn) 
            //y SOLO si la operación (en este caso Insert) sale correcta 
            // se cambia el valor de R a true.
            bool R = false;

            //acá va el código funcional que invoca a un procedimiento almacenado 
            //que contiene el DML Insert

            return R;
        }

        public bool Editar()
        {
            bool R = false; 

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;

            return R;
        }

        public DataTable ListarActivos() { 
            DataTable R = new DataTable();

            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            return R;
        }

        public Usuario ValidarUsuario(string pEmail, string pContrasennia)
        { 
            Usuario R = new Usuario();

            

            return R;
        }


    }
}
