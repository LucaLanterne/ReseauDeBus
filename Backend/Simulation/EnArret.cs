using ReseauDeBus.Backend.Parametre;

namespace ReseauDeBus.Backend.Simulation;

public class EnArret : IEtatBus
{
    public void OnTick(InfoTrafic infoTrafic)
    {
        infoTrafic.etatBus_infoTrafic = new EnCirculation(infoTrafic.emplacementBus_infoTrafic.getDuree(infoTrafic.simulation_infoTrafic.getTime()));
    }
    
    public override string ToString() => "Bus à l'arrêt";
}