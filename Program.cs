Console.Write("Enter the radius of the circle: ");
string inputRadius = Console.ReadLine();
double Pi=3.14;
double radius = Convert.ToDouble(inputRadius);
Console.WriteLine($"S = {Pi} x {radius}^2 = {Pi*Math.Pow(radius,2)}");
