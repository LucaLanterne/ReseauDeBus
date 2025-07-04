namespace ReseauDeBus.Backend.Initialisation;

public abstract class ReseauBuilder
{
    public void BuildReseau()
    {
        Console.WriteLine("Réinitialisation des collections...");
        Regenerer();

        Console.WriteLine("Création des arrêts...");
        BuildArrets();

        Console.WriteLine("Création des tronçons...");
        BuildTroncons();

        Console.WriteLine("Création des lignes...");
        BuildLignes();

        Console.WriteLine("Assemblage final...");
        BuildReseauFinal();

        Console.WriteLine("Réseau généré avec succès.");
    }

    protected abstract void Regenerer();
    protected abstract void BuildArrets();
    protected abstract void BuildTroncons();
    protected abstract void BuildLignes();
    protected abstract void BuildReseauFinal();
}