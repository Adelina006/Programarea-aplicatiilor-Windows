using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregatire_Vilcea
{
    public class CarteRepo
    {
        private const string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\padel\\Desktop\\Pregatire_paw\\Pregatire_Vilcea\\Pregatire_Vilcea\\Bilbioteca.mdf;Integrated Security=True";

        public  Carte[] GetAll()
        {
            var carti = new Carte[0];

            //trebuie sa creeam conexiune
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using( var comand = new SqlCommand("SELECT * FROM CARTI", connection))
                {
                   var reader = comand.ExecuteReader();
                    while (reader.Read())
                    {
                        var tip = reader.GetString(reader.GetOrdinal("Tip"));
                        Carte carte;
                        if( tip == "digitala")
                        {
                            carte = new CarteDigitala();
                            (carte as CarteDigitala).Format = reader.GetString(reader.GetOrdinal("Format"));

                            
                                
                        }
                        else
                        {
                            carte = new CarteFizica();
                            (carte as CarteFizica).Raft = reader.GetString(reader.GetOrdinal("Raft"));
                        }

                        carte.Titlu = reader.GetString(reader.GetOrdinal("Titlu"));
                        carte.Autor = reader.GetString(reader.GetOrdinal("Autor"));
                        carte.Gen = (GenLiterar)reader.GetInt32(reader.GetOrdinal("Gen"));

                        Array.Resize(ref carti, carti.Length + 1);
                        carti[carti.Length - 1] = carte;
                    }


                connection.Close();
            }

                return carti;
        }
    }
}
