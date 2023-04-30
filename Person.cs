using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.models
{
    public class Person
    {
        private readonly Guid _Id;
        private string _Name;
        private string _Surname;
        private string _Position;
        private int _Age;
        private int _Salary; 
    
        public Guid Id { get { return _Id; } }
        public string Name
        {
            get { return _Name; }

            set
            {
                try
                {
                    if (value.Length >= 3) _Name = value;
                    else throw new Exception("Invalid Name");
                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }
            }
        }
        public string Surname {get { return _Surname; } set { _Surname= value; } }
        public string Position { get { return _Position; } set { _Position= value; } }
        public int Age { get { return _Age; }
            set
            {
                try
                {
                    if (value < 0 || value > 100) throw new Exception("Your Age Is Not Valid!");
                    _Age = value;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }
            }
        }
        public int Salary
        {
            get { return _Salary; }
            set
            {
                try
                {
                    if (value < 0) throw new Exception("Invalid Salary!");
                    _Salary = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }
            }
        }

        public Person() { _Id = Guid.NewGuid(); }
        public Person(string name,string surname,string position,int age,int salary) :this(){
            Name = name; 
            Surname = surname;
            Position = position;
            Age = age;
            Salary = salary;
        }

    }
}
