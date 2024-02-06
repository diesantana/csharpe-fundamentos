using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // dois critérios de comparação
            int result =  Name.CompareTo(other.Name);
            if(result == 0)
            {
                result = Salary.CompareTo(other.Salary);
            }

            return result;
            // return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
