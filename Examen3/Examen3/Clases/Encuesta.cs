using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Security.Policy;
using System.Web.UI.WebControls;

namespace Examen3.Clases
{
    public class Encuesta
    {
        public static string Nombre { get; set; }
        public static int Edad { get; set; }
        public static string CorreoE { get; set; }

        public static int PartidoPol { get; set; }


        public Encuesta(string nombre, int edad, string correo, int partido)
        {
            Nombre = nombre;
            Edad = edad;
            CorreoE = correo;
            PartidoPol = partido;
        }
        public Encuesta() { }

        public static int AgregarEncuesta(string nombre, int edad, string correo, int partido)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = BasedeDatos.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("AGREGAR_ENCUESTA", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@NOMBRE", nombre));
                    cmd.Parameters.Add(new SqlParameter("@EDAD", edad));
                    cmd.Parameters.Add(new SqlParameter("@CORREOE", correo));
                    cmd.Parameters.Add(new SqlParameter("@PARTIDOPOL", partido));


                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
    }
}