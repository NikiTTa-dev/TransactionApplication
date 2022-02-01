using System;

namespace Classes
{
    public class User
    {
        public string Id { get; }
        public string FirstName { get; }
        public string SecondName { get; }
        public DateTime BirthDate { get; }
        public User(string id, string firstName, string secondName, DateTime birthDate)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.BirthDate = birthDate;
        }
        public User()
        {
            this.Id = null;
            this.FirstName = "";
            this.SecondName = "";
            this.BirthDate = new DateTime();
        }
    }

    public class Transaction
    {
        public string TransID { get; }
        public string UserID { get; }
        public double MoneyCount { get; }
        public DateTime TransTime { get; }
        public Transaction(string transID, string user, double moneyCount, DateTime TransTime)
        {
            this.TransID = transID;
            this.UserID = user;
            this.MoneyCount = moneyCount;
            this.TransTime = TransTime;
        }

        public Transaction()
        {
            this.TransID = null;
            this.UserID = null;
            this.MoneyCount = 0;
            this.TransTime = new DateTime();
        }
    }
}