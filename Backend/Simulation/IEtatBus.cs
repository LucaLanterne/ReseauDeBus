namespace ReseauDeBus.Backend.Simulation;

public interface IEtatBus
{
    void OnTick(Bus bus, TimeSpan elapsedTime, DateTime heureSimulee);
}