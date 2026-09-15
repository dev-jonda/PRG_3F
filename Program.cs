namespace PRG_ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        // Obsah obdelníku
        /* Console.WriteLine("Zadejte stranu A: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Zadejte stranu B: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"Obsah obdelníku je: "+ (a * b)); */
        
        // Obsah kruhu
        /*
        Console.WriteLine("Zadejte poloměr kruhu: ");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine($"Obsah kruhu je: "+ Math.PI * Math.Pow(r, 2));
        */
        int a = 6;
        if (a > 5)
        {
            Console.WriteLine($"Uživatel zvolil číslo, které má hodnotu větší než 5");
        }
        else
        {
            Console.WriteLine($"Uživatel zvolil číslo větší než 5: {a}");
        }
    }
}