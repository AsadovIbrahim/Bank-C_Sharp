using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.models
{
    public class Worker : Person
    {
        private string _StartTime;
        private string _EndTime;
        private List<Operation> _operations = new();

        public List<Operation> Operations
        {
            get { return _operations; }
            set { _operations = value; }
        }
        public string StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }
        public string EndTime
        {
            get { return _EndTime; }
            set { _EndTime = value; }
        }
        public Worker() : base() { }
        public Worker(string name,string surname,int age,string position,int salary,string startTime,string endTime):
            base(name, surname, position, age, salary)
        {
            _StartTime = startTime;
            _EndTime = endTime;
        }
        public void AddOperations(Operation operation)
        {
            _operations.Add(operation);
        }
    }
}
