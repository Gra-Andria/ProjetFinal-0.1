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
    internal class ChambreController
    {
        //recuperer tous les chambres
        public static List<Chambre> GetAllChambre()
        {
            List<Chambre> chambres = new List<Chambre> ();
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM chambre";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Chambre c = new Chambre()
                                {
                                    numero_chambre = reader["numero_chambre"] == DBNull.Value ? 0 : reader.GetInt32("numero_chambre"),
                                    capacite = reader["capacite"] == DBNull.Value ? 0 : reader.GetInt32("capacite"),
                                    remarque = reader["remarque"] == DBNull.Value ? "" : reader.GetString("remarque")
                                };

                                chambres.Add(c);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des chambres : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chambres;
        }
    }
}
