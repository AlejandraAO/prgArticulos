using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//llamado de las referencias propias del proyecto
using System.Data.SqlClient;
using Modelo;
using Controlador;

namespace prgArticulos
{
    public partial class frmAcceso : Form
    {

        #region Atributos
        clsConexionSQL conexion;
        clsEntidadUsuario pEntidadUsuario;
        clsUsuario usuario;
        SqlDataReader dtrUsuario; //para el retorno de las tuplas
        int intContador = 0;
        #endregion

        //se inicializan los atributos
        public frmAcceso()
        {
            conexion = new clsConexionSQL();
            pEntidadUsuario = new clsEntidadUsuario();
            usuario = new clsUsuario();
            InitializeComponent();
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Accion para salir del sistema
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) (Keys.Enter))
            {
                //el evento focus permite trasladar el cursor del mouse al objeto indicado
                this.txtClave.Focus();
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) (Keys.Enter))
            {
                if(mValidarDatos() == true)
                {
                    this.btnIngresar.Enabled = true;
                }
            }
        }//fin del metodo

        #region Metodos
        //metodo que permite verificar la existencia segun el codigo y clave digitada
        private Boolean mValidarDatos()
        {
            if (intContador <= 2)
            {
                //llenado de los atributos del servidor para conectarse a la BD
                conexion.setCodigo("admEstudiante");
                conexion.setClave("123");

                //llenado de los atributos de la clase EntidadUsuario
                pEntidadUsuario.setCodigo(this.txtUsuario.Text.Trim());
                pEntidadUsuario.setClave(this.txtClave.Text.Trim());

                //consultar si el usuario existe
                dtrUsuario = usuario.mConsultarUsuario(conexion, pEntidadUsuario);

                //se evalua si retorna tuplas o datos
                if (dtrUsuario != null)
                {
                    if (dtrUsuario.Read())
                    {
                        pEntidadUsuario.setPerfil(dtrUsuario.GetString(2));
                        pEntidadUsuario.setEstado(dtrUsuario.GetInt32(3));
                        if (pEntidadUsuario.getEstado() == 0)
                        {
                            this.btnIngresar.Enabled = true;
                            return true;
                        }
                        else {
                            MessageBox.Show("El usuario esta bloqueado", "LEA!!!", MessageBoxButtons.OK);
                            return false;
                        }//fin del pEntidad, para evaluar la entidad del usuario
                    }
                    else {
                        MessageBox.Show("El usuario no existe! CARAJO!", "Atencion!", MessageBoxButtons.OK);
                        return false;

                    }//fin del if del read
                }
                else {
                    MessageBox.Show("El usuario no existe!", "LEA!", MessageBoxButtons.OK);
                    return false;
                     } //fin del if del null

            }
            else {
                MessageBox.Show("Informacion erronea", "Usuario bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

                 }//fin del else
        }//fin de validar
        #endregion

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false); // ocultar formulario

            MDIMenu menu = new MDIMenu(conexion);
            menu.Show();
        }
    }
}
