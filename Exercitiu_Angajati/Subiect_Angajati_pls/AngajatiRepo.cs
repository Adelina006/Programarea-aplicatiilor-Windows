using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_Angajati_pls
{
    public class AngajatiRepo
    {
        private const string _connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\padel\\Desktop\\Pregatire_paw\\Subiect_Angajati_pls\\Subiect_Angajati_pls\\AngajatiDB.mdf;Integrated Security=True";

        public List<Angajat> GetAll()
        {
            List<Angajat> angajati = new List<Angajat>();
            using (var connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT Id,Nume , Data_Nasterii, IdCompanie FROM ANGAJATI ", connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Angajat a = new Angajat();
                        a.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        a.Nume = reader.GetString(reader.GetOrdinal("Nume"));
                        a.DataNasterii = reader.GetDateTime(reader.GetOrdinal("Data_Nasterii"));
                        a.IdCompanie = reader.GetInt32(reader.GetOrdinal("IdCompanie"));

                        angajati.Add(a);
                    }
                }
            }

            return angajati;

        }

        public void Add(Angajat a)
        {
            using(var connection  = new SqlConnection(_connection))
            {
                connection.Open();
                using (var command = new SqlCommand("INSERT INTO ANGAJATI( Nume, Data_Nasterii, IdCompanie) VALUES (@Nume, @Data_Nasterii, @IdCompanie)", connection))
                {
               
                    command.Parameters.AddWithValue("@Nume", a.Nume);
                    command.Parameters.AddWithValue("@Data_Nasterii", a.DataNasterii);
                    command.Parameters.AddWithValue("@IdCompanie", a.IdCompanie);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(Angajat a)
        {
            using (var connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (var command = new SqlCommand("UPDATE ANGAJATI SET Nume=@nume, Data_Nasterii=@data, IdCompanie=@Id WHERE Id = @Ida", connection))
                {
                    command.Parameters.AddWithValue("@nume", a.Nume);
                    command.Parameters.AddWithValue("@data", a.DataNasterii);
                    command.Parameters.AddWithValue("@Id", a.IdCompanie);
                    command.Parameters.AddWithValue("@Ida", a.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(Angajat a)
        {
            using( var connection = new SqlConnection(_connection))
            {
                connection.Open();
                using ( var command = new SqlCommand("DELETE FROM ANGAJATI WHERE Id = @id", connection))
                {
                    command.Parameters.AddWithValue("id", a.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
