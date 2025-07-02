namespace ReseauDeBus.Backend.Parametre;

public abstract class Planifiable
{
    public List<Creneau> horaires { get; }

    public Planifiable(List<Creneau> creneaux)
    {
        horaires = new List<Creneau>();
        foreach (Creneau c in creneaux)
        {
            horaires.Add(new Creneau(c.plage_creneau, c.moyenne_creneau, c.ecartType_creneau));
        }
    }

    public List<Creneau> GetByPlageCreneau((int, int) plageCreneau)
    {
        List<Creneau> ret = new List<Creneau>();
        foreach (Creneau c in horaires)
        {
            if (c.plage_creneau == plageCreneau)
            {
                ret.Add(c);
            }
        }
        return ret;
    } 
        
    public void AddCreneau(Creneau creneau)
    {
        if (horaires.All(c => 
                c.plage_creneau != creneau.plage_creneau &&
                c.moyenne_creneau != creneau.moyenne_creneau &&
                c.ecartType_creneau != creneau.ecartType_creneau))
        {
            horaires.Add(new Creneau(creneau.plage_creneau, creneau.moyenne_creneau, creneau.ecartType_creneau));
        }
    }

    public void RemoveCreneau(Creneau creneau)
    {
        horaires.RemoveAll(c => 
            c.plage_creneau == creneau.plage_creneau && 
            c.moyenne_creneau == creneau.moyenne_creneau &&
            c.ecartType_creneau == creneau.ecartType_creneau);
    }
    
    public TimeSpan GetDuree(DateTime date)
    {
        var heureDate = date.Hour;
        TimeSpan temps = TimeSpan.Zero;
        foreach (Creneau c in horaires)
        {
            var heureDeb = c.plage_creneau.Item1;
            var heureFin = c.plage_creneau.Item1;
            if (heureDeb <= heureDate && heureFin >= heureDate)
            {
                temps = c.GetDuree();
            }
        }
        return temps;
    }
}