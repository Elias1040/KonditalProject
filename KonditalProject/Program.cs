using KonditalProject;
int hvilepuls, maxpuls;

Console.WriteLine("hvilepuls:");
while (!int.TryParse(Console.ReadLine(), out hvilepuls))
{
    Console.WriteLine("Ugyldig værdi!");
    Thread.Sleep(1500);
    Console.Clear();
    Console.WriteLine("hvilepuls:");
}
Console.Clear();

Console.WriteLine("maxpuls:");
while (!int.TryParse(Console.ReadLine(), out maxpuls))
{
    Console.WriteLine("Ugyldig værdi!");
    Thread.Sleep(1500);
    Console.Clear();
    Console.WriteLine("maxpuls:");
}
Console.Clear();