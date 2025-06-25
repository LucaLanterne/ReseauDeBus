namespace ReseauDeBus.Backend.Simulation;

public class EnArret : IEtatBus
{
    public TimeSpan tempsDArret { get; set; }

    public EnArret(TimeSpan tempsDArret)
    {
        this.tempsDArret = tempsDArret;
    }

    public void OnTick(Bus bus, TimeSpan elapsedTime)
    {
        tempsDArret -= elapsedTime;
        if (tempsDArret <= TimeSpan.Zero)
        {
            bus.EtatCourant = new EnCirculation();
        }
    }
    
    public override string ToString() => "Bus à l'arrêt";
}