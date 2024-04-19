using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace fundamentals_in_CSharp.Models
{
    internal class CervezaBD
    {

        private string connectionString = "Data Source=192.168.2.160;Initial Catalog=FundamentalsCSharp;" + 
                "User=123456;Password=123456";

        public List<Cerveza> Get()
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            string query = "select nombre, marca, alcohol, cantidad," + "from cervezas";

            // Using sirve para delimitar el ciclo de vida del objeto.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   
                    string nombre = reader.GetString(0);

                    Cerveza cerveza = new Cerveza(1, nombre);
                    cerveza.Alcohol = reader.GetInt32(2);
                    cerveza.Cantidad = reader.GetInt32(3);

                    cervezas.Add(cerveza);
                }
                reader.Close();
                connection.Close();

            }
            return cervezas;
        }

        public void Add(Cerveza cerveza)
        {

            string query
                =  "insert into cerveza(nombre, marca, alcohol, cantidad) " +
                "values(@nombre, @marca, @alcohol, @cantidad)";

            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();

            }
        }

        public void Edit(Cerveza cerveza, int Id)
        {

            string query
                = "update cerveza set nombre=@nombre, marca=@marca, alcohol=@alcohol, cantidad=@cantidad " +
                "where =Id=@id";

            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);
                command.Parameters.AddWithValue("@Id", Id);

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();

            }
        }

        public void Delete( int Id)
        {

            string query
                = "delete from cerveza " + "where Id=@Id";

            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();

            }
        }
    }
}
