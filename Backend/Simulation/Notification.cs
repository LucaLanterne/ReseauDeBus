namespace ReseauDeBus.Backend.Simulation;

public class Notification(DateTime date, string message)
{
    public DateTime dateMessage { get; } = date;
    public String Message { get; } = message;
}