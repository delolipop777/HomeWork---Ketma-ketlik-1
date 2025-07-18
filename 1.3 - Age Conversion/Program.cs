Console.Write("Enter your birth year: ");

int year = int.Parse(Console.ReadLine()!);

int days = (2025-year) * 365;

Console.WriteLine($"You have been living for {days} days");