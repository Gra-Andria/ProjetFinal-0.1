using GestionDortoir_0._1.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDortoir_0._1.Controllers
{
    internal class EquipementController
    {
        public static List<Equipement> GetByChambreId(int idChambre)
        {
            List<Equipement> equipements = new List<Equipement>();
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM equipement WHERE numero_chambre = @idChambre ";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idChambre", idChambre);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Equipement e = new Equipement()
                                {
                                    IdEquipement = reader["id_equipement"] == DBNull.Value ? 0 : reader.GetInt32("id_equipement"),
                                    Nom = reader["nom"] == DBNull.Value ? "" : reader.GetString("nom"),
                                    NumeroChambre = reader["numero_chambre"] == DBNull.Value ? 0 : reader.GetInt32("numero_chambre")
                                };

                                equipements.Add(e);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des équipements : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return equipements;
        }
    }
}
