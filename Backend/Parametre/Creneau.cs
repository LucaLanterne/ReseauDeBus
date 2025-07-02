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
    
    public TimeSpan GetDuree()
    {
        Random random = new Random();
        int temps = this.moyenne_creneau + random.Next(-this.ecartType_creneau, this.ecartType_creneau+1);
        return TimeSpan.FromSeconds(temps);
    }
}