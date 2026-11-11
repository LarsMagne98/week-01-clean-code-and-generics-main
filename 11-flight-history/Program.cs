History<string> history = new History<string>();
History<int> numbers = new History<int>();

history.Add("Launch");
history.Add("Orbit");
numbers.Add(42);
numbers.Add(44);

List<string> snapshot = history.GetSnapshot();

Console.WriteLine($"History: {history.Count}");
Console.WriteLine($"Snapshot: {snapshot.Count}");
Console.WriteLine($"Numbers: {numbers.Count}");

snapshot.Clear();

Console.WriteLine($"History: {history.Count}");
Console.WriteLine($"Snapshot: {snapshot.Count}");
Console.WriteLine($"Numbers: {numbers.Count}");

snapshot = history.GetSnapshot();
history.Add("Landing");
numbers.Add(13);

Console.WriteLine($"History: {history.Count}");
Console.WriteLine($"Snapshot: {snapshot.Count}");
Console.WriteLine($"Numbers: {numbers.Count}");

history.Clear();

Console.WriteLine($"History: {history.Count}");
Console.WriteLine($"Snapshot: {snapshot.Count}");
Console.WriteLine($"Numbers: {numbers.Count}");
