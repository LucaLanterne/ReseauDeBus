using System.Timers;
using Timer = System.Timers.Timer;

namespace ReseauDeBus.Backend.Simulation
{
    public class Chronometre : IObservable<NotificationSimulation>
    {
        public Timer? chrono {get; private set;}
        public int frequence {get; private set;}
        public DateTime debut {get; private set;}
        public TimeSpan dureeChrono {get; private set;}
        public TimeSpan tempsRestant {get; private set;}
        public bool isActif { get; private set; }

        private readonly HashSet<IObserver<NotificationSimulation>> _observateurs = new();
        private readonly HashSet<NotificationSimulation> _notifications = new();

        public void Start(TimeSpan duree, int delaiMs = 1000)
        {
            frequence = delaiMs;
            dureeChrono = duree;
            tempsRestant = duree;
            debut = DateTime.Now;

            chrono = new Timer(frequence);
            chrono.Elapsed += Tick;
            chrono.Enabled = true;
            isActif = true;

            foreach (var obs in _observateurs)
            {
                NotificationSimulation notif = new NotificationSimulation{ Type = NotificationSimulationType.TimerStart };
                obs.OnNext(notif); // Notify start time
            }
        }

        public void Stop()
        {
            if (chrono != null)
            {
                chrono.Enabled = false;
                chrono.Stop();
                chrono.Dispose();
                chrono = null;
                isActif = false;
            }
        }

        private void Tick(object? sender, ElapsedEventArgs e)
        {
            tempsRestant = dureeChrono - (e.SignalTime - debut);

            foreach (var obs in _observateurs)
            {
                NotificationSimulation notif = new NotificationSimulation{ Type = NotificationSimulationType.TimerTick };
                obs.OnNext(notif); // Notify real current time
            }

            if (chrono != null && tempsRestant <= TimeSpan.Zero)
            {
                Stop();
                foreach (var obs in _observateurs)
                {
                    NotificationSimulation notif = new NotificationSimulation{ Type = NotificationSimulationType.TimerTick };
                    obs.OnNext(notif); // Notify timer end
                }
            }
        }

        public IDisposable Subscribe(IObserver<NotificationSimulation> observateur)
        {
            // Si l'obervateur n'est pas encore dans la liste, on l'ajoute
            if (_observateurs.Add(observateur))
            {
                // On lui envoie les notifications
                foreach (var notif in _notifications)
                {
                    observateur.OnNext(notif);
                }
            }
            return new Unsubscriber<NotificationSimulation>(_observateurs, observateur);
        }
    }
}
