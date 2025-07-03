using ReseauDeBus.Backend.Parametre;

namespace ReseauDeBus.Backend.Simulation;

public class InfoTrafic
{
    public string id_infoTrafic { get; }
    public int sensCirculation_infoTrafic { get; set; }
    public Planifiable emplacementBus_infoTrafic { get; set; }
    public Bus bus_infoTrafic { get; set; }
    public Ligne ligne_infoTrafic { get; set; }
    public IEtatBus etatBus_infoTrafic { get; set; }
    public DateTime horaireDepart_infoTrafic {get; set;}
    public Simulation simulation_infoTrafic { get; set; }

    public InfoTrafic(string idInfoTrafic, int sensCirculationInfoTrafic, Bus busInfoTrafic, Ligne ligneInfoTrafic, DateTime horaireDepartInfoTrafic, Simulation simulationInfoTrafic)
    {
        id_infoTrafic = idInfoTrafic;
        sensCirculation_infoTrafic = sensCirculationInfoTrafic;
        emplacementBus_infoTrafic = null;
        bus_infoTrafic = busInfoTrafic;
        ligne_infoTrafic = ligneInfoTrafic;
        horaireDepart_infoTrafic = new DateTime(horaireDepartInfoTrafic.Year, horaireDepartInfoTrafic.Month, horaireDepartInfoTrafic.Day, horaireDepartInfoTrafic.Hour, horaireDepartInfoTrafic.Minute, horaireDepartInfoTrafic.Second);
        simulation_infoTrafic = simulationInfoTrafic;
        etatBus_infoTrafic = new EnArret();
    }

    public void Tick()
    {
        this.etatBus_infoTrafic.OnTick(this);
    }
    
}