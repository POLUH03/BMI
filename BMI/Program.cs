class Program
{

    public static void Bmi()
    {
        Console.WriteLine("Podaj swoją wagę w kilogramach: ");
        double waga = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Podaj swój wzrost w metrach np. 1,70: ");
        double wzrost = Convert.ToDouble(Console.ReadLine());
        double bmi = waga / (wzrost * wzrost);
        Console.WriteLine(bmi);

    }
    static void Main(string[] args)
    {
        Bmi();
    }
}