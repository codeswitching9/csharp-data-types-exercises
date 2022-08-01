// More on Numeric Types
Console.WriteLine("How many miles have you driven?");
string mi = Console.ReadLine();
int miles = Int32.Parse(mi);

Console.WriteLine("How much gas have you consumed (in gallons)?");
string gas = Console.ReadLine();
int gallons = Int32.Parse(gas);

int mpg = miles / gallons;
Console.WriteLine("The MPG for this trip was: " + mpg);