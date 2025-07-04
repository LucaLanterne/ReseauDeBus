using ReseauDeBus.Backend.Parametre;

namespace ReseauDeBus.Backend.Simulation;

public sealed class Simulation : IObserver<NotificationSimulation>
{
    public string id_simulation { get; }
    public Reseau reseau_simulation { get; set; }
    public int heureDebut_simulation { get; set; }
    public int heureFin_simulation { get; set; }
    public Chronometre chronometre_simulation { get; }
    public TimeSpan tempsEcoule_simulation { get; set; }
    private IDisposable? _cancellation;

    public Simulation(string idSimulation, Reseau reseauSimulation, 
        int heureDebutSimulation, int heureFinSimulation, TimeSpan dureeSimulation)
    {
        id_simulation = idSimulation;
        reseau_simulation = reseauSimulation;
        heureDebut_simulation = heureDebutSimulation;
        heureFin_simulation = heureFinSimulation;
        
        chronometre_simulation = new Chronometre();
        SubscribeTimer(chronometre_simulation); 
        
        chronometre_simulation.Start(dureeSimulation);
        
        tempsEcoule_simulation = new TimeSpan(0);
    }

    public void SubscribeTimer(Chronometre provider) => _cancellation = provider.Subscribe(this);

    public void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public void OnNext(TimeSpan value)
    {
        this.tempsEcoule_simulation = value;
    }
}