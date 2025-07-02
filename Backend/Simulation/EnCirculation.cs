using ReseauDeBus.Backend.Parametre;

namespace ReseauDeBus.Backend.Simulation;

public class EnCirculation : IEtatBus
{
    public TimeSpan tempsDeCirculation { get; set; }

    public EnCirculation(TimeSpan tempsDeCirculation)
    {
        this.tempsDeCirculation = tempsDeCirculation;
    }

    public void OnTick(Bus bus, TimeSpan elapsedTime, DateTime heureSimulee)
    {
        tempsDeCirculation -= elapsedTime;
        if (tempsDeCirculation <= TimeSpan.Zero)
        {
            bus.AvanceArret();
            // Voir si on met la ligne pour recherche de troncon et arret en variable de la classe bus,
            // ou comment on va récupérer l'arret ou le troncon.
            Planifiable planifiable = new Arret("1", "test", 1, 1, new List<Creneau>());
            TimeSpan tempsArret = bus.GetTempsPlanifiable(planifiable, heureSimulee);
            bus.EtatCourant = new EnArret(tempsArret);
        }
    }

    public override string ToString() => "Bus en circulation";
}