using ExoRevisionLivre;
Auteur brunoDeLuca = new Auteur {Nom = "De Luca", Prenom = "Bruno"};
Livre livre1 = new Livre("Monsieur JeanJean", 19.90, "Monsieur à des goûts chelou avec ses femmes siamoises", brunoDeLuca);

livre1.ToConcat();