namespace ReseauDeBus.Backend;

public class Arret
{
    public string id_arret { get; }
    public int x_arret { get; set; }
    public int y_arret { get; set; }
    public List<Creneau> creneaux_arret { get; }

    public Arret(string idArret, int xArret, int yArret, List<Creneau> creneauxArret)
    {
        id_arret = idArret;
        x_arret = xArret;
        y_arret = yArret;
        creneaux_arret = new List<Creneau>();
        foreach (Creneau c in creneauxArret)
        {
            creneaux_arret.Add(new Creneau(c.plage_creneau, c.moyenne_creneau, c.ecartType_creneau));
        }
    }
}