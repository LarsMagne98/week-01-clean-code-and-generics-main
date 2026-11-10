string label = "READY";
var retries = "3";
List<string> messages = new List<string> { label };

messages.Add(retries);

foreach (string message in messages)
{
    Console.WriteLine(RepeatLabel(message));
}
Console.WriteLine(messages.Count);


static string RepeatLabel(string message)
{
    return $"Echo: {message}";
}
