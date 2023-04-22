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
                Globales.MiUsuarioGlobal = Globales.MiUsuarioGlobal.ValidarUsuario(usuario, contrasennia);

                if (Globales.MiUsuarioGlobal.UsuarioID > 0)
                {

                    Globales.MiFormPrincipal.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectas...", "Error de validación", MessageBoxButtons.OK);

                    TxtContrasennia.Focus();
                    TxtContrasennia.SelectAll();

                }
            }
            else
            {
                MessageBox.Show("Faltan datos requeridos.", "Error de validación", MessageBoxButtons.OK);
            }
            

        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift & e.Alt & e.KeyCode == Keys.A)
            {
                //si presionamos shift + tab + a
                BtnIngresoDirecto.Visible = true;
            }

        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            Globales.MiFormPrincipal.Show();

            this.Hide();
        }
    }
}
