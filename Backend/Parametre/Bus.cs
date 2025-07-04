namespace ReseauDeBus.Backend.Simulation;

public class Bus
{
    public string id_bus { get; }
    public string immatriculation_bus { get; set; }
    
    public Bus(string idBus, string immatriculationBus)
    {
        id_bus = idBus;
        immatriculation_bus = immatriculationBus;
    }
}