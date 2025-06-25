namespace ReseauDeBus.Backend.Simulation;

public class EnArret : IEtatBus
{
    public TimeSpan tempsDArret { get; set; }

    public EnArret() {}

    public void OnTick(Bus bus, TimeSpan elapsedTime)
    {
        tempsDArret -= elapsedTime;
        if (tempsDeCirculation <= TimeSpan.Zero)
        {
            bus.AvanceArret();
            bus.EtatCourant = new EnArret();
        }
    }
    
    public override string ToString() => "Bus en circulation";
}