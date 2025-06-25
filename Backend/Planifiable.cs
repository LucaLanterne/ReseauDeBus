namespace ReseauDeBus.Backend;

public abstract class Planifiable
{
    public List<Creneau> horaires { get; }

    public Planifiable(List<Creneau> creneauxArret)
    {
        horaires = new List<Creneau>();
        foreach (Creneau c in creneauxArret)
        {
            horaires.Add(new Creneau(c.plage_creneau, c.moyenne_creneau, c.ecartType_creneau));
        }
    }

    public List<Creneau> getByPlageCreneau((int, int) plageCreneau)
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
        horaires.Add(new Creneau(creneau.plage_creneau, creneau.moyenne_creneau, creneau.ecartType_creneau));
    }

    // public void RemoveCreneau(Creneau creneau)
    // {
    //     horaires.Remove();
    // }
}