namespace ReseauDeBus.Backend.Simulation;

public class EnArret : IEtatBus, IObserver<TimeSpan>
{
    private Chronometre chronometre_etat = new Chronometre();
    public EnArret(InfoTrafic infoTrafic)
    {
        int heureSimulation = infoTrafic.(int)infoTrafic.simulation_infoTrafic.tempsEcoule_simulation
        this.chronometre_etat.Subscribe(this);
        this.chronometre_etat.Start( infoTrafic.emplacementBus_infoTrafic.GetDuree() );
    }
    
    public void OnTick(InfoTrafic infoTrafic)
    {
        infoTrafic.etatBus_infoTrafic = new EnCirculation();
    }
    
    public override string ToString() => "Bus à l'arrêt";
    
    public void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public void OnNext(TimeSpan value)
    {
        throw new NotImplementedException();
    }
}