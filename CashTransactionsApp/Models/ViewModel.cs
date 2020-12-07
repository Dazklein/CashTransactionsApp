using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashTransactionsApp.Models
{
    // Data models are presented here.
    public class Service
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
    }

    public class Position
    {
        public int PositionId { get; set; }
        public string Name { get; set; }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public int PositionId { get; set; }
        public string GetFullName
        {
            get
            {
                return Surname + ' ' + Name + ' ' + MiddleName;
            }
        }
    }

    public class Operation
    {
        public int OperationId { get; set; }
        public int ServiceId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OperationDate { get; set; }
    }
}
