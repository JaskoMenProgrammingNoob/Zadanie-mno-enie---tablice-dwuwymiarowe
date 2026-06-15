class Program
{
    static void Main(string[] args)
    {
        int n = 11;
        int[,] tabliczka = new int[n, n];
        int npsrednia = 0;
        int psrednia = 0;
        int sumanp = 0;
        int sumap = 0;
        /* int sprawdzilenp = 0; */
        /* int sprawdzilep = 0; */
        for (int i = 1; i < n; i++)
        {
            for (int j=1; j < n; j++)
            {
                tabliczka[i, j] = i * j;
            Console.Write($"{tabliczka[i, j],4}");
                if (tabliczka[i, j] % 2 != 0)
                {
                    /* sprawdzilenp = tabliczka[i, j]; */
                    sumanp += tabliczka[i, j];
                    npsrednia = sumanp / 25;
                } else
                {
                   /* sprawdzilep += tabliczka[i, j]; */
                    sumap += tabliczka[i, j];
                    psrednia = sumap / 75;
                }
            }
            Console.WriteLine();
            
        }
        /* Console.WriteLine($"Liczba nieparzystych: {sprawdzilenp}"); */
        Console.WriteLine($"Nieparzyste: {sumanp}");
        Console.WriteLine($"Średnia nieparzystych: {npsrednia}");
        Console.WriteLine($"Parzyste: {sumap}");
        Console.WriteLine($"Średnia parzystych: {psrednia}");






    }





}