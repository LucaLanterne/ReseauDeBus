using ReseauDeBus.Backend.Parametre;

namespace ReseauDeBus.Backend.Simulation;

public class InfoTrafic
{
    public string id_infoTrafic { get; }
    public int sensCirculation_infoTrafic { get; set; }
    public bool lancement_infoTrafic { get; set; } = false;
    public Planifiable emplacementBus_infoTrafic { get; set; }
    public Bus bus_infoTrafic { get; set; }
    public Ligne ligne_infoTrafic { get; set; }
    public IEtatBus etatBus_infoTrafic { get; set; }
    public DateTime horaireDepart_infoTrafic {get; set;}
    public Simulation simulation_infoTrafic { get; set; }

    public InfoTrafic(string idInfoTrafic, int sensCirculationInfoTrafic, Bus busInfoTrafic, Ligne ligneInfoTrafic, DateTime horaireDepartInfoTrafic, Simulation simulationInfoTrafic)
    {
        id_infoTrafic = idInfoTrafic;
        sensCirculation_infoTrafic = sensCirculationInfoTrafic;
        emplacementBus_infoTrafic = null;
        bus_infoTrafic = busInfoTrafic;
        ligne_infoTrafic = ligneInfoTrafic;
        horaireDepart_infoTrafic = new DateTime(horaireDepartInfoTrafic.Year, horaireDepartInfoTrafic.Month, horaireDepartInfoTrafic.Day, horaireDepartInfoTrafic.Hour, horaireDepartInfoTrafic.Minute, horaireDepartInfoTrafic.Second);
        simulation_infoTrafic = simulationInfoTrafic;
        etatBus_infoTrafic = null;
    }

    public void Tick()
    {
        this.etatBus_infoTrafic.OnTick(this);
    }
    
    // Méthode pour changer de sens
    public void ChangerDeSens()
    {
        this.sensCirculation_infoTrafic = -this.sensCirculation_infoTrafic;
    }
    
    // Méthode pour faire avancer le bus
    public void StartBus()
    {
        this.etatBus_infoTrafic = new EnArret(this);
        this.lancement_infoTrafic = true;
    }
    
    //Méthode qui calcul le temps d'arret ou de chargement/dechargement
    public TimeSpan CalcTempsPlanifiable()
    {
        return this.emplacementBus_infoTrafic.GetDuree(
            this.simulation_infoTrafic.chronometre_simulation.GetTempsCourant());
    }
    
    // Méthode pour récupérer le planifiable suivant
    public bool NextEmplacement()
    {
        // Si le bus est dans le sens aller
        if (this.sensCirculation_infoTrafic == 1)
        {
            if (this.emplacementBus_infoTrafic == null)
            {
                this.emplacementBus_infoTrafic = this.ligne_infoTrafic.troncons.First().arretA_troncon;
            }
            // Dans le cas d'un arrêt on récupère le troncons suivant
            else if (this.emplacementBus_infoTrafic is Arret)
            {
                Arret a = this.emplacementBus_infoTrafic as Arret;
                Troncon tLast = this.ligne_infoTrafic.troncons.FindLast(t =>
                    t.arretA_troncon.id_arret == a.id_arret)!;
                if (tLast != null)
                {
                    this.emplacementBus_infoTrafic = tLast;
                }
                // Si aucun tronçon ne correspond on repart en arrière
                else
                {
                    this.ChangerDeSens();
                    this.emplacementBus_infoTrafic = this.ligne_infoTrafic.troncons.FindLast(t =>
                        t.arretB_troncon.id_arret == a.id_arret)!;
                }
            }
            // On passe au terminus du troncons
            else if (this.emplacementBus_infoTrafic is Troncon)
            {
                Troncon t = emplacementBus_infoTrafic as Troncon;
                this.emplacementBus_infoTrafic = t.arretB_troncon;
            }
            return true;
        }
        // Si le bus est sur le retour
        else
        {
            if (this.emplacementBus_infoTrafic is Arret)
            {
                Arret a = this.emplacementBus_infoTrafic as Arret;
                Troncon tLast = this.ligne_infoTrafic.troncons.FindLast(t =>
                    t.arretB_troncon.id_arret == a.id_arret)!;
                if (tLast != null)
                {
                    this.emplacementBus_infoTrafic = tLast;
                }
                // Si aucun tronçon ne correspond le parcours est fini
                else
                {
                    this.emplacementBus_infoTrafic = null;
                    return false;
                }
            }
            // On passe au terminus du troncons
            else if (this.emplacementBus_infoTrafic is Troncon)
            {
                Troncon t = emplacementBus_infoTrafic as Troncon;
                this.emplacementBus_infoTrafic = t.arretA_troncon;
            }
            return true;
        }
        
    }
}