// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Create some new Rectangle objects with dimensions
Rectangle r1 = new Rectangle(10, 20);
Rectangle r2 = new Rectangle(15, 30);

Console.WriteLine( r1.getArea());
Console.WriteLine( r2.getArea());

r2.BorderSize = 5;
Console.WriteLine(r2.BorderSize);
r2.Height = -6;
r2.Width = 5;
Console.WriteLine(r2.getArea());
// TODO: Change the values of width and height
