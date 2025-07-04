using System;
using System.Collections.Generic;
using System.Linq;
using ReseauDeBus.Backend.Parametre;

namespace ReseauDeBus.Backend.Initialisation;

public class BasicReseauBuilder : ReseauBuilder
{
    private readonly Random _rand = new();

    // Collections internes
    private Dictionary<int, Arret> _arrets;
    private List<Troncon> _troncons;
    private List<Ligne> _lignes;
    private Reseau _reseau;

    protected override void Regenerer()
    {
        _arrets = new();
        _troncons = new();
        _lignes = new();
        _reseau = null;
    }

    protected override void BuildArrets()
    {
        foreach (var (id, nom, x, y) in _arretsData)
        {
            _arrets[id] = new Arret(
                id.ToString(),
                nom,
                (int)x,
                (int)y,
                GenererCreneaux(8, 300, 900, 20, 90)
            );
            Console.WriteLine($"  Arret {nom} créé");
        }
    }

    protected override void BuildTroncons()
    {
        foreach (var ligne in _lignesData)
        {
            var arretsLigne = GetArrets(ligne.ArretsIds);
            for (int i = 0; i < arretsLigne.Count - 1; i++)
            {
                var troncon = new Troncon(
                    $"T_{ligne.Id}_{i}",
                    arretsLigne[i],
                    arretsLigne[i + 1],
                    GenererCreneaux(8, 600, 1200, 30, 120)
                );
                _troncons.Add(troncon);
                Console.WriteLine($"  Troncon {troncon.id_troncon} créé");
            }
        }
    }

    protected override void BuildLignes()
    {
        foreach (var ligne in _lignesData)
        {
            var arretsLigne = GetArrets(ligne.ArretsIds);
            _lignes.Add(new Ligne(
                ligne.Id,
                ligne.Nom,
                arretsLigne,
                new List<Troncon>()
            ));
            Console.WriteLine($"  Ligne {ligne.Nom} créée");
        }
    }

    protected override void BuildReseauFinal()
    {
        _reseau = new Reseau(
            "1",
            "Réseau d'Amiens",
            _lignes,
            _troncons,
            new List<Arret>(_arrets.Values)
        );
        Console.WriteLine("Réseau assemblé.");
    }

    public Reseau GetReseau()
    {
        return _reseau;
    }

    private List<Arret> GetArrets(int[] ids)
    {
        return ids.Select(id => _arrets[id]).ToList();
    }

    private List<Creneau> GenererCreneaux(int nb, int minMoyenne, int maxMoyenne, int minEcart, int maxEcart)
    {
        var plages = new (int, int)[]
        {
            (6,8),(8,10),(10,12),(12,14),(14,16),(16,18),(18,20),(20,22)
        };

        var result = new List<Creneau>();
        foreach (var (debut, fin) in plages)
        {
            result.Add(new Creneau(
                (debut, fin),
                _rand.Next(minMoyenne, maxMoyenne),
                _rand.Next(minEcart, maxEcart)
            ));
        }
        return result;
    }

    // Données des arrêts
    private readonly (int, string, float, float)[] _arretsData =
    [
        (1,"Promenade",24,0),(2,"Centre commercial Nord",22,1),(3,"Romain Rolland",22,2),
            (4,"Espace santé",22,3),(5,"Pôle d'échanges Nord",22,4),(6,"Berlioz",22,5),
            (7,"Clémenceau",21,6),(8,"Citadelle François 1er",21,8),(9,"Citadelle Monstrescu",20,9),
            (10,"Vogel",18,11),(11,"Saint Leu",20,12),(12,"Place de Don",22,13),
            (13,"Alsace Lorraine",24,14),(14,"Gare du Nord",23,17),(15,"Otages",21,18),
            (16,"Cirque Jules Verne",19,18),(17,"Collège Saint Martin",18,20),(18,"Delpech",17,22),
            (19,"Cité - Providence",19,23),(20,"Charassin",20,24),(21,"Aquapôle",20,26),
            (22,"Pôle des cliniques",19,25),(23,"Georges Beauvais",15,25),(24,"Espagne",13,26),
            (25,"Grèce",12,27),(26,"IME",10,29),(27,"Centre Commercial Sud",10,30),
            (28,"Etouvie",0,3),(29,"Martinique",1,2),(30,"Collège Rosa Parks",2,2),
            (31,"Languedoc",4,2),(32,"Les Coursives",3,3),(33,"La Fontaine",3,4),
            (34,"Place La Barre",4,5),(35,"Sully",6,6),(36,"Espace Alliance",9,7),
            (37,"Faubourg de Hem",10,7),(38,"Eglise Saint Firmin",11,8),(39,"Zoo d'Amiens",13,9),
            (40,"Jean Jaures",14,11),(41,"Saint-Jacques",15,12),(42,"Maison de la Culture",17,13),
            (43,"Place du Marché",17,13),(44,"Beffroi",19,13),(45,"Dusevel",20,14),
            (46,"Palais de Justice",21,15),(47,"René Goblet",21,16),(48,"Caserne Dejean",25,18),
            (49,"Pinceau",27,19),(50,"Lycée de Luzarches",28,20),(51,"Eglise Saint Acheul",29,21),
            (52,"Mercey",30,22),(53,"Sobo",31,22),(54,"Pont de l'Avre",33,23),
            (55,"Cité du Château",35,24),(56,"La Rose Rouge",35,25),(57,"Poidevin",36,26),
            (58,"Mairie de Longueau",37,26),(59,"La Fournche",38,27),(60,"Croix de Fer",40,27),
            (61,"Centre Commercial Glisy",42,29),(62,"Capitaine Nemo",43,30),(63,"Pôle Jules Verne",45,30),
            (64,"La Paix",19,4),(65,"Chardin",21,4),(66,"Colvert",24,4),(67,"Nautilus",26,5),
            (68,"Balzac",27,5),(69,"Stendhal",28,6),(70,"Centre Saint Victor",28,7),
            (71,"Eloi Morel",27,9),(72,"Parc Saint Pierre",26,11),(73,"Hortillonnages",25,13),
            (75,"Nicole Fontaine",16,16),(76,"Simone Veil",14,15),(77,"Quatre Chênes",12,18),
            (78,"Libération",11,19),(79,"Quatre Lemaire",11,20),(80,"Ambroise Paré",7,23),
            (81,"Rotonde",5,23),(82,"CHU Amiens Picardie",3,24),(83,"Laënnec",3,26),
            (84,"Résidence du Thil",5,26),(85,"IUT",7,26),(86,"Pôle Licorne",7,11),
            (87,"Hyppodrome",9,12),(88,"Colbert",11,14),(89,"Lucien Fournier",12,14),
            (90,"Hôtel de Ville",17,15),(91,"Jacobins",19,15),(92,"Emile Zola",21,16),
            (93,"Mons",27,21),(94,"3ième DI",26,22),(95,"Hôtel des Impôts",25,23),
            (96,"Rollin",26,24),(97,"Ormale",27,24),(98,"Görlitz",28,26),(99,"Frédéric Mistral",28,27),
            (100,"Collège Guy Mareschal",29,27),(101,"IREAM",31,26),(102,"Bel Air",31,28),
            (103,"Wasse",32,29),(104,"Place de Cagny",33,30),(105,"Latapie",33,29),
            (106,"Longueau SNCF",36,29)
    ];

    // Données des lignes
    private readonly (string Id, string Nom, int[] ArretsIds)[] _lignesData =
    [
        ("1", "Nemo 1", new[]{28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,14,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63}),
        ("2", "Nemo 2", new[]{64,65,66,67,68,69,70,71,72,73,13,14,15,16,75,76,77,78,79,80,81,82,83,84,85}),
        ("3", "Nemo 3", new[]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27}),
        ("4", "Nemo 4", new[]{86,87,88,89,76,75,90,91,92,14,48,49,50,93,94,95,96,97,98,99,100,101,102,103,104,105,106})
    ];
}