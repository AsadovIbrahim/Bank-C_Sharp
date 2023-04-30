using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.models
{
    public class Manager:Person
    {
        private string _managementExperience;

        public string ManagementExperience{ 
            get { return _managementExperience; }
            set{ _managementExperience = value;}
        }
        public Manager() : base() { }
        public Manager(string name, string surname, int age, string position, int salary, string managementExperience)
            : base(name, surname,position,age, salary)
        {
            ManagementExperience=managementExperience;
        }
    }
}
