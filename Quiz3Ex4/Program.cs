// 4. ექმენით ინტერფეისი IShape რომელსაც ექნება ფართობის და პერიმეტრის გამოთვლის მეთოდები.
//  ექმენით პრიზმის, სამკუთხედის , მართკუთხედის, და ტრაპეციის კლასები.
// ელები დაამატეთ საჭიროებისამებრ. ააკეთეთ თითოეულ კლასში IShape-ის იმპლემენტაცია.

using Quiz3Ex4.Interfaces.Shape;


Rectangle rectangle = new()
{
    Side1 = 5,
    Side2 = 7
};

Console.WriteLine(rectangle.GetArea());
Console.WriteLine(rectangle.GetPerimeter());

Trapezium trapezium = new()
{
    Base1 = 6,
    Base2 = 12,
    Leg = 7,
    Height = 6
};

Console.WriteLine(trapezium.GetArea());
Console.WriteLine(trapezium.GetPerimeter());

Triangle triangle = new()
{
    Side1 = 7,
    Side2 = 7,
    Base = 7,
    Height = 5
};

Console.WriteLine(triangle.GetArea());
Console.WriteLine(triangle.GetPerimeter());

Prism prism = new()
{
    SurfaceArea = 8,
    BaseArea = 16
};

Console.WriteLine(prism.GetArea());
Console.WriteLine(prism.GetPerimeter());

