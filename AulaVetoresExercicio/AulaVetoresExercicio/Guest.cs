using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaVetoresExercicio
{
    internal class Guest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public Guest() { }
        public Guest(string name, string email, int quarto)
        {
            Name = name;
            this.Email = email;
            Room = quarto;
        }

        public override string ToString()
        {
            return Room + ": " + Name + ", " + Email; 
        }
    }
}
