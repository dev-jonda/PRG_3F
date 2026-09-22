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
        /*
        int a = 6;
        if (a > 5)
        {
            Console.WriteLine($"Uživatel zvolil číslo, které má hodnotu větší než 5");
        }
        else
        {
            Console.WriteLine($"Uživatel zvolil číslo větší než 5: {a}");
        }

        int i = int.Parse(Console.ReadLine());
        bool pravda = i > 5 && i < 10;
        if (pravda)
        {
            Console.WriteLine("True");
        }
        */
        
        // Početní operace - sčítání a podmínky
        /*
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        if ((x + y) > 15)
        {
            Console.WriteLine($"Součet je větší než 15, součet: {x + y}");       
        }
        else
        {
            Console.WriteLine($"Součet je menší než 15, součet: {x +y}");
        }
        */
        
        // Elo rating
        /*
        Console.WriteLine($"Zadejte vaše elo: ");
        int elo = int.Parse(Console.ReadLine());
        if (elo >= 1000)
        {
            Console.WriteLine($"Váš rank je Diamond - elo: {elo}");
            Console.WriteLine($"Dosáhli jste nejvyššího ranku!");
        }
        else if (elo >= 600)
        {
            Console.WriteLine($"Váš rank je Gold - elo: {elo}");
            Console.WriteLine($"Pro dosažení dalšího ranku Vám zbývá: {1000 - elo}");
        }
        else
        {
            Console.WriteLine($"Váš rank je Bronz - elo: {elo}");
            Console.WriteLine($"Pro dosažení dalšího ranku Vám zbývá: {600 - elo}");
        }
        */
        
        // Elo extended
        /*
        Console.WriteLine($"Zadejte vaše extended elo: ");
        int elo_extended = int.Parse(Console.ReadLine());
        String rank;
        if (elo >= 1000)
        {
            rank = "Diamond";
        }
        else if (elo >= 600)
        {
            rank = "Gold";
        }
        else
        {
            rank = "Bronze";
        }
        Console.WriteLine($"Vaše elo: {elo}");
        Console.WriteLine($"Váš rank: {rank}");
        */
        
        // Switch - herní menu
        /*
        Console.WriteLine("1. Pokračuj ve hře\n2. Ulož hru\n3. Načti hru\nVyberte číslo: ");
        int volba = int.Parse(Console.ReadLine());
        switch (volba)
        {
            case 1:
                Console.WriteLine("Pokračujeme ve hře...");
                break;
            case 2:
                Console.WriteLine("Ukládám hru...");
                break;
            case 3:
                Console.WriteLine("Načítám hru...");
                break;
            default:
                Console.WriteLine("Zadejte číslo 1 až 3!");
                break;
        }
        */
        
        // Kalkulačka
        /*
        Console.WriteLine("Zadej první číslo: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Zadej druhé číslo: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("1. Sčítání\n2. Odečítání\n3. Násobení\n 4. Dělení\n 5. Mocnění\n 6. Druhá mocnina (zadejte pouze první číslo a druhé dejte nula)\nVyberte číslo: ");
        int operation = int.Parse(Console.ReadLine());
        switch (operation)
        {
            // Sčítání
            case 1:
                Console.WriteLine($"Výsledek sčítání: {num1 + num2}");
                break;
            // Odečítání
            case 2:
                Console.WriteLine($"Výsledek odčítání: {num1 - num2}");
                break;
            // Násobení
            case 3:
                Console.WriteLine($"Výsledek násobení: {num1 * num2}");
                break;
            // Dělení
            case 4:
                Console.WriteLine($"Výsledek dělení: {num1 / num2}");
                break;
            // Mocnění
            case 5:
                Console.WriteLine($"Výsledek Pow: {Math.Pow(num1, num2)}");
                break;
            // Druhá odmocnina
            case 6:
                Console.WriteLine($"Výsledek Sqrt: {Math.Sqrt(num1)}");
                break;
        }
        */
        
        // jojo
        /*
        bool isDoktor = true;
        string clovek = isDoktor ? "Doktor" : "Pacient";
        Console.WriteLine(clovek);
        */
        
        // while cyklus
        
        string operation = "";
        while (operation != "exit")
        {
            Console.WriteLine("Zadej první číslo: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("{+} Sčítání\n{-} Odečítání\n{*} Násobení\n{/} Dělení\n{Pow} Mocnění\n{Sqrt} Druhá mocnina (zadejte pouze první číslo a druhé dejte nula)\nVyberte operaci: ");
            operation = Console.ReadLine();
            Console.WriteLine("Zadej druhé číslo: ");
            double num2 = double.Parse(Console.ReadLine());
            
            switch (operation)
            {
                // Sčítání
                case "+": // nemusí být jenom čísla může být v uvozovkách i třeba string
                    Console.WriteLine($"Výsledek sčítání: {num1 + num2}");
                    break;
                // Odečítání
                case "-":
                    Console.WriteLine($"Výsledek odčítání: {num1 - num2}");
                    break;
                // Násobení
                case "*":
                    Console.WriteLine($"Výsledek násobení: {num1 * num2}");
                    break;
                // Dělení
                case "/":
                    Console.WriteLine($"Výsledek dělení: {num1 / num2}");
                    break;
                // Mocnění
                case "Pow":
                    Console.WriteLine($"Výsledek Pow: {Math.Pow(num1, num2)}");
                    break;
                // Druhá odmocnina
                case "Sqrt":
                    Console.WriteLine($"Výsledek Sqrt: {Math.Sqrt(num1)}");
                    break;
                case "exit":
                    Console.WriteLine("Ukončuji program");
                    break;
            }   
        }
    }
}