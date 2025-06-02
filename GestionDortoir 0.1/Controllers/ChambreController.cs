using GestionDortoir_0._1.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDortoir_0._1.Controllers
{
    internal class ChambreController
    {
        //recuperer tous les chambres
        public static List<Chambre> GetAllChambres()
        {
            var chambres = new List<Chambre>();
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT \r\n    c.numero_chambre, \r\n    c.capacite, \r\n    c.remarque, \r\n    ce.equipement_id, \r\n    o.matricule\r\nFROM chambre c\r\nLEFT JOIN etudiant o ON o.CHAMBREnumero_chambre = c.numero_chambre\r\nLEFT JOIN chambreequipement ce ON ce.chambre_id = c.numero_chambre;\r\n", conn);
                using (var reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        var chambre = new Chambre()
                        {
                            numero_chambre = reader.IsDBNull(reader.GetOrdinal("numero_chambre")) ? 0 : reader.GetInt32(reader.GetOrdinal("numero_chambre")),
                            capacite = reader.IsDBNull(reader.GetOrdinal("capacite")) ? 0 : reader.GetInt32(reader.GetOrdinal("capacite")),
                            remarque = reader.IsDBNull(reader.GetOrdinal("remarque")) ? "" : reader.GetString(reader.GetOrdinal("remarque")),
                            Occupants = reader.IsDBNull(reader.GetOrdinal("matricule")) ? new List<Etudiants>() : GetOccupants(reader.GetInt32(reader.GetOrdinal("matricule"))),
                            Equipements = reader.IsDBNull(reader.GetOrdinal("equipement_id")) ? new List<string>() : GetEquipements(reader.GetInt32(reader.GetOrdinal("id_equipement")))
                        };

                    }
                }
            }
            return chambres;
        }

        //recuperer les occupants 
        public static List<Etudiants> GetOccupants(int chambreId)
        {
            var etudiants = new List<Etudiants>();
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM etudiant where CHAMBREnumero_chambre = @id", conn);
                cmd.Parameters.AddWithValue("@id", chambreId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        etudiants.Add(new Etudiants()
                        {
                            Matricule = reader.GetInt32("matricule"),
                            Nom = reader.GetString("nom"),
                            Filiere = reader.GetString("filiere"),
                            AnneeEtude = reader.GetString("annee_etude")
                        });
                    }
                }
            }
            return etudiants;
        }
        //recuperer les equipements
        public static List<string> GetEquipements(int chambreId)
        {
            var equipements = new List<string>();
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand(@"SELECT e.nom FROM equipement e JOIN ChambreEquipement ce ON ce.equipement_id = e.id WHERE ce.chambre_id", conn);
                cmd.Parameters.AddWithValue("@id", chambreId);
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equipements.Add(reader.GetString("nom"));
                    }
                }
            }
            return equipements;
        }
    }
}
