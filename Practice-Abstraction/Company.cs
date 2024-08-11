using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Abstraction
{
    // Abstract base class representing a company employee
    public abstract class Company
    {
        // Common properties for all employees
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

        // Abstract method that must be implemented by derived classes
        public abstract void Mission(); 
    }

    // Derived class for Software Developers
    public class SoftwareDeveloper : Company
    {
        // Implementation of the abstract method for Software Developer role
        public override void Mission()
        {
            Console.WriteLine("I am working as a Software Developer.");
        }
    }

    // Derived class for Project Managers
    public class ProjectManager : Company
    {
        // Implementation of the abstract method for Project Manager role
        public override void Mission()
        {
            Console.WriteLine("I am working as a Project Manager.");
        }
    }

    // Derived class for Sales Managers
    public class SalesManager : Company
    {
        // Implementation of the abstract method for Sales Manager role
        public override void Mission()
        {
            Console.WriteLine("I am working as a Sales Manager.");
        }
    }
}
