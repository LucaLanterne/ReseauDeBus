using ReseauDeBus.Backend.Parametre;

namespace ReseauDeBus.Backend.Simulation;

public class Simulation
{
    public string id_simulation { get; }
    public Reseau reseau_simulation { get; set; }
    public int heureDebut_simulation { get; set; }
    public int heureFin_simulation { get; set; }
    
    public Chronometre chronometre { get; }

    public Simulation(string idSimulation, Reseau reseauSimulation, 
        int heureDebutSimulation, int heureFinSimulation, TimeSpan dureeSimulation)
    {
        id_simulation = idSimulation;
        reseau_simulation = reseauSimulation;
        heureDebut_simulation = heureDebutSimulation;
        heureFin_simulation = heureFinSimulation;
        this.chronometre = new Chronometre();
        this.chronometre.Start(dureeSimulation);
    }
}