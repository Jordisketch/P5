using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231_AllanD.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //CIERRA LA APP
            Application.Exit();
        }

        private void BtnVerContrasennia_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false;
        }

        private void BtnVerContrasennia_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = true;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

            //validas que se haya digitado un usuario y contraseña 
            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
            {
                string usuario = TxtEmail.Text.Trim();
                string contrasennia = TxtContrasennia.Text.Trim();

                //tratar de validar que los datos digitados sean correctos 
                //En caso que la validación sea correcta, aplicamos los valores al usuario global
                Globales.MiUsuarioGlobal = Globales.MiUsuarioGlobal.ValidarUsuario(usuario, contrasennia);

                

            }
            else
            {
                MessageBox.Show("Faltan datos requeridos!", "Error de validación", MessageBoxButtons.OK);
            }


            Globales.MiFormPrincipal.Show();

            this.Hide();

        }
    }
}
