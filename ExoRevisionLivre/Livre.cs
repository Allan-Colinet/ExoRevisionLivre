using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExoRevisionLivre
{
    public class Livre
    {
        private string _titre;
        private double _prix;
        private string _description;
        private Auteur _auteur;
        public string Titre { get => _titre; set => _titre = value; }
        public double Prix { get => _prix; set => _prix = value; }
        public string Description { get => _description; set => _description = value; }
        public Auteur Auteur { get => _auteur; set => _auteur = value; }

        public Livre(string titre, double prix, string description, Auteur auteur)
        {
            _titre = titre;
            _prix = prix;
            _description = description;
            _auteur = auteur;
        }
        public void ToConcat()
        {
            Console.WriteLine("Voici la liste de vos livre");
            Console.WriteLine($"{Titre} - {Prix} - {Description} - {Auteur.Nom} - {Auteur.Prenom}");
        }
    }
}
