using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Aggregation
{
    public class University
    {
        private string Name;
        private List<Professor> Professors;
        public University(string name)
        {
            this.Name = name;
            this.Professors = new List<Professor>();
        }
        public void AddProfessor(Professor professor)
        {
            Professors.Add(professor);
        }
        public void ShowProfessors()
        {
            Console.WriteLine($"Professors at {Name}:");
            foreach (var professor in Professors)
            {
                Console.WriteLine($"{professor.GetName()} teaches {professor.GetSubject()}");
            }
        }
    }
}
