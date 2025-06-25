namespace ReseauDeBus.Backend.Parametre;

public class Creneau
{
    public (int, int) plage_creneau { get; set; }
    public int moyenne_creneau { get; set; }
    public int ecartType_creneau { get; set; }

    public Creneau((int, int) plageCreneau, int moyenneCreneau, int ecartTypeCreneau)
    {
        plage_creneau = plageCreneau;
        moyenne_creneau = moyenneCreneau;
        ecartType_creneau = ecartTypeCreneau;
    }
    
}