using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Logica.Services
{
    public class Conexion
    {
        string CadenaDeConexion { get; set; }

        public List<SqlParameter> ListaDeParametros = new List<SqlParameter>();

        public int EjecutarInsertUpdateDelete(String NombreSP)
        {
            int Retorno = 0;

            using (SqlConnection MyCnn = new SqlConnection(CadenaDeConexion))

            {
                SqlCommand MyComando = new SqlCommand(NombreSP, MyCnn);
                MyComando.CommandType = CommandType.StoredProcedure;

                if (ListaDeParametros != null && ListaDeParametros.Count > 0)
                {
                    foreach (SqlParameter item in ListaDeParametros)
                    {
                        MyComando.Parameters.Add(item);
                    }
                }

                MyCnn.Open();

      

                Retorno = MyComando.ExecuteNonQuery();
            }

            return Retorno;
        }

       
        public DataTable EjecutarSELECT(String NombreSP, bool CargarEsquema = false)
        {
            DataTable Retorno = new DataTable();

            using (SqlConnection MyCnn = new SqlConnection(CadenaDeConexion))
            {
                SqlCommand MyComando = new SqlCommand(NombreSP, MyCnn);
                MyComando.CommandType = CommandType.StoredProcedure;
                if (ListaDeParametros != null && ListaDeParametros.Count > 0)
                {
                    foreach (SqlParameter item in ListaDeParametros)
                    {
                        MyComando.Parameters.Add(item);
                    }
                }
                SqlDataAdapter MyAdaptador = new SqlDataAdapter(MyComando);

                    MyAdaptador.Fill(Retorno);
                if (CargarEsquema)
                {
                    MyAdaptador.FillSchema(Retorno, SchemaType.Source);
                }
            }
            return Retorno;
        }

        public Object EjecutarSELECTEscalar(String NombreSP)
        {
            Object Retorno = null;
            using (SqlConnection MyCnn = new SqlConnection(CadenaDeConexion))

            {
                SqlCommand MyComando = new SqlCommand(NombreSP, MyCnn);
                MyComando.CommandType = CommandType.StoredProcedure;

                if (ListaDeParametros != null && ListaDeParametros.Count > 0)
                {
                    foreach (SqlParameter item in ListaDeParametros)
                    {
                        MyComando.Parameters.Add(item);
                    }
                }
                MyCnn.Open();
                Retorno = MyComando.ExecuteScalar();
            }

            return Retorno;
        }

        public Conexion()
        {
            this.CadenaDeConexion = ConfigurationManager.ConnectionStrings["CNNSTR"].ToString();
        }

    }
}
