


using AulaInterfaces2.Models.Entities;
using AulaInterfaces2.Models.Enums;

IShape shape1 = new Circle
{
    Color = Color.White,
    Radius = 3,
};

IShape shape2 = new Rectangle
{
    Color = Color.Black,
    Width = 5,
    Height = 3,
};

Console.WriteLine(shape1);
Console.WriteLine(shape2);