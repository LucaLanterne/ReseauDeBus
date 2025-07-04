namespace ReseauDeBus.Backend.Simulation;

public class EnCirculation : IEtatBus
{
    private Chronometre chronometre_etat = new Chronometre();
    public EnCirculation(InfoTrafic infoTrafic)
    {
        infoTrafic.etatBus_infoTrafic = this;
    }
    public void OnTick(InfoTrafic infoTrafic)
    {
        TimeSpan tempsDeCirculation = infoTrafic.CalcTempsPlanifiable();
        chronometre_etat.Start(tempsDeCirculation);
        if (chronometre_etat.tempsRestant == TimeSpan.Zero)
        {
            infoTrafic.NextEmplacement();
            infoTrafic.etatBus_infoTrafic = new EnArret(infoTrafic);
        } 
    }

    public override string ToString() => "Bus en circulation";
}