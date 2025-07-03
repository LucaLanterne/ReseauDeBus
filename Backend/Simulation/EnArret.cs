namespace ReseauDeBus.Backend.Simulation;

public class EnArret : IEtatBus
{
    Chronometre chronometre = new Chronometre();
    public EnArret(InfoTrafic infoTrafic)
    {
        this.chronometre.Start( infoTrafic.emplacementBus_infoTrafic.GetDuree(infoTrafic.simulation_infoTrafic.chronometre) );
    }
    
    public void OnTick(InfoTrafic infoTrafic)
    {
        infoTrafic.etatBus_infoTrafic = new EnCirculation();
    }
    
    public override string ToString() => "Bus à l'arrêt";
}