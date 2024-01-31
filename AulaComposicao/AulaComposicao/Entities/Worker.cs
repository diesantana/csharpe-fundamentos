using AulaComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaComposicao.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        // composição
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();
        public Department Department { get; set; }

        // construtores
        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            this.Department = department;
        }


        // métodos 
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = 0.0;
            // Lista de contratos dados o mês e o ano
            List<HourContract> hourContracts = Contracts.FindAll(x => x.Date.Month == month && x.Date.Year == year);
            foreach (HourContract hourContract in hourContracts)
            {
                sum += hourContract.TotalValue();
            }
            return sum + BaseSalary;
        }
    }
}
