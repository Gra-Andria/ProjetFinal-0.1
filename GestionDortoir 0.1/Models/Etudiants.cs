using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDortoir_0._1.Models
{
    public class Etudiants
    {
        public int Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Filiere { get; set; }
        public DateTime DateNaissance { get; set; }
        public string LieuNaissance { get; set; }
        public byte[] Picture { get; set; }
        public string NomPere { get; set; }
        public string ProfessionPere { get; set; }
        public string NomMere { get; set; }
        public string ProfessionMere { get; set; }
        public string AnneeEtude { get; set; }
        public string NumeroEtudiant { get; set; }
        public string NumeroTelPere { get; set; }
        public string NumeroTelMere { get; set; }
        public string NomTuteur { get; set; }
        public string ProfessionTuteur { get; set; }
        public string NumeroTelTuteur { get; set; }
        public string AdresseParent {  get; set; }
        public string AdresseTuteur { get; set; }
    }
}
