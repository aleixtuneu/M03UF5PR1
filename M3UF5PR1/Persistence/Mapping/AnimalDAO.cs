using Npgsql;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using M03UF5PR1.Models.DTOs;
using M03UF5PR1.Persistence.Utils;

namespace M03UF5PR1.Persistence.Mapping
{
    public class AnimalDAO
    {
        // Inserir animal a la bbdd
        public void InserirAnimal(AnimalDTO animal)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO animals (nom, superfamilia, especie, pes) VALUES (@nom, @superfamilia, @especie, @pes)", conn))
                {
                    cmd.Parameters.AddWithValue("nom", animal.Nom);
                    cmd.Parameters.AddWithValue("superfamilia", animal.Superfamilia);
                    cmd.Parameters.AddWithValue("especie", animal.Especie);
                    cmd.Parameters.AddWithValue("pes", animal.Pes);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Actualitzar animal a la bbdd
        public void ActualitzarAnimal(AnimalDTO animal)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE animals SET nom = @nom, superfamilia = @superfamilia, especie = @especie, pes = @pes WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("nom", animal.Nom);
                    cmd.Parameters.AddWithValue("superfamilia", animal.Superfamilia);
                    cmd.Parameters.AddWithValue("especie", animal.Especie);
                    cmd.Parameters.AddWithValue("pes", animal.Pes);
                    cmd.Parameters.AddWithValue("id", animal.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Borrar animal a la bbdd
        public void BorrarAnimalPerId(int id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM animals WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Seleccionar animal random a la bbdd
        public AnimalDTO SelectRandomAnimal()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM animals ORDER BY RANDOM() LIMIT 1", conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new AnimalDTO
                            {
                                Id = reader.GetInt32(0),
                                Nom = reader.GetString(1),
                                Superfamilia = reader.GetString(2),
                                Especie = reader.GetString(3),
                                Pes = reader.GetDouble(4)
                            };
                        }
                    }
                }
            }
            return null;
        }

        // Seleccionar animal per id
        public AnimalDTO SeleccionarPerId(int id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM animals WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new AnimalDTO
                            {
                                Id = reader.GetInt32(0),
                                Nom = reader.GetString(1),
                                Superfamilia = reader.GetString(2),
                                Especie = reader.GetString(3),
                                Pes = reader.GetDouble(4)
                            };
                        }
                    }
                }
            }
            return null;
        }

        // Seleccionar tots els animals amb id
        public List<int> GetAllIds()
        {
            List<int> ids = new List<int>();
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT id FROM animals", conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ids.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            return ids;
        }

        // Obtenir id del següent animal (quan s'elimina)
        public int NextId()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                //comprovar el següent numero a la seqüència
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT last_value FROM animal_id_seq", conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(0) + 1;
                        }
                    }
                }
            }
            return 1;
        }
    }
}
