using System.Globalization;

namespace AulaInterfaceComparable.Entities
{
    internal class Employee : IComparable<Employee>
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] line = csvEmployee.Split(',');
            Name = line[0];
            Salary = double.Parse(line[1], CultureInfo.InvariantCulture);
        }

        public int CompareTo(Employee? other)
        {
            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
