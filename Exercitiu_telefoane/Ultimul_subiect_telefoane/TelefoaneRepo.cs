using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimul_subiect_telefoane
{
    public class TelefoaneRepo
    {
        private const string _connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\padel\\Desktop\\Pregatire_paw\\Ultimul_subiect_telefoane\\Ultimul_subiect_telefoane\\Telefoane.mdf;Integrated Security=True";

        public List<Smartphone> GetAll()
        {
            using(var connection = new SqlConnection(_connection))
            {
                List<Smartphone> telefoane = new List<Smartphone>();
                connection.Open();
                using (var comanda = new SqlCommand("SELECT Id, Model, Stoc, Pret, Data, IdProducator FROM [Table]", connection))
                {
                    using (SqlDataReader reader = comanda.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Smartphone s = new Smartphone();
                            s.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                            s.Model = reader.GetString(reader.GetOrdinal("Model"));
                            s.Stoc = reader.GetInt32(reader.GetOrdinal("Stoc"));
                            s.Pret = reader.GetDecimal(reader.GetOrdinal("Pret"));
                            s.DataApartie = reader.GetDateTime(reader.GetOrdinal("Data"));
                            s.IdProducator = reader.GetInt32(reader.GetOrdinal("IdProducator"));

                            telefoane.Add(s);
                        }
                    }
               
                }
                return telefoane;
            }
            

        }

        public void Add(Smartphone s)
        {
            using (var connection = new SqlConnection(_connection))
            {
               
                connection.Open();
                using (var comanda = new SqlCommand("INSERT INTO [Table] (Model, Stoc, Pret, Data, IdProducator) VALUES (@model, @stoc, @pret, @data, @Idp)", connection))
                {
                    
                    comanda.Parameters.Add("@model", s.Model);
                    comanda.Parameters.Add("@stoc", s.Stoc);
                    comanda.Parameters.Add("@pret", s.Pret);
                    comanda.Parameters.Add("@data", s.DataApartie);
                    comanda.Parameters.Add("@Idp", s.IdProducator);

                    comanda.ExecuteNonQuery();
                }
            }
        }

        public void Update(Smartphone s)
        {
            using (var connection = new SqlConnection(_connection))
            {

                connection.Open();
                using (var comanda = new SqlCommand("Update [Table] set Model = @model, Stoc=@stoc, Pret=@pret, Data=@data, IdProducator=@Idp where Id=@id", connection))
                {
                    comanda.Parameters.Add("@id", s.Id);
                    comanda.Parameters.Add("@model", s.Model);
                    comanda.Parameters.Add("@stoc", s.Stoc);
                    comanda.Parameters.Add("@pret", s.Pret);
                    comanda.Parameters.Add("@data", s.DataApartie);
                    comanda.Parameters.Add("@Idp", s.IdProducator);

                    comanda.ExecuteNonQuery();
                }
            }
        }


        public void Delete(Smartphone s)
        {
            using (var connection = new SqlConnection(_connection))
            {

                connection.Open();
                using (var comanda = new SqlCommand("Delete from [Table] where Id=@id", connection))
                {
                    comanda.Parameters.Add("@id", s.Id);
                   

                    comanda.ExecuteNonQuery();
                }
            }
        }


    }
}
