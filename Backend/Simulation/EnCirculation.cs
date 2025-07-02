using ReseauDeBus.Backend.Parametre;

namespace ReseauDeBus.Backend.Simulation;

public class EnCirculation : IEtatBus
{
    public void OnTick(InfoTrafic infoTrafic)
    {
        infoTrafic.etatBus_infoTrafic = new EnArret(infoTrafic.emplacementBus_infoTrafic.getDuree(infoTrafic.simulation_infoTrafic.getTime()));
    }

    public override string ToString() => "Bus en circulation";
}