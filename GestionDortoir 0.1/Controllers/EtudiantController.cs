using GestionDortoir_0._1.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDortoir_0._1.Controllers
{
    internal class EtudiantController
    {
        //Creation d'un étudiant
        public bool EnregistrerEtudiant(Etudiants etudiant)
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO etudiant 
                        (matricule, nom, prenom, filiere, date_naissance, lieu_naissance, picture, nom_pere, profession_pere, nom_mere, profession_mere,
                        annee_etude, numero_etudiant, numero_tel_pere, numero_tel_mere, nom_tuteur, profession_tuteur, numero_tel_tuteur,adresse_parent, adresse_tuteur)
                        VALUES 
                        (@matricule, @nom, @prenom, @filiere, @date_naissance, @lieu_naissance, @picture, @nom_pere, @profession_pere, @nom_mere, @profession_mere,
                        @annee_etude, @numero_etudiant, @numero_tel_pere, @numero_tel_mere, @nom_tuteur, @profession_tuteur, @numero_tel_tuteur, @adresse_parent, @adresse_tuteur)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@matricule", etudiant.Matricule);
                        cmd.Parameters.AddWithValue("@nom", etudiant.Nom);
                        cmd.Parameters.AddWithValue("@prenom", etudiant.Prenom);
                        cmd.Parameters.AddWithValue("@filiere", etudiant.Filiere);
                        cmd.Parameters.AddWithValue("@date_naissance", etudiant.DateNaissance);
                        cmd.Parameters.AddWithValue("@lieu_naissance", etudiant.LieuNaissance);
                        cmd.Parameters.AddWithValue("@picture", etudiant.Picture);
                        cmd.Parameters.AddWithValue("@nom_pere", etudiant.NomPere);
                        cmd.Parameters.AddWithValue("@profession_pere", etudiant.ProfessionPere);
                        cmd.Parameters.AddWithValue("@nom_mere", etudiant.NomMere);
                        cmd.Parameters.AddWithValue("@profession_mere", etudiant.ProfessionMere);
                        cmd.Parameters.AddWithValue("@annee_etude", etudiant.AnneeEtude);
                        cmd.Parameters.AddWithValue("@numero_etudiant", etudiant.NumeroEtudiant);
                        cmd.Parameters.AddWithValue("@numero_tel_pere", etudiant.NumeroTelPere);
                        cmd.Parameters.AddWithValue("@numero_tel_mere", etudiant.NumeroTelMere);
                        cmd.Parameters.AddWithValue("@nom_tuteur", etudiant.NomTuteur);
                        cmd.Parameters.AddWithValue("@profession_tuteur", etudiant.ProfessionTuteur);
                        cmd.Parameters.AddWithValue("@numero_tel_tuteur", etudiant.NumeroTelTuteur);
                        cmd.Parameters.AddWithValue("@adresse_parent", etudiant.AdresseParent);
                        cmd.Parameters.AddWithValue("@adresse_tuteur", etudiant.AdresseTuteur);
                        cmd.ExecuteNonQuery();
                        return true;


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
                return false;
            }
        }
        //Recuperer tous les étudiants
        public List<Etudiants> GetAllEtudiants()
        {
            List<Etudiants> liste = new List<Etudiants>();

            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM etudiant";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Etudiants etudiant = new Etudiants
                            {
                                Matricule = SafeGet<int>(reader, "matricule"),
                                Nom = SafeGet<string>(reader, "nom"),
                                Prenom = SafeGet<string>(reader, "prenom"),
                                Filiere = SafeGet<string>(reader, "filiere"),
                                DateNaissance = SafeGet<DateTime>(reader, "date_naissance"),
                                LieuNaissance = SafeGet<string>(reader, "lieu_naissance"),
                                Picture = SafeGet<byte[]>(reader, "picture"),
                                NomPere = SafeGet<string>(reader, "nom_pere"),
                                ProfessionPere = SafeGet<string>(reader, "profession_pere"),
                                NomMere = SafeGet<string>(reader, "nom_mere"),
                                ProfessionMere = SafeGet<string>(reader, "profession_mere"),
                                AnneeEtude = SafeGet<string>(reader, "annee_etude"),
                                NumeroEtudiant = SafeGet<string>(reader, "numero_etudiant"),
                                NumeroTelPere = SafeGet<string>(reader, "numero_tel_pere"),
                                NumeroTelMere = SafeGet<string>(reader, "numero_tel_mere"),
                                NomTuteur = SafeGet<string>(reader, "nom_tuteur"),
                                ProfessionTuteur = SafeGet<string>(reader, "profession_tuteur"),
                                NumeroTelTuteur = SafeGet<string>(reader, "numero_tel_tuteur"),
                                AdresseParent = SafeGet<string>(reader, "adresse_parent"),
                                AdresseTuteur = SafeGet<string>(reader, "adresse_tuteur")
                            };

                            liste.Add(etudiant);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des étudiants : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return liste;
        }

        //Verifier si la valeur est null ou pas
        private T SafeGet<T>(MySqlDataReader reader, string column)
        {
            int index = reader.GetOrdinal(column);
            return reader.IsDBNull(index) ? default(T) : (T)reader.GetValue(index);
        }

    }
}
