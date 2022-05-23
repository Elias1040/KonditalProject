using KonditalProject;

int _hvilepuls, _maxpuls, _kondital;
double _vægt;

Console.WriteLine("hvilepuls:");
_hvilepuls = ValueChecker();
Console.Clear();

Console.WriteLine("maxpuls:");
_maxpuls = ValueChecker();
Console.Clear();

Console.WriteLine("vægt:");
_vægt = DValueChecker();
Console.Clear();

_kondital = Kondital.BeregnKondital(_hvilepuls, _maxpuls);
Console.WriteLine($"Kondital: {_kondital} ml/kg/min");

Console.WriteLine($"Iltoptagelse: {BeregnIltoptagelse(_hvilepuls, _vægt)} l/ml");

static double BeregnIltoptagelse(int kondital, double vægt)
{
    return Math.Round(kondital * vægt / 1000, 1);
}



static int ValueChecker()
{
    int _value;
    while (!int.TryParse(Console.ReadLine(), out _value))
    {
        Console.Clear();
        Console.WriteLine("Ugyldig værdi!");
        Thread.Sleep(1500);
        Console.Clear();
        Console.WriteLine("Indtast et tal:");
    }
    return _value;
}

static double DValueChecker()
{
    double _value;
    while (!double.TryParse(Console.ReadLine(), out _value))
    {
        Console.Clear();
        Console.WriteLine("Ugyldig værdi!");
        Thread.Sleep(1500);
        Console.Clear();
        Console.WriteLine("Indtast et tal:");
    }
    return _value;
}
