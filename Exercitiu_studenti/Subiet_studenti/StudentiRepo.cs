using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiet_studenti
{
    public class StudentiRepo
    {
        private const string _connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\padel\\Desktop\\Pregatire_paw\\Subiet_studenti\\Subiet_studenti\\StudentiDBmdf.mdf;Integrated Security=True";

        public void Adaugare(Student student)
        {
            using (var connection = new SqlConnection(_connection))
            {
                connection.Open();


                using (var comanda = new SqlCommand("INSERT INTO STUDENTI(Nume, Matricol, Medie) VALUES (@nume, @matricol, @medie)", connection))
                {

                    comanda.Parameters.AddWithValue("@nume", student.Nume);
                    comanda.Parameters.AddWithValue("@matricol", student.Matricol);
                    comanda.Parameters.AddWithValue("@medie", student.Medie);

                    comanda.ExecuteNonQuery();
                }
            }

        }

        public List<Student> GetAll()
        {
            using (var connection = new SqlConnection(_connection))
            {
                connection.Open();
                List<Student> list = new List<Student>();
                using (var comanda = new SqlCommand("SELECT Id, Nume, Matricol, Medie FROM STUDENTI", connection))
                {
                    var reader = comanda.ExecuteReader();
                    while (reader.Read())
                    {
                        Student s = new Student();
                        s.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        s.Nume = reader.GetString(reader.GetOrdinal("Nume"));
                        s.Matricol = reader.GetInt32(reader.GetOrdinal("Matricol"));
                        int i = reader.GetOrdinal("Medie");
                        s.Medie = reader.GetDecimal(i);

                        list.Add(s);
                    }

                }

                return list;
            }
        }

        public void Update(Student student)
        {
            using(var connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (var comanda = new SqlCommand("UPDATE STUDENTI SET Medie=@medie WHERE Id=@id", connection))
                {
                    comanda.Parameters.AddWithValue("@medie", student.Medie);
                    comanda.Parameters.AddWithValue("@id", student.Id);

                    comanda.ExecuteNonQuery();
                }
            }
        }
            
        


        public void Stergere()
        {
            using (var connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (var comand = new SqlCommand("DELETE FROM STUDENTI", connection))
                {
                    comand.ExecuteNonQuery();
                }
            }
        }



    }

}


