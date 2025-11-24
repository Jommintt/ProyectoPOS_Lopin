using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOS_Lopin.CapaDatos
{
    internal class ClienteDAL
    {
        public ClienteDAL;

        public DataTable Listar()

        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT Id, nombre, email, telefono, estado";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);

                }
            }
            return dt;
        }
        public int Insertar(Cliente c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena));
        }
        string sql = @"INSERT INTO Cliente(nombre, email, telefono, estado)
                VALUES(@nombre, @email, @telefono, @estado); SELECT SCOPE_IDENTITY();";
        }

        using (SqlCommand cmd = new SqlCommand(Sql, cn))
        {
        cmd.Paramenters.AddWithValue("@nombre", c.nombre)
        cmd.Paramenters.AddWithValue("@email", c.email)
        cmd.Paramenters.AddWithValue("@telefono", c.telefono)
        cmd.Paramenters.AddWithValue("@estado", c.estado)
        }
        
        

    }
}

