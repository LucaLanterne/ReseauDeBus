namespace ReseauDeBus.Backend;

public class Reseau
{
    public string id_reseau { get; }
    public string nom_reseau { get; set; }
    public List<Ligne> lignes_reseau { get; set; }
    public List<Troncon> tronconsComplet_reseau { get; set; }
    public List<Arret> arretsComplet_reseau { get; set; }

    public Reseau(string idReseau, string nomReseau, List<Ligne> lignesReseau, List<Troncon> tronconsCompletReseau,
        List<Arret> arretsCompletReseau)
    {
        id_reseau = idReseau;
        nom_reseau = nomReseau;
        lignes_reseau = new List<Ligne>();
        foreach (Ligne l in lignesReseau)
        {
            lignes_reseau.Add(new Ligne(l.id_ligne, l.nom_ligne, l.arrets_ligne, l.troncons_ligne));
        }
        tronconsComplet_reseau = new List<Troncon>();
        foreach (Troncon t in tronconsCompletReseau)
        {
            tronconsComplet_reseau.Add(new Troncon(t.id_troncon, t.arretDepart_troncon, t.arretArrivee_troncon, t.creneaux_troncon));
        }
        arretsComplet_reseau = new List<Arret>();
        foreach (Arret a in arretsCompletReseau)
        {
            arretsComplet_reseau.Add(new Arret(a.id_arret, a.nom_arret, a.x_arret, a.y_arret, a.creneaux_arret));
        }
    }

    public void AddLigne(Ligne ligne)
    {
        if (lignes_reseau.All(l => l.id_ligne == ligne.id_ligne))
        {
            // Vérifie que tous les arrêts et tronçons de la ligne sont dans le réseau
            bool allArretsInReseau = ligne.arrets_ligne.All(a => arretsComplet_reseau.Any(ar => ar.id_arret == a.id_arret));
            bool allTronconsInReseau = ligne.troncons_ligne.All(t => tronconsComplet_reseau.Any(tr => tr.id_troncon == t.id_troncon));

            if (allArretsInReseau && allTronconsInReseau)
            {
                lignes_reseau.Add(new Ligne(ligne.id_ligne, ligne.nom_ligne, ligne.arrets_ligne, ligne.troncons_ligne));
            }
            else throw new InvalidOperationException("Tous les arrêts et tronçons de la ligne doivent exister dans le réseau.");
        }
    }

    public void RemoveLigne(Ligne ligne)
    {
        lignes_reseau.RemoveAll(l => l.id_ligne == ligne.id_ligne);
    }
    
    public void AddArret(Arret arret)
    {
        if (arretsComplet_reseau.All(a => a.id_arret != arret.id_arret))
        {
            arretsComplet_reseau.Add(new Arret(
                arret.id_arret,
                arret.nom_arret,
                arret.x_arret,
                arret.y_arret,
                arret.creneaux_arret));
        }
        else throw new Exception("Le réseau contient déjà l'arret : " + arret.nom_arret);
    }
    
    public void RemoveArret(Arret arret)
    {
        // Supprime l'arrêt s'il existe
        arretsComplet_reseau.RemoveAll(a => a.id_arret == arret.id_arret);

        // Supprime tous les tronçons liés à cet arrêt dans le réseau complet
        tronconsComplet_reseau.RemoveAll(t =>
            t.arretDepart_troncon.id_arret == arret.id_arret ||
            t.arretArrivee_troncon.id_arret == arret.id_arret);

        // Supprime l'arrêt et les tronçons liés dans chaque ligne
        foreach (var ligne in lignes_reseau)
        {
            ligne.RemoveArret(arret);
        }
    }

    public void AddTroncon(Troncon troncon)
    {
        // Vérifie que les arrêts de départ et d'arrivée du tronçon existe dans la ligne
        // et vérifie que le tronçon ne soit pas déjà ajouté
        if (arretsComplet_reseau.Any(a => a.id_arret == troncon.arretDepart_troncon.id_arret) &&
            arretsComplet_reseau.Any(a => a.id_arret == troncon.arretArrivee_troncon.id_arret) && 
            tronconsComplet_reseau.All(t => t.id_troncon != troncon.id_troncon))
        {
            tronconsComplet_reseau.Add(new Troncon(
                troncon.id_troncon,
                troncon.arretDepart_troncon,
                troncon.arretArrivee_troncon,
                troncon.creneaux_troncon));
        }
    }

    public void RemoveTroncon(Troncon troncon)
    {
        tronconsComplet_reseau.RemoveAll(t => t.id_troncon == troncon.id_troncon);

        // Supprime aussi ce tronçon de toutes les lignes qui le contiennent
        foreach (var ligne in lignes_reseau)
        {
            ligne.RemoveTroncon(troncon);
        }
    }
    
}