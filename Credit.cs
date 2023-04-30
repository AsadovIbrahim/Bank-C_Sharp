using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.models
{
    public class Credit
    {
        private readonly Guid _Id;
        private Client _client;
        private float _amount;
        private float _percent;
        private int _months;

        public Guid Id { get { return _Id; } }
        public Client Client { get { return _client;} set { _client = value; } }
        public float Amount { get { return _amount; }
            set
            {
                try
                {
                    if (_amount < 0) throw new Exception("Invalid Amount!");
                    _amount = value;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } 
        }
        public float Percent { get { return _percent; }set { _percent = value; } }
        public int Months { get { return _months; }set { _months = value; } }

        public Credit()
        {
            _Id = Guid.NewGuid();
        }
        public Credit(Client client, float amount,float percent,int months)
        {
            Client=client;
            Amount=amount;
            Percent=percent;
        }

        public override string ToString()
        {
            string credit = $"Client\n\n{Client}\nAmount : {Amount}\nPercent : {Percent}\nMonths : {Months}";
            return credit;
        }
        public float CalculatePercent()
        {
            return Amount + (Amount * (Percent / 100f));
        }
        public void payment(int money)
        {
            if (_months > 0)
            {
                _months--;
                Amount = CalculatePercent();
                Amount -= money;
            }
        }
    }
}
