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
    
    // Une liste des observateurs (observers) - ici les frames admin et joueur
    private readonly HashSet<IObserver<NotificationSimulation>> _observateurs = new();
    // Une liste des notifications
    private readonly HashSet<NotificationSimulation> _notifications = new();

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

    // Méthodes pour add/remove info trafic
    
    // Méthode pour lancer un bus (info trafic) à une heure prévu
    
    // Méthode pour Démarrer la simulation
    
    public void SubscribeTimer(Chronometre provider) => _cancellation = provider.Subscribe(this);

    public void OnNext(NotificationSimulation notification)
    {
        switch (notification.Type)
        {
            case NotificationSimulationType.TimerStart:
                // méthode pour le lancement du timer (et de la simulation par la même occasion)
                // Passage de l'info si besoin de display front
                foreach (var observateur in _observateurs)
                {
                    NotificationSimulation notif = new NotificationSimulation { Type = NotificationSimulationType.TimerStart };
                    observateur.OnNext(notif);
                }
                break;

            case NotificationSimulationType.TimerEnd:
                // Méthode pour la fin de simulation
                // Passage de l'info si besoin de display front
                break;

            case NotificationSimulationType.TimerTick:
                // Méthode à executer à chaque tick
                // Passage de l'info si besoin de display front
                foreach (var observateur in _observateurs)
                {
                    NotificationSimulation notif = new NotificationSimulation { Type = NotificationSimulationType.TimerTick };
                    observateur.OnNext(notif);
                }
                break;
        }
    }
    
    public void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }
}