using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoRevisionLivre
{
    public class Personne
    {
		private string _nom { get; set; }
        private string _prenom { get; set; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }

    }
}
