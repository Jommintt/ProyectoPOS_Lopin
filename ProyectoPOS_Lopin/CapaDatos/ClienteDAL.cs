using ProyectoPOS_Lopin.CapaEntidades;
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
    public class ClienteDAL
    {

        public DataTable Listar()

        {
            DataTable dt = new DataTable();//tabla en memoria
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            //SQLConnection: representa la conexión a una base de datos SQL
            ////Server usando la cadena de conexion
            {
                string sql = "SELECT Id, NombreCompleto, Telefono, CorreoC, Estado from cliente";
                //Consulta SQL que devuelve todos los registros de la tabla Cliente
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                //SqlCommand: prepara el comando SQL que se enviara al servidor
                {
                    cn.Open();//abre la conexion
                    new SqlDataAdapter(cmd).Fill(dt);
                    //SqlDataAdapter: Ejecuta el SELECT y llena el DataTable con los resultados
                }
            }
            return dt;//retorna la tabla con los datos
        }

        public int Insertar(Cliente2 c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"INSERT INTO cliente (NombreCompleto, Telefono, CorreoC, Estado)
               VALUES (@NombreCompleto,@Telefono, @CorreoC, @Estado);
               SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@NombreCompleto", c.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                    cmd.Parameters.AddWithValue("@CorreoC", c.Correo);
                    cmd.Parameters.AddWithValue("@Estado", c.Estado);
                    cn.Open();
                    //ExecuteScalar: Ejecuta el comando y devuelve el primer
                    ////valor de la primera fila del conjunto de resultados(el ID)
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public bool Actualizar(Cliente2 c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"UPDATE cliente SET NombreCompleto=@NombreCompleto,
                            Telefono=@telefono, CorreoC=@CorreoC, Estado=@Estado
                            WHERE Id=@Id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Id", c.Id);
                    cmd.Parameters.AddWithValue("@NombreCompleto", c.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                    cmd.Parameters.AddWithValue("@CorreoC", c.Correo);
                    cmd.Parameters.AddWithValue("@Estado", c.Estado);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                    //ExecuteNonQuery(): devulve el numero de filas afectadas
                    //>0 significa que se actualizo al menos una fila
                }
            }
        }
        public bool Eliminar(int id)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = "DELETE FROM cliente WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                    //Elimina y devuelve true si se elimino al menos una fila
                }
            }
        }
        public DataTable Buscar(string filtro)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"SELECT Id, NombreCompleto, Telefono, CorreoC, Estado
               FROM cliente
               WHERE NombreCompleto LIKE @filtro OR Telefono LIKE @filtro";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    cn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                    //Llena el DataTable con los resultados de la busqueda
                }
            }
            return dt;
        }
        public bool ExisteNombre(string nombre)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT COUNT(*) FROM cliente WHERE NombreCompleto = @NombreCompleto";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@NombreCompleto", nombre);

                    cn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }
        public bool ExisteNombreEnOtroCliente(string nombre, int id)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"SELECT COUNT(*)
                       FROM cliente
                       WHERE NombreCompleto = @nombre AND Id <> @Id";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@NombreCompleto", nombre);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }

        }

        internal bool TieneVentasAsociadas(int id)
        {
            throw new NotImplementedException();
        }
        public static List<Cliente2> ListarActivos()
        {
            List<Cliente2> lista = new List<Cliente2>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT * FROM Cliente WHERE Estado = 1";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cliente2
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Nombre = dr["NombreCompleto"].ToString(),
                                Telefono = int.Parse(dr["Telefono"].ToString()),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                }
            }

            return lista;
        }

    }
}
        