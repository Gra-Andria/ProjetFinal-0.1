using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDortoir_0._1.Models
{
    public class Chambre
    {
        public int numero_chambre { get; set; }
        public int capacite { get; set; }
        public string remarque { get; set; }
        public List<Etudiants> Occupants { get; set; }
        public List<string> Equipements { get; set; }
    }
}
