namespace ReseauDeBus.Backend.Simulation;

public readonly record struct NotificationSimulation(NotificationSimulationType Type);
public enum NotificationSimulationType
{
    TimerStart, TimerEnd, TimerTick
}