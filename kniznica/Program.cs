using System.ComponentModel;

namespace kniznica;

class Program
{
    static void Main(string[] args)
    {
        kniznica PrvaKniznica = new kniznica();
        
        kniha Hobit = new kniha();
        Hobit.Autor = "J.R.R. Tolkien";
        Hobit.Nazov = "Hobit";
        Hobit.RokVydanie = 1937;
        Hobit.StatusPožičania = false;
        PrvaKniznica.zoznam.Add(Hobit);
        

        kniha PanPrstenov = new kniha();
        PanPrstenov.Autor = "J.R.R. Tolkien";
        PanPrstenov.Nazov = "Pán Prsteňov: Spoločenstvo Prsteňa";
        PanPrstenov.RokVydanie = 1954;
        PanPrstenov.StatusPožičania = false;
        PrvaKniznica.zoznam.Add(PanPrstenov);


        kniha Malýprinc = new kniha();
        Malýprinc.Autor = "Antoine de Saint-Exupéry";
        Malýprinc.Nazov = "Malýprinc";
        Malýprinc.RokVydanie = 1943;
        Malýprinc.StatusPožičania = false;
        PrvaKniznica.zoznam.Add(Malýprinc);


        kniha Pýcha = new kniha();
        Pýcha.Autor = "Jane Austen";
        Pýcha.Nazov = "Pýcha a predsudok";
        Pýcha.RokVydanie = 1813;
        Pýcha.StatusPožičania = false;
        PrvaKniznica.zoznam.Add(Pýcha);

        Console.WriteLine(Hobit.Autor);
        Console.WriteLine(Pýcha.Autor);
        Console.WriteLine(PanPrstenov.Autor);
        Console.WriteLine(Malýprinc.Autor);

        Console.WriteLine("Príkaz - pridat knihu - || - vyhladat autora -");
        Console.WriteLine("Čo chceš vykonať?");
        string prikaz = Console.ReadLine().ToLower();

        if (prikaz == "pridat knihu")
        {
            PrvaKniznica.Pridavanie_Knih();
        }

        if (prikaz == "vyhladat autora")
        {
            Console.WriteLine("Akého autora chceš vyhladať?");
            string autor_hladanie = Console.ReadLine();

            for (int i = 0; i < PrvaKniznica.zoznam.Count; i++)
            {
                if (PrvaKniznica.zoznam[i].Autor == autor_hladanie)
                {
                    Console.WriteLine(PrvaKniznica.zoznam[i].Nazov);
                    Console.WriteLine(PrvaKniznica.zoznam[i].Autor);
                    Console.WriteLine(PrvaKniznica.zoznam[i].RokVydanie);
                    Console.WriteLine(PrvaKniznica.zoznam[i].StatusPožičania);

                }
                else
                {
                    Console.WriteLine("zlý autor");
                }
            }
        }

    }
}

class kniha
{
    public string Nazov;
    public string Autor;
    public int RokVydanie;
    public Boolean StatusPožičania;
    
}

class kniznica
{
    public List<kniha> zoznam = new List<kniha>();

    public void Pridavanie_Knih()
    {
        Console.WriteLine("Aký názov chceš pridať?");
        string nazovknihy = Console.ReadLine();
        kniha kniha_id = new kniha();
        kniha_id.Nazov = nazovknihy;
        Console.WriteLine("Akého Autora chceš pridať?");
        string autorknihy = Console.ReadLine();
        kniha_id.Autor = autorknihy;
        Console.WriteLine("Kedy bola tvoja kniha vydaná?");
        int rok_vydania = 0;
        int.TryParse(Console.ReadLine(),out rok_vydania);
        kniha_id.RokVydanie = rok_vydania;
        zoznam.Add(kniha_id);
        Console.WriteLine(kniha_id.Autor[0]);
        
    }
    
}
