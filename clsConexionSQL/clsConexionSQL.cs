using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net; //Retornar de system de windows el nombre de la maquina
using System.Data.SqlClient; //Accesos a la BD(IMEC)


namespace Modelo
{
    public class clsConexionSQL
    {

        //Area de la declaracion de variables
        #region Atributos

        private string codigo;
        private string clave;
        private string perfil;
        private string baseDatos;

        private SqlConnection conexion; //Guardar la cadena de conexion del usuario con la BD
        private SqlCommand comando; //Permite ejecutar los IMEC

        #endregion


        //Establecemos el meodo inicial
        #region Constructor

        public clsConexionSQL()
        {
            this.codigo = "";
            this.clave = "";
            this.perfil = "";
            this.baseDatos = "BDEstudiantes";
        }


        #endregion


        //Propiedades de lectura y escritura
        #region GetySet

        //set
        public void setCodigo(string codigo)
        {
            this.codigo = codigo.Trim();
        }

        public void setClave(string clave)
        {
            this.clave = clave.Trim();
        }

        public void setPerfil(string perfil)
        {
            this.perfil = perfil.Trim();
        }


        //get
        public string getCodigo()
        {
            return this.codigo;
        }

        public string getClave()
        {
            return this.clave;
        }

        public string getPerfil()
        {
            return this.perfil;
        } 

        #endregion


        //Metodo para la conexion de la BD
        #region Metodos

        //Metodo para ejecutar los select // agregarle cone
        public SqlDataReader mSeleccionar(string strSentencia, clsConexionSQL cone)
        {
            try
            {
                if (mConectar(cone))
                {
                    comando = new SqlCommand(strSentencia, conexion);
                    comando.CommandType = System.Data.CommandType.Text;
                    //El executeReader ejecuta select
                    return comando.ExecuteReader();
                }else {
                    return null;
                }
            }catch
            {
                return null;
            }
        }//fin del metodo mSeleccionar
        //Metodo que permite ejecutar los Insert, Update y Delete

        public Boolean mEjecutar(string strSentencia, clsConexionSQL cone)
        {
            try
            {
                if(mConectar(cone))
                {
                    comando = new SqlCommand(strSentencia,conexion);
                    comando.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }//Fin del metodo mEjecutar

        public Boolean mConectar(clsConexionSQL cone)
        {
            try
            {
                conexion = new SqlConnection();
                conexion.ConnectionString = "user id='"+ cone.getCodigo() +"'; password='"+ cone.getClave() +"'; Data Source='"+ mNomServidor() +"'; Initial Catalog='"+ this.baseDatos +"' ";
                conexion.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }//Fin del metodo mConectar


        //Este metodo obtiene el nombre d ela maquina de windows
        public string mNomServidor()
        {
            return Dns.GetHostName();
        }//Fin del metodo  

        #endregion

    }
}
