class IgralnayaKost
{
    Random r;

    public IgralnayaKost()
    {
        r = new Random();
    }

    public int random()
    {
        int res = r.Next(6) + 1;
        return res;
    }

}

class Gamer
{
    string Name;
    IgralnayaKost seans;

    public Gamer(string name)
    {
        Name = name;
        seans = new IgralnayaKost();
    }

    public int SeansGame()
    {
        return seans.random();
    }

    public override string ToString()
    {
        return Name;
    }

}

class Program
{
    public static void Main()
    {
        Gamer g1 = new Gamer("Niko");
        for (int i = 1; i <= 6; i++)
            Console.WriteLine($"Выпало количество очков {g1.SeansGame()} для игрока {g1.ToString()}");
    }
}
