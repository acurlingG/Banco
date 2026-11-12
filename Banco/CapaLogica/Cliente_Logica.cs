using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Banco.Capa_Logica
{
    public class Cliente_Logica
    {

        public static int Agregarclientes(int codigo, string nombre, int edad, float clave)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection(); 
            try
            {
                using (Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Insert into cliente (codigo, nombre, edad, saldo) values (@codigo,@nombre,@edad,@saldo)", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@codigo", codigo));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@edad", edad));
                    cmd.Parameters.Add(new SqlParameter("@saldo", clave));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
        public static int Modificarclientes(int codigo, string nombre, int edad, float clave)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("update cliente set nombre=@nombre, edad=@edad, saldo=@saldo where codigo=@codigo", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@codigo", codigo));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@edad", edad));
                    cmd.Parameters.Add(new SqlParameter("@saldo", clave));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
        public static int Borrarclientes(int codigo)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Delete from cliente where codigo=@codigo", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@codigo", codigo));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
        public void ConsultarCliente() { }
    }
}