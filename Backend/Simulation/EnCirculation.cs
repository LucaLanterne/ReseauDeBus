namespace ReseauDeBus.Backend.Simulation;

public class EnCirculation : IEtatBus
{
    private Chronometre chronometre_etat = new Chronometre();
    public void OnTick(InfoTrafic infoTrafic)
    {
        infoTrafic.etatBus_infoTrafic = new EnArret(infoTrafic.horaireDepart_infoTrafic);
    }

    public override string ToString() => "Bus en circulation";
}