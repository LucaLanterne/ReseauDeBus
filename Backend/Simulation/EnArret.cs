namespace ReseauDeBus.Backend.Simulation;

public class EnArret : IEtatBus
{
    private Chronometre chronometre_etat = new Chronometre();
    
    public EnArret(InfoTrafic infoTrafic)
    {
        infoTrafic.etatBus_infoTrafic = this;
    }
    public void OnTick(InfoTrafic infoTrafic)
    {
        TimeSpan tempsDArret = infoTrafic.CalcTempsPlanifiable();
        chronometre_etat.Start(tempsDArret);
        if (chronometre_etat.tempsRestant == TimeSpan.Zero)
        {
            infoTrafic.NextEmplacement();
            infoTrafic.etatBus_infoTrafic = new EnCirculation(infoTrafic);
        } 
    }

    public override string ToString() => "Bus à l'arrêt";
}