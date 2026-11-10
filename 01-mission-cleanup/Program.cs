var name = new List<string> { "Ada", "Bo", "Cy" };
const int minRequiredCrew = 3;

Console.WriteLine($"Crew: {name.Count}");

if (name.Count >= minRequiredCrew)
{
    Console.WriteLine("Ready");
}
else
{
    Console.WriteLine("Waiting");
}
