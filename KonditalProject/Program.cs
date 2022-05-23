using KonditalProject;

int _hvilepuls, _maxpuls;

Console.WriteLine("hvilepuls:");
_hvilepuls = ValueChecker();
Console.Clear();

Console.WriteLine("maxpuls:");
_maxpuls = ValueChecker();
Console.Clear();

Console.WriteLine("Kondital: " + Kondital.BeregnKondital(_hvilepuls, _maxpuls));

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
