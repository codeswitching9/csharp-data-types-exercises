// Numeric Types
Console.WriteLine("What is the length of your rectangle?");
string length = Console.ReadLine();
int rectangleLength = Int32.Parse(length);

Console.WriteLine("What is the width of your rectangle?");
string width = Console.ReadLine();
int rectangleWidth = Int32.Parse(width);

int area = rectangleLength * rectangleWidth;
Console.WriteLine("The area of the rectangle is: " + area);