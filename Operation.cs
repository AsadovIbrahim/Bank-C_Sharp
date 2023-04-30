using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.models
{
    public class Operation
    {
        private readonly Guid _Id;
        private readonly DateTime _datetime;
        private string _processName;

        public Guid Id { get { return _Id; } }
        public DateTime DateTime { get { return _datetime;} }
        public string ProcessName { get { return _processName; } set { _processName = value; } }

        public Operation() {
            _Id= Guid.NewGuid();
            _datetime= DateTime.Now;
        }
        public Operation(string processName):this()
        {
            ProcessName = processName;
        }

    
    }
}
