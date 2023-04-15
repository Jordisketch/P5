using System.ComponentModel.Design;
using System.Windows.Forms;

namespace P520231_AllanD
{
    public static class Globales
    {
        //Estas propiedas al pertenecer a una clase static se auto instancian 
        //y se puede obtener acceso a ellas en la globalidad de la aplicación. 

        public static Form MiFormPrincipal = new Formularios.FrmMDI();

        public static Formularios.FrmUsuariosGestion MiFormGestionUsuarios = new Formularios.FrmUsuariosGestion();

        //Debemos tener un obj de tipo Usuario que permita almacenar los datos del usuario
        //que se haya logueado correctamente 
        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();


    }
}
