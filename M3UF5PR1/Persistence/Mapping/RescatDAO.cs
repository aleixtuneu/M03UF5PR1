using Npgsql;
using M03UF5PR1.Models.DTOs;
using M03UF5PR1.Persistence.DAOs;
using M03UF5PR1.Persistence.Utils;
using System.Collections.Generic;

namespace M03UF5PR1.Persistence.Mapping
{
    public class RescatDAO : IRescatDAO
    {
        // Inserir rescat a la bdd
        public void InsertRescue(RescatDTO rescue)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO rescats (rescat_num, rescat_data, animal_id, ga, localitzacio) VALUES (@rescat_num, @rescat_data, @animal_id, @ga, @localitzacio)", conn))
                {
                    cmd.Parameters.AddWithValue("rescat_num", rescue.NumRescat);
                    cmd.Parameters.AddWithValue("rescat_data", rescue.DataRescat);
                    cmd.Parameters.AddWithValue("animal_id", rescue.Animal.Id);
                    cmd.Parameters.AddWithValue("ga", rescue.GA);
                    cmd.Parameters.AddWithValue("localitzacio", rescue.Localitzacio);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Obtenir tots els resultats de la bbdd
        public List<RescatDTO> GetAllRescue()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM rescats", conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<RescatDTO> rescats = new List<RescatDTO>();
                        while (reader.Read())
                        {
                            RescatDTO rescat = new RescatDTO();
                            rescat.Id = reader.GetInt32(0);
                            rescat.NumRescat = reader.GetString(1);
                            rescat.DataRescat = reader.GetDateTime(2);
                            rescat.Animal = new AnimalDAO().SelecionarPerId(reader.GetInt32(3));
                            rescat.GA = reader.GetDouble(4);
                            rescat.Localitzacio = reader.GetString(5);
                            rescats.Add(rescat);
                        }
                        return rescats;
                    }
                }
            }
        }

        // Obtenir rescat per id
        public RescatDTO GetRescueById(int id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM rescats WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        RescatDTO rescat = new RescatDTO();
                        while (reader.Read())
                        {
                            rescat.NumRescat = reader.GetString(1);
                            rescat.DataRescat = reader.GetDateTime(2);
                            rescat.Animal = new AnimalDAO().SeleccionarPerId(reader.GetInt32(3));
                            rescat.GA = reader.GetDouble(4);
                            rescat.Localitzacio = reader.GetString(5);
                        }
                        return rescat;
                    }
                }
            }
        }

        // Obtenir id de tots els rescats
        public List<int> GetAllIds()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT id FROM rescats", conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<int> ids = new List<int>();
                        while (reader.Read())
                        {
                            ids.Add(reader.GetInt32(0));
                        }
                        return ids;
                    }
                }
            }
        }
    }
}
