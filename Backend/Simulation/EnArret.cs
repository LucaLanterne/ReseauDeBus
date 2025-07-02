using ReseauDeBus.Backend.Parametre;

namespace ReseauDeBus.Backend.Simulation;

public class EnArret : IEtatBus
{
    public TimeSpan tempsArret { get; set; }

    public EnArret(TimeSpan tempsArret)
    {
        this.tempsArret = tempsArret;
    }

    public void OnTick(Bus bus, TimeSpan elapsedTime, DateTime heureSimulee)
    {
        tempsArret -= elapsedTime;
        if (tempsArret <= TimeSpan.Zero)
        {
            // Voir si on met la ligne pour recherche de troncon et arret en variable de la classe bus,
            // ou comment on va récupérer l'arret ou le troncon.
            Planifiable planifiable = new Arret("1", "test", 1, 1, new List<Creneau>());
            TimeSpan tempsCirculation = bus.GetTempsPlanifiable(planifiable, heureSimulee);
            bus.EtatCourant = new EnCirculation(tempsCirculation);
        }
    }
    
    public override string ToString() => "Bus à l'arrêt";
}