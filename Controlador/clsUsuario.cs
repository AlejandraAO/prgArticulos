using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Modelo;

namespace Controlador
{
    public class clsUsuario
    {
        #region Atributos
        //permite las sentencias del sql transact
        private string strSentencia;
        //permite enviar la ejecucion de la sentencia al modelo en la clase conexion
        clsConexionSQL conexion = new clsConexionSQL();
        #endregion

        #region Metodos
        //Metodo para accesar al sistema
        // agregar cone por que sino viene vacio el usuario del servidor
        public SqlDataReader mConsultarUsuario(Modelo.clsConexionSQL cone, Modelo.clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Select *from tbUsuarios where codigo='"+ pEntidadUsuario.getCodigo()+"' and clave='"+ pEntidadUsuario.getClave()+"'  ";
            return conexion.mSeleccionar(strSentencia,cone);
        }


        #endregion


    }
}
