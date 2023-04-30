using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.models
{
    public class CEO:Person
    {
        private string _company;
        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        public CEO() : base() { }
        public CEO(string name,string surname,int age,string position,int salary,string company):
            base(name, surname, position,age, salary)
        {
            Company = company;
        }

    }
}
