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
    public partial class FrmUsuariosGestion : Form
    {
        //por orden es mejor crear objetos locales que permitan 
        //la gestión del tema que estamos tratando. 
        //usar objetos individuales en las funcion puede provocar desorden y 
        //complicar más la lectura del código fuente. 

        //objeto local para usuario 
        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        //lista local de usuarios que se visualizan en el datagridview
        private DataTable ListaUsuarios { get; set; }


        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();
            ListaUsuarios = new DataTable();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            //definimos el padre mdi 
            MdiParent = Globales.MiFormPrincipal;

            CargarListaRoles();

            CargarListaDeUsuarios();

            ActivarAgregar();

        }

        private void CargarListaDeUsuarios()
        {
            //resetear la lista de usuarios haciendo re instancia del objeto
            ListaUsuarios = new DataTable();

            if (CboxVerActivos.Checked)
            {
                ListaUsuarios = MiUsuarioLocal.ListarActivos();
            }
            else
            {
                ListaUsuarios = MiUsuarioLocal.ListarInactivos();
            }

            DgLista.DataSource = ListaUsuarios;

        }



        private void CargarListaRoles()
        {
            Logica.Models.Usuario_Rol MiRol = new Logica.Models.Usuario_Rol();

            DataTable dt = new DataTable();
            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbRolesUsuario.ValueMember = "ID";
                CbRolesUsuario.DisplayMember = "Descrip";
                CbRolesUsuario.DataSource = dt;
                CbRolesUsuario.SelectedIndex = -1;
            }
        }

        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
        }

        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarEditarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cuando seleccionemos una fila del datagrid se debe cargar la info de dicho usuario
            //en el usuario local y luego dibujar esa info en los controles graficos 

            if (DgLista.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                //de la colección de filas seleccionadas (que en este caso es solo una) 
                //seleccionamos la fila en indice 0, o sea la primera 
                DataGridViewRow MiFila = DgLista.SelectedRows[0];

                //lo que necesito es el valor del ID del usuario para realizaer la consulta 
                //y traer todos los datos para llenar el objeto de usuario local 
                int IdUsuario = Convert.ToInt32(MiFila.Cells["CUsuarioID"].Value);

                //para no asumir riesgos se reinstancia el usuario local 
                MiUsuarioLocal = new Logica.Models.Usuario();

                //ahora le agregarmos el valor obtenido por la fila al ID del usuario local
                MiUsuarioLocal.UsuarioID = IdUsuario;

                //una vez que tengo el objeto local con el valor del id, puedo ir a consultar
                //el usuario por ese id y llenar el resto de atributos. 
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorIDRetornaUsuario();

                //validamos que el usuario local tenga datos 

                if (MiUsuarioLocal != null && MiUsuarioLocal.UsuarioID > 0)
                {
                    //si cargamos correctamente el usuario local llenamos los controles 

                    TxtUsuarioID.Text = Convert.ToString(MiUsuarioLocal.UsuarioID);

                    TxtUsuarioNombre.Text = MiUsuarioLocal.UsuarioNombre;

                    TxtUsuarioCedula.Text = MiUsuarioLocal.UsuarioCedula;

                    TxtUsuarioTelefono.Text = MiUsuarioLocal.UsuarioTelefono;

                    TxtUsuarioCorreo.Text = MiUsuarioLocal.UsuarioCorreo;

                    TxtUsuarioDireccion.Text = MiUsuarioLocal.UsuarioDireccion;

                    //combobox 
                    CbRolesUsuario.SelectedValue = MiUsuarioLocal.MiRolTipo.UsuarioRolID;

                    ActivarEditarEliminar();

                }



            }


        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();

            DgLista.ClearSelection();

            ActivarAgregar();
        }

        private void LimpiarFormulario()
        {
            TxtUsuarioID.Clear();
            TxtUsuarioNombre.Clear();
            TxtUsuarioCedula.Clear();
            TxtUsuarioTelefono.Clear();
            TxtUsuarioCorreo.Clear();
            TxtUsuarioContrasennia.Clear();

            CbRolesUsuario.SelectedIndex = -1;

            TxtUsuarioDireccion.Clear();
        }


        private bool ValidarDatosDigitados(bool OmitirPassword = false)
        {
            //evalúa que se hayan digitado los campos de texto en el formulario 
            bool R = false;

            if (!string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()) &&
                CbRolesUsuario.SelectedIndex > -1)
            {

                if (OmitirPassword)
                {
                    //(PARA EDITAR) Si el password se omite entonces ya pasó la evaluacíón a este punto, retorna true
                    R = true;
                }
                else
                {
                    //(PARA AGREGAR) en caso en el que haya que evaluar la contraseña se debe agregar otra condición 
                    //logica
                    if (!string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                    {
                        R = true;
                    }
                    else
                    {
                        //en caso en el que haga falta la contraseña, se le indica al usuario
                        MessageBox.Show("Debe digitar una contraseña para el usuario", "Error de validación", MessageBoxButtons.OK);
                        TxtUsuarioContrasennia.Focus();
                        return false;

                    }

                }

            }
            else
            {
                //qué pasa cuando algo falta? 
                if (string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un nombre para el usuario", "Error de validación", MessageBoxButtons.OK);
                    TxtUsuarioNombre.Focus();
                    return false;
                }

                //cedula
                if (string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una cédula para el usuario", "Error de validación", MessageBoxButtons.OK);
                    TxtUsuarioCedula.Focus();
                    return false;
                }

                //telefono
                if (string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un teléfono para el usuario", "Error de validación", MessageBoxButtons.OK);
                    TxtUsuarioTelefono.Focus();
                    return false;
                }

                //correo
                if (string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un correo para el usuario", "Error de validación", MessageBoxButtons.OK);
                    TxtUsuarioCorreo.Focus();
                    return false;
                }


                //rol de usuario
                if (CbRolesUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un rol para el usuario", "Error de validación", MessageBoxButtons.OK);
                    CbRolesUsuario.Focus();
                    return false;
                }

            }

            return R;
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {

                //estas variables almacenan el resultado de las consultas por correo y cedula

                bool CedulaOK;
                bool EmailOK;

                //pasos 1.1 y 1.2
                MiUsuarioLocal = new Logica.Models.Usuario();

                //llenar los valores de los atributos con los datos digitados en el form
                MiUsuarioLocal.UsuarioNombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.UsuarioCedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.UsuarioTelefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.UsuarioCorreo = TxtUsuarioCorreo.Text.Trim();
                MiUsuarioLocal.UsuarioContrasennia = TxtUsuarioContrasennia.Text.Trim();
                //composición del rol 
                MiUsuarioLocal.MiRolTipo.UsuarioRolID = Convert.ToInt32(CbRolesUsuario.SelectedValue);
                MiUsuarioLocal.UsuarioDireccion = TxtUsuarioDireccion.Text.Trim();

                //Realizar las consultas por email y por cedula 
                //pasos 1.3 y 1.3.6
                CedulaOK = MiUsuarioLocal.ConsultarPorCedula();

                //pasos 1.4 y 1.4.6 
                EmailOK = MiUsuarioLocal.ConsultarPorEmail();

                //paso 1.5
                if (CedulaOK == false && EmailOK == false)
                {
                    //se puede agregar el usuario ya que no existe un usuario con la cedula y correo
                    //digitados. 

                    //se solicita al usuario confirmación de si queire agregar o no al usuario 

                    string msg = string.Format("¿Está seguro que desea agregar al usuario {0}?", MiUsuarioLocal.UsuarioNombre);

                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MiUsuarioLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Usuario guardado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();

                            CargarListaDeUsuarios();

                        }
                        else
                        {
                            MessageBox.Show("El Usuario no se pudo guardar!", ":/", MessageBoxButtons.OK);
                        }



                    }


                }
                else
                {
                    //indicar al usuari si falla alguna consulta

                    if (CedulaOK)
                    {
                        MessageBox.Show("Ya existe un usuario con la cédula digitada", "Error de Validación", MessageBoxButtons.OK);
                        return;
                    }

                    if (EmailOK)
                    {
                        MessageBox.Show("Ya existe un usuario con el correo digitado", "Error de Validación", MessageBoxButtons.OK);
                        return;
                    }

                }


            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados(true))
            {
                //no es necesario capturar el ID desde el cuadro de texto ya que al consultarlo (cuando seleccionamos el usuario
                //del datagrid), ya tenemos datos en el ID
                //Este ID NO PUEDE SER MODIFICADO, los demás atributos si. 

                MiUsuarioLocal.UsuarioNombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.UsuarioCedula = TxtUsuarioCedula.Text.Trim();    
                MiUsuarioLocal.UsuarioTelefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.UsuarioCorreo = TxtUsuarioCorreo.Text.Trim();

                //como el cuadro de texto de la contraseña tiene un caracter en blanco 
                //puedo asignar sin problema el valor de cuadro de texto al atributo, en el SP
                //se evalúa si tiene o no datos. 
                MiUsuarioLocal.UsuarioContrasennia = TxtUsuarioContrasennia.Text.Trim();

                MiUsuarioLocal.MiRolTipo.UsuarioRolID = Convert.ToInt32(CbRolesUsuario.SelectedValue);

                MiUsuarioLocal.UsuarioDireccion = TxtUsuarioDireccion.Text.Trim();

                //según el diagrama de casos de uso expandido y secuencia normal para un CRUD (editar)
                //es habitual consultar por el ID el item que se va a modificar, para asegurarse que 
                //en el lapso de tiempo entre que se seleccionó el usuario y se modificaron los datos en pantalla
                //aún exista el registro en la base de datos. (existe una posibilidad de que ya no exista debido a que
                //en entornos donde hayan muchos usuario trabajando en el sistema algún otro esté modificando el mismo registro) 
                //esto se llama concurrencia. 

                if (MiUsuarioLocal.ConsultarPorID())
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de modificar el usuario?", "???", 
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Editar())
                        {
                            MessageBox.Show("El Usuario ha sido modificado correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario(); 
                            CargarListaDeUsuarios();
                        }
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (MiUsuarioLocal.UsuarioID > 0 && MiUsuarioLocal.ConsultarPorID())
            {
                //tomando en cuenta que puedo estar viendo los usuario activos o inactivos
                //este botón podría servir tanto para activar como para desactivar los usuarios
                //El checlbox de la parte superior del forma me sirve para identificar esta 
                //acción

                if (CboxVerActivos.Checked)
                {
                    //DESACTIVAR USUARIO
                    DialogResult r = MessageBox.Show("¿Está seguro de Eliminar al Usuario?", 
                                                     "???", 
                                                     MessageBoxButtons.YesNo, 
                                                     MessageBoxIcon.Question);

                    if (r == DialogResult.Yes) 
                    {
                        if (MiUsuarioLocal.Eliminar())
                        {
                            MessageBox.Show("El usuario ha sido eliminado correctamente.", "!!!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeUsuarios();
                        }
                    
                    }

                }
                else
                {
                    //ACTIVAR USUARIO

                }


            }

        }
    }
}
