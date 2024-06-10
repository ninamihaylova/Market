class Market
{
    static void Main(string[] args)
    {
        
        decimal tomatoPrice = decimal.Parse(Console.ReadLine());
        double tomatoQuantity = double.Parse(Console.ReadLine());
        decimal cucumberPrice = decimal.Parse(Console.ReadLine());
        double cucumberQuantity = double.Parse(Console.ReadLine());

        decimal totalCost = tomatoPrice * (decimal)tomatoQuantity + cucumberPrice * (decimal)cucumberQuantity;
        Console.WriteLine($"{totalCost:F2}");
    }
    }