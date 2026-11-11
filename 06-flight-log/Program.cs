FlightLog log = new FlightLog();
Console.WriteLine(log.Count);
log.Add("Launch");
Console.WriteLine(log.Count);
log.Add("Orbit");
Console.WriteLine(log.Count);
log.Clear();
Console.WriteLine(log.Count);
log.Clear();
Console.WriteLine(log.Count);
log.Add("");
Console.WriteLine(log.Count);

Console.WriteLine("----");
FlightLog log2 = new FlightLog();
Console.WriteLine(log2.Count);
