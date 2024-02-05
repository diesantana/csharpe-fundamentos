using AulaInterfaces2.Models.Enums;

namespace AulaInterfaces2.Models.Entities
{
    internal abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
