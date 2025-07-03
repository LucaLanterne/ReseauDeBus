namespace ReseauDeBus.Backend.Simulation;

public class EnCirculation : IEtatBus
{
    public void OnTick(InfoTrafic infoTrafic)
    {
        infoTrafic.etatBus_infoTrafic = new EnArret(infoTrafic.horaireDepart_infoTrafic);
    }

    public override string ToString() => "Bus en circulation";
}