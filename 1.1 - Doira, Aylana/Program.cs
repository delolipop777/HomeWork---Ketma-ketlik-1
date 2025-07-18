Console.Write("Enter the radius of circle: ");
decimal radius = decimal.Parse(Console.ReadLine()!);
decimal area = radius * radius * 3.14m;
decimal circumference = radius * 2 * 3.14m;

System.Console.WriteLine($"Area: {area}\nCircumference: {circumference}");
System.Console.WriteLine("Thanks!");