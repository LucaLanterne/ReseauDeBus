namespace ReseauDeBus.Backend.Parametre;

public class Arret : Planifiable
{
    public string id_arret { get; }
    public string nom_arret { get; set; }
    public int x_arret { get; set; }
    public int y_arret { get; set; }

    public Arret(string idArret, string nomArret, int xArret, int yArret, List<Creneau> creneauxArret) : base(creneauxArret)
    {
        id_arret = idArret;
        nom_arret = nomArret;
        x_arret = xArret;
        y_arret = yArret;
    }
}