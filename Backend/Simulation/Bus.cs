using ReseauDeBus.Backend.Parametre;

namespace ReseauDeBus.Backend.Simulation;

public class Bus
{
    public IEtatBus EtatCourant { get; set; }
    public string id_bus { get; set; }
    public int arret_bus { get; private set; }
    public bool sensCirculation_bus { get; set; }
    public static readonly Random rng = new Random();
    
    public Bus()
    {
        EtatCourant = new EnArret();
    }

    public void Tick(TimeSpan elapsedTime)
    {
        this.EtatCourant.OnTick(this,elapsedTime);
    }
    
    public TimeSpan GetTempsPlanifiable(Planifiable planifiable, DateTime heureSimulee)
    {
        int heure = heureSimulee.Hour;
        Creneau creneau = planifiable.horaires.FirstOrDefault(c => 
            heure >= c.plage_creneau.Item1 &&
            heure < c.plage_creneau.Item2) ?? throw new Exception("Pas de plage horaire correspondant à " + heure + "h" );
        int temps = creneau.moyenne_creneau + rng.Next(-creneau.ecartType_creneau, creneau.ecartType_creneau + 1);
        return TimeSpan.FromSeconds(temps);
    }

    // public TimeSpan GetTempsArret(Arret arret, DateTime heureSimulee)
    // {
    //     int heure = heureSimulee.Hour;
    //     Creneau creneau = arret.creneaux_arret.FirstOrDefault(c => 
    //         heure >= c.plage_creneau.Item1 &&
    //         heure < c.plage_creneau.Item2) ?? throw new Exception("Pas de plage horaire correspondant à " + heure + "h");
    //     int temps = creneau.moyenne_creneau + rng.Next(-creneau.ecartType_creneau, creneau.ecartType_creneau + 1);
    //     return TimeSpan.FromSeconds(temps);
    // }
    // public bool EstAuTerminus()
    // {
    //     Ligne ligne1 = new Ligne("1","test",new List<Arret>(), new List<Troncon>());
    //     return ligne1.arrets_ligne.Count == arret_bus ?? true : false;
    // }
    public void ChangeSens()
    {
        sensCirculation_bus = !sensCirculation_bus;
    }

    public void AvanceArret()
    {
        Ligne ligne1 = new Ligne("1","test",new List<Arret>(), new List<Troncon>());
        if (sensCirculation_bus)
        {
            if (ligne1.arrets_ligne.Count == arret_bus)
            {
                ChangeSens();
                arret_bus--;
            } else 
                arret_bus++;
        }
        else 
        {
            if (arret_bus == 0)
            {
                ChangeSens();
                arret_bus++;
            } else 
                arret_bus--;
        }
    }
    
}