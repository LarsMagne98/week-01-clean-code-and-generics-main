var textRecorder = new Recorder<string>();
var numberRecorder = new Recorder<int>();

textRecorder.Add("Orbit");

Console.WriteLine(textRecorder.Count);
Console.WriteLine(textRecorder.Contains("Orbit"));
Console.WriteLine(textRecorder.Contains("orbit"));

numberRecorder.Add(7);
numberRecorder.Add(7);

Console.WriteLine(numberRecorder.Count);
Console.WriteLine(numberRecorder.Contains(7));

numberRecorder.Clear();

Console.WriteLine(numberRecorder.Count);
Console.WriteLine(textRecorder.Count);