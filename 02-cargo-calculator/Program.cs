
Console.WriteLine($"Remaining: {CalculateRemainingCapacity(12, 5)}");
Console.WriteLine($"Remaining: {CalculateRemainingCapacity(20, 8)}");
Console.WriteLine($"Remaining: {CalculateRemainingCapacity(5, 5)}");
Console.WriteLine($"Remaining: {CalculateRemainingCapacity(0, 0)}");

static int CalculateRemainingCapacity(int capacity, int usedCapacity)
{
    return capacity - usedCapacity;
}