namespace ReseauDeBus.Backend;

public class Troncon : Planifiable
{
    public string id_troncon { get; }
    public Arret arretDepart_troncon { get; set; }
    public Arret arretArrivee_troncon { get; set; }
    public List<Creneau> creneaux_troncon { get; }

    public Troncon(string idTroncon, Arret arretDepartTroncon, Arret arretArriveeTroncon, List<Creneau> creneauxTroncon) : base(creneauxTroncon)
    {
        id_troncon = idTroncon;
        arretDepart_troncon = arretDepartTroncon;
        arretArrivee_troncon = arretArriveeTroncon;
        creneaux_troncon = new List<Creneau>();
        foreach (Creneau c in creneauxTroncon)
        {
            creneaux_troncon.Add(new Creneau(c.plage_creneau, c.moyenne_creneau, c.ecartType_creneau));
        }
    }
}