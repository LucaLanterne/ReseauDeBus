using ReseauDeBus.Backend.Parametre;

namespace ReseauDeBus.Backend.Simulation;

public sealed class Simulation : IObserver<NotificationSimulation>
{
    public string id_simulation { get; }
    public Reseau reseau_simulation { get; set; }
    public DateTime heureDebut_simulation { get; set; }
    public DateTime heureFin_simulation { get; set; }
    public Chronometre chronometre_simulation { get; }
    public TimeSpan tempsEcoule_simulation { get; set; }
    private IDisposable? _cancellation;
    public List<InfoTrafic> infoTrafics_simulation { get; }
    
    
    // Une liste des observateurs (observers) - ici les frames admin et joueur
    private readonly HashSet<IObserver<NotificationSimulation>> _observateurs = new();
    // Une liste des notifications
    private readonly HashSet<NotificationSimulation> _notifications = new();

    public Simulation(string idSimulation, Reseau reseauSimulation, 
        DateTime heureDebutSimulation, DateTime heureFinSimulation, TimeSpan dureeSimulation)
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
    
    // Méthode ADD + REMOVE InfoTrafic
    public void AddInfoTrafic(InfoTrafic infoTrafic)
    {
        if (this.infoTrafics_simulation.All(i => infoTrafic.id_infoTrafic != i.id_infoTrafic))
        {
            this.infoTrafics_simulation.Add(new InfoTrafic(
                infoTrafic.id_infoTrafic, 
                infoTrafic.sensCirculation_infoTrafic,
                infoTrafic.bus_infoTrafic,
                infoTrafic.ligne_infoTrafic,
                infoTrafic.horaireDepart_infoTrafic,
                infoTrafic.simulation_infoTrafic
            ));
        }
        else throw new Exception("Duplicata de l'info trafic : " + infoTrafic.id_infoTrafic + " dans la simulation ");
    }

    public void RemoveInfoTrafic(InfoTrafic infoTrafic)
    {
        infoTrafics_simulation.RemoveAll(i => i.id_infoTrafic == infoTrafic.id_infoTrafic);

    }
    
    // Méthode pour Lancer les infoTrafic
    public void StartInfoTrafic()
    {
        foreach (
            var infoTrafic in infoTrafics_simulation.FindAll(
                i => !i.lancement_infoTrafic 
                     && i.horaireDepart_infoTrafic < this.heureDebut_simulation.Add(this.tempsEcoule_simulation)))
        {
            infoTrafic.StartBus();
        }
    }
    
    public void SubscribeTimer(Chronometre provider) => _cancellation = provider.Subscribe(this);

    public void OnNext(NotificationSimulation notification)
    {
        switch (notification.Type)
        {
            case NotificationSimulationType.TimerStart:
                // méthode pour le lancement du timer (et de la simulation par la même occasion)
                // Passage de l'info si besoin de display front
                /*foreach (var observateur in _observateurs)
                {
                    NotificationSimulation notif = new NotificationSimulation { Type = NotificationSimulationType.TimerStart };
                    observateur.OnNext(notif);
                }*/
                break;

            case NotificationSimulationType.TimerEnd:
                // Méthode pour la fin de simulation
                // Passage de l'info si besoin de display front
                break;

            case NotificationSimulationType.TimerTick:
                // Méthode à executer à chaque tick
                foreach (var infoTrafic in infoTrafics_simulation)
                {
                    infoTrafic.Tick();
                }
                // Passage de l'info si besoin de display front
                /*foreach (var observateur in _observateurs)
                {
                    NotificationSimulation notif = new NotificationSimulation { Type = NotificationSimulationType.TimerTick };
                    observateur.OnNext(notif);
                }*/
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