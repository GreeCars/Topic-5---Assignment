// See https://aka.ms/new-console-template for more information
// Carsen
Console.WriteLine("Part 1");

double weight, venus, mars, jupiter, saturn, uranus, neptune;
venus = 0.78;
mars = 0.39;
jupiter = 2.65;
saturn = 1.17;
uranus = 1.05;
neptune = 1.23;

Console.WriteLine("Please enter your current Earth weight:");
Double.TryParse(Console.ReadLine(), out weight);
Console.WriteLine("I have information for the following planets:");
Console.WriteLine("1. Venus   2. Mars    3. Jupiter");
Console.WriteLine("4. Saturn  5. Uranus  6. Neptune");
Console.WriteLine("Which planet are you visiting?");