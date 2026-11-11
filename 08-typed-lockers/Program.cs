
Console.WriteLine("Typed Lockers");

var text = new Locker<string>("Beacon");
var number = new Locker<int>(42);
Console.WriteLine(text.Read());
Console.WriteLine(number.Read());

text.Replace("Relay");
number.Replace(99);
Console.WriteLine(text.Read());
Console.WriteLine(number.Read());

// text.Replace(51);
