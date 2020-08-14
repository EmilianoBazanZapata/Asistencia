using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistencia
{
    class AccesoDato
    {
        private SqlCommand Comando;
        private SqlConnection Conexion;
        private SqlDataReader Lector;
        private string Cadena_conexion;

        public string pCadena_conexion
        {
            get { return Cadena_conexion; }
            set { Cadena_conexion = value; }
        }


        public SqlDataReader pLector
        {
            get { return Lector; }
            set { Lector = value; }
        }


        public AccesoDato()
        {
            Comando = new SqlCommand();
            Conexion = new SqlConnection();
            Lector = null;
            Cadena_conexion = null;

        }

        public AccesoDato(string CadenaConexion)
        {
            Comando = new SqlCommand();
            Conexion = new SqlConnection();
            Lector = null;
            Cadena_conexion = CadenaConexion;
        }

        public void Conectar()
        {
            Conexion.ConnectionString = Cadena_conexion;
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.Text;

        }

        public void Desconectar()
        {
            Conexion.Close();
        }

        public DataTable ConsultarTabla(string NombreTabla)
        {
            DataTable Tabla = new DataTable();
            Conectar();
            Comando.CommandText = "select * from " + NombreTabla;
            Tabla.Load(Comando.ExecuteReader());




            return Tabla;
        }


        public void LeerTabla(string NombreTabla)
        {
            Conectar();
            Comando.CommandText = "select * from " + NombreTabla;
            Lector = Comando.ExecuteReader();


        }

        public DataTable ConsultarBD(string ConsultaSQL)
        {
            DataTable Tabla = new DataTable();
            Conectar();
            Comando.CommandText = ConsultaSQL;
            Tabla.Load(Comando.ExecuteReader());
            Desconectar();
            return Tabla;
        }


        public void ActualizarBD(string ConsultaSQL)
        {
            Conectar();
            Comando.CommandText = ConsultaSQL;
            Comando.ExecuteNonQuery();
            Desconectar();
        }
    }
}

