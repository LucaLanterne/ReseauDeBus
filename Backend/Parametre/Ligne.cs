namespace ReseauDeBus.Backend.Parametre;

public class Ligne : StructureTransport
{
    public string id_ligne { get; }
    public string nom_ligne { get; }
    
    public Ligne(string idLigne, string nomLigne, List<Arret> arretsLigne, List<Troncon> tronconsLigne) : base(arretsLigne, tronconsLigne)
    {
        id_ligne = idLigne;
        nom_ligne = nomLigne;
    }
}