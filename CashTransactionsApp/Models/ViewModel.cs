using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashTransactionsApp.Models;

namespace CashTransactionsApp.Models
{
    // Data models are presented here.
    public class Service
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
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
        public int PositionId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string FullName
        {
            get
            {
                return Name + ' ' + Surname;
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

    public class PerformedServices
    {
        public string ServiceName { get; set; }
        public decimal ServiceCost { get; set; }
        public DateTime OperationDate { get; set; }
    }

    public class EmployeePerfomance
    {
        public string EmployeeFullName { get; set; }
        public decimal TotalEarned { get; set; }
    }

    public class MostPopularServices
    {
        public string ServiceName { get; set; }
        public int CountServices { get; set; }
    }
}
