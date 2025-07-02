using System.Timers;
using Timer = System.Timers.Timer;

namespace ReseauDeBus.Backend.Simulation
{
    public class Chronometre : IObservable<DateTime>
    {
        private Timer? chrono;
        private int frequence = 1000; // en ms (1 tick/seconde réelle)
        private DateTime debut;
        private TimeSpan dureeChrono = TimeSpan.FromMinutes(1);
        private TimeSpan tempsRestant;
        public bool IsActif { get; private set; } = false;

        private readonly HashSet<IObserver<DateTime>> observateurs = new();

        public void Start(int delaiMs, TimeSpan duree)
        {
            frequence = delaiMs;
            dureeChrono = duree;
            tempsRestant = duree;
            debut = DateTime.Now;

            chrono = new Timer(frequence);
            chrono.Elapsed += Tick;
            chrono.Enabled = true;
            IsActif = true;

            foreach (var obs in observateurs)
            {
                obs.OnNext(debut); // Notify start time
            }
        }

        public void Stop()
        {
            if (chrono != null)
            {
                chrono.Stop();
                chrono.Dispose();
                chrono = null;
                IsActif = false;
            }
        }

        private void Tick(object? sender, ElapsedEventArgs e)
        {
            tempsRestant = dureeChrono - (e.SignalTime - debut);

            foreach (var obs in observateurs)
            {
                obs.OnNext(e.SignalTime); // Notify real current time
            }

            if (tempsRestant <= TimeSpan.Zero)
            {
                Stop();
                foreach (var obs in observateurs)
                {
                    obs.OnCompleted();
                }
            }
        }

        public IDisposable Subscribe(IObserver<DateTime> observer)
        {
            observateurs.Add(observer);
            return new Unsubscriber<DateTime>(observateurs, observer);
        }

        private class Unsubscriber<T> : IDisposable
        {
            private readonly ISet<IObserver<T>> _observers;
            private readonly IObserver<T> _observer;

            public Unsubscriber(ISet<IObserver<T>> observers, IObserver<T> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                _observers.Remove(_observer);
            }
        }
    }
}
