namespace ReseauDeBus.Backend.Simulation;

public class EnCirculation : IEtatBus
{
    public TimeSpan tempsDeCirculation { get; set; }

    public EnCirculation(TimeSpan tempsDeCirculation)
    {
        this.tempsDeCirculation = tempsDeCirculation;
    }

    public void OnTick(Bus bus, TimeSpan elapsedTime)
    {
        tempsDeCirculation -= elapsedTime;
        if (tempsDeCirculation <= TimeSpan.Zero)
        {
            bus.AvanceArret();
            bus.EtatCourant = new EnArret();
        }
    }

    public override string ToString() => "Bus en circulation";
}