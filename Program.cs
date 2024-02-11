Console.Write("Circle / Triangle: ");
string enter = Console.ReadLine();
switch(enter){
    case "Circle": 
        Console.Write("Enter the radius of the circle: ");
        string inputRadius = Console.ReadLine();
        double Pi=3.14;
        double radius = Convert.ToDouble(inputRadius);
        Console.WriteLine($"S = {Pi} x {radius}^2 = {Pi*Math.Pow(radius,2)}");
        break;
    case "Triangle":
        Console.Write("Enter side a of the triangle: ");
        string inputA = Console.ReadLine();
        Console.Write("Enter side b of the triangle: ");
        string inputB = Console.ReadLine();

        double sideA = Convert.ToDouble(inputA);
        double sideB = Convert.ToDouble(inputB);

        double height=Math.Sqrt(Math.Pow(sideB,2)-Math.Pow(sideA/2,2));
        Console.WriteLine($"S= 1/2 x {sideA} x {height} = {0.5*sideA*height}");
        break;
    default:
        Console.WriteLine("Invalid");
        break;
}


