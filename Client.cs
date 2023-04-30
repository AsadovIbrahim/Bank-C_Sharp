﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bank_System.models
{
    public class Client : Person
    {
        private string _liveAdress;
        private string _workAdress;

        // Properties

        public string LiveAdress { get { return _liveAdress; } set { _liveAdress = value; } }
        public string WorkAdress { get { return _workAdress; } set { _workAdress = value; } }

        // Constructors

        public Client() : base() { }
        public Client(string name, string surname, int age, string position,
            int salary, string liveAdress, string workAdress) :
            base(name, surname, position, age, salary)
        {
            LiveAdress = liveAdress;
            WorkAdress = workAdress;
        }

        // Functions

        public override string ToString()
        {
            string client = $"Name : {Name}\nSurname : {Surname}\nAge : {Age}\nPosition : {Position}\n" +
                $"Salary : {Salary}\nLive Adress : {LiveAdress}\nWork Adress : {WorkAdress}";
            return client;


        }
    }
}
