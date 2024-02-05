using AulaInterfaces2.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaInterfaces2.Models.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }
        public int MyProperty { get; set; }
        public abstract double Area();
    }
}
