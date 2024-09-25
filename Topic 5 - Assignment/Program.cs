// See https://aka.ms/new-console-template for more information
// Carsen
Console.WriteLine("Part 1 - Space Boxing");
Console.WriteLine();

int planet;
double weight, venus, mars, jupiter, saturn, uranus, neptune;
venus = 0.78;
mars = 0.39;
jupiter = 2.65;
saturn = 1.17;
uranus = 1.05;
neptune = 1.23;

Console.WriteLine("Please enter your current Earth weight:");
Double.TryParse(Console.ReadLine(), out weight);
Console.WriteLine();
Console.WriteLine("I have information for the following planets:");
Console.WriteLine("1. Venus   2. Mars    3. Jupiter");
Console.WriteLine("4. Saturn  5. Uranus  6. Neptune");
Console.WriteLine();
Console.WriteLine("Which planet are you visiting?");
Int32.TryParse(Console.ReadLine(), out planet);

if (planet == 1)
    Console.WriteLine("Your weight on that planet is " + (weight * venus) + " pounds.");
else if (planet == 2)
    Console.WriteLine("Your weight on that planet is " + (weight * mars) + " pounds.");
else if (planet == 3)
    Console.WriteLine("Your weight on that planet is " + (weight * jupiter) + " pounds.");
else if (planet == 4)
    Console.WriteLine("Your weight on that planet is " + (weight * saturn) + " pounds.");
else if (planet == 5)
    Console.WriteLine("Your weight on that planet is " + (weight * uranus) + " pounds.");
else if (planet == 6)
    Console.WriteLine("Your weight on that planet is " + (weight * neptune) + " pounds.");
else
    Console.WriteLine("Sorry, that isn't a valid number/input.");