namespace ReseauDeBus.Backend.Parametre;

public abstract class StructureTransport
{
    public List<Arret> arrets { get; }
    public List<Troncon> troncons { get; }

    public StructureTransport(List<Arret> arretParam, List<Troncon> tronconParam)
    {
        arrets = new List<Arret>();
        foreach (Arret a in arretParam)
        {
            arrets.Add(new Arret(a.id_arret, a.nom_arret, a.x_arret, a.y_arret, a.horaires ));
        }
        troncons = new List<Troncon>();
        foreach (Troncon t in tronconParam)
        {
            troncons.Add(new Troncon(t.id_troncon, t.arretA_troncon, t.arretB_troncon, t.horaires));
        }
    }
    
    public void AddArret(Arret arret)
    {
        if (arrets.All(a => a.id_arret != arret.id_arret))
        {
            arrets.Add(new Arret(
                arret.id_arret, 
                arret.nom_arret, 
                arret.x_arret, 
                arret.y_arret, 
                arret.horaires));
        }
        else throw new Exception("Duplicata de l'arrêt : " + arret.nom_arret + " dans la structure ");
    }

    public void RemoveArret(Arret arret)
    {
        arrets.RemoveAll(a => a.id_arret == arret.id_arret);
        troncons.RemoveAll(t =>
            t.arretA_troncon.id_arret == arret.id_arret ||
            t.arretB_troncon.id_arret == arret.id_arret);
    }
    
    public void AddTroncon(Troncon troncon)
    {
        // Vérifie que les arrêts de départ et d'arrivée du tronçon existent
        // Vérifie que le tronçon ne soit pas déjà ajouté. 
        if (arrets.Any(a => a.id_arret == troncon.arretA_troncon.id_arret) &&
            arrets.Any(a => a.id_arret == troncon.arretB_troncon.id_arret) &&
            troncons.All(t => t.id_troncon != troncon.id_troncon))
        {
            troncons.Add(new Troncon(
                troncon.id_troncon,
                troncon.arretA_troncon,
                troncon.arretB_troncon,
                troncon.horaires));
        }
    }

    public void RemoveTroncon(Troncon troncon)
    {
        troncons.RemoveAll(t => t.id_troncon == troncon.id_troncon );
    }
}