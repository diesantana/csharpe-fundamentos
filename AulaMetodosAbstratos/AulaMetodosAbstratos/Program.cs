

using AulaMetodosAbstratos.Entities;
using AulaMetodosAbstratos.Entities.Enums;
using System.Globalization;

List<Shape> shapes = new List<Shape>();
Console.Write("Enter the number of shapes: ");
int nShapes = int.Parse(Console.ReadLine());

for (int i = 0; i < nShapes; i++)
{
    Console.WriteLine($"Shape #{i + 1} data:");
    Console.Write("Rectangle or circle (r/c)? ");
    char shapeType = char.Parse(Console.ReadLine().ToLower());
    Console.Write("Color (Black/Blue/Red): ");
    string sColor = Console.ReadLine();
    Color color = (Color)Enum.Parse(typeof(Color), sColor);

    if (shapeType == 'r')
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        shapes.Add(new Rectangle(width, height, color));
    }
    if (shapeType == 'c')
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        shapes.Add(new Circle(color, radius));
    }
}
Console.WriteLine();
Console.WriteLine("SHAPE AREAS:");

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
}