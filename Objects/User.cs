using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Objects
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int UserID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public int? CurrentOrder { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsManager { get; set; }

        public User() { }
        public User(string firstName, string lastName, string password,
             int currentOrder, DateTime creationDate, bool isManager)
        {
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            CurrentOrder = currentOrder;
            CreationDate = creationDate;
            IsManager = isManager;
        }
    }
}
