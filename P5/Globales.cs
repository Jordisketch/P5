﻿using System.ComponentModel.Design;
using System.Windows.Forms;

namespace P5
{
    public static class Globales
    {
        //Estas propiedas al pertenecer a una clase static se auto instancian 
        //y se puede obtener acceso a ellas en la globalidad de la aplicación. 

        public static Form MiFormPrincipal = new Formularios.FrmMDI();

        public static Formularios.FrmUsuariosGestion MiFormGestionUsuarios = new Formularios.FrmUsuariosGestion();
        public static Formularios.FrmProveedor MiFormGestionProveedores = new Formularios.FrmProveedor();

        //Debemos tener un obj de tipo Usuario que permita almacenar los datos del usuario
        //que se haya logueado correctamente 
        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();

        public static Logica.Models.Proveedor MiProveedorGlobal = new Logica.Models.Proveedor();

        public static Formularios.FrmRegistroCompra MiFormRegistroCompra = new Formularios.FrmRegistroCompra();


    }
}
