namespace ReseauDeBus.Backend;

public class Ligne
{
    public string id_ligne { get; }
    public string nom_ligne { get; set; }
    public List<Arret> arrets_ligne { get; }
    public List<Troncon> troncons_ligne { get; }

    public Ligne(string idLigne, string nomLigne, List<Arret> arretsLigne, List<Troncon> tronconsLigne)
    {
        id_ligne = idLigne;
        nom_ligne = nomLigne;
        arrets_ligne = new List<Arret>();
        foreach (Arret a in arretsLigne)
        {
            arrets_ligne.Add(new Arret(a.id_arret, a.nom_arret, a.x_arret, a.y_arret, a.creneaux_arret ));
        }
        troncons_ligne = new List<Troncon>();
        foreach (Troncon t in tronconsLigne)
        {
            troncons_ligne.Add(new Troncon(t.id_troncon, t.arretDepart_troncon, t.arretArrivee_troncon, t.creneaux_troncon));
        }
    }

    //Ne faut il pas vérifier que l'arret ou le troncon est bien dans la liste complète du réseau pour faire l'ajout dans une ligne ?
    //Pour s'assurer de la cohérence du réseau.
    
    public void AddArret(Arret arret)
    {
        if (arrets_ligne.All(a => a.id_arret != arret.id_arret))
        {
            arrets_ligne.Add(new Arret(
                arret.id_arret, 
                arret.nom_arret, 
                arret.x_arret, 
                arret.y_arret, 
                arret.creneaux_arret));
        }
        else throw new Exception("La ligne contient déjà l'arret : " + arret.nom_arret);
    }

    public void RemoveArret(Arret arret)
    {
        arrets_ligne.RemoveAll(a => a.id_arret == arret.id_arret);
        
        troncons_ligne.RemoveAll(t =>
            t.arretDepart_troncon.id_arret == arret.id_arret ||
            t.arretArrivee_troncon.id_arret == arret.id_arret);
    }
    
    public void AddTroncon(Troncon troncon)
    {
        //Vérifie que les arrêts de départ et d'arrivée du tronçon existe dans la ligne
        //et vérifie que le tronçon ne soit pas déjà ajouté. 
        if (arrets_ligne.Any(a => a.id_arret == troncon.arretDepart_troncon.id_arret) &&
            arrets_ligne.Any(a => a.id_arret == troncon.arretArrivee_troncon.id_arret) &&
            troncons_ligne.All(t => t.id_troncon != troncon.id_troncon))
        {
            troncons_ligne.Add(new Troncon(
                troncon.id_troncon,
                troncon.arretDepart_troncon,
                troncon.arretArrivee_troncon,
                troncon.creneaux_troncon));
        }
    }

    public void RemoveTroncon(Troncon troncon)
    {
        troncons_ligne.RemoveAll(t => t.id_troncon == troncon.id_troncon );
    }
}