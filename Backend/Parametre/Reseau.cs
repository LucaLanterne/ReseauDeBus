namespace ReseauDeBus.Backend.Parametre;

public class Reseau : StructureTransport
{
    public string id_reseau { get; }
    public string nom_reseau { get; set; }
    public List<Ligne> lignes_reseau { get; set; }

    public Reseau(string idReseau, string nomReseau, List<Ligne> lignesReseau, List<Troncon> tronconsCompletReseau,
        List<Arret> arretsCompletReseau) : base(arretsCompletReseau, tronconsCompletReseau)
    {
        id_reseau = idReseau;
        nom_reseau = nomReseau;
        lignes_reseau = new List<Ligne>();
        foreach (Ligne l in lignesReseau)
        {
            lignes_reseau.Add(new Ligne(l.id_ligne, l.nom_ligne, l.arrets, l.troncons));
        }
    }

    public void AddLigne(Ligne ligne)
       {
           if (lignes_reseau.All(l => l.id_ligne == ligne.id_ligne))
           {
               // Vérifie que tous les arrêts et tronçons de la ligne sont dans le réseau
               bool allArretsInReseau = ligne.arrets.All(a => this.arrets.Any(ar => ar.id_arret == a.id_arret));
               bool allTronconsInReseau = ligne.troncons.All(t => this.troncons.Any(tr => tr.id_troncon == t.id_troncon));
   
               if (allArretsInReseau && allTronconsInReseau)
               {
                   lignes_reseau.Add(new Ligne(ligne.id_ligne, ligne.nom_ligne, ligne.arrets, ligne.troncons));
               }
               else throw new InvalidOperationException("Tous les arrêts et tronçons de la ligne doivent exister dans le réseau.");
           }
       }
   
       public void RemoveLigne(Ligne ligne)
       {
           lignes_reseau.RemoveAll(l => l.id_ligne == ligne.id_ligne);
       }
}