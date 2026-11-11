List<string> messages = new List<string> { "SOS", "ACK" };
List<int> numbers = new List<int> { 4, 8 };
List<int> emptyList = new List<int> { };
SignalPrinter.PrintItems(messages);
SignalPrinter.PrintItems(numbers);
SignalPrinter.PrintItems(emptyList);
