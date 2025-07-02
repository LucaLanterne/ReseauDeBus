namespace ReseauDeBus.Backend.Parametre;

public class Troncon : Planifiable
{
    public string id_troncon { get; }
    public Arret arretA_troncon { get; set; }
    public Arret arretB_troncon { get; set; }

    public Troncon(string idTroncon, Arret arretDepartTroncon, Arret arretArriveeTroncon, List<Creneau> creneauxTroncon) : base(creneauxTroncon)
    {
        id_troncon = idTroncon;
        arretA_troncon = arretDepartTroncon;
        arretB_troncon = arretArriveeTroncon;
    }
}