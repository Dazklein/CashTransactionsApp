using CashTransactionsApp.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashTransactionsApp.Lib
{
    public class DataAccess
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        #region Access to services
        public List<Service> GetServices()
        {
            List<Service> services = new List<Service>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                services = db.Query<Service>("SELECT * FROM [Service]").ToList();
            }
            return services;
        }

        public Service GetService(int id)
        {
            Service service = new Service();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                service = db.Query<Service>("SELECT * FROM [Service] WHERE ServiceId = @id", new { id }).FirstOrDefault();
            }
            return service;
        }

        public Service GetService(string name)
        {
            Service service = new Service();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                service = db.Query<Service>("SELECT * FROM [Service] WHERE Name = @name", new { name }).FirstOrDefault();
            }
            return service;
        }

        public Service CreateService(Service service)
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                int id = db.Query<int>("EXEC CreateService @Name, @Cost; SELECT CAST(SCOPE_IDENTITY() as Int)", service).FirstOrDefault();
                service.ServiceId = id;
            }
            return service;
        }

        public void EditService(Service service)
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EXEC EditService @Name, @Cost, @ServiceId", service);
            }
        }

        public void DeleteService(Service service)
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EXEC DeleteService @ServiceId", service.ServiceId);
            }
        }
        #endregion

        #region Access to positions
        public List<Position> GetPositions()
        {
            List<Position> positions = new List<Position>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                positions = db.Query<Position>("SELECT * FROM Position").ToList();
            }
            return positions;
        }

        public Position GetPosition(int id)
        {
            Position position = new Position();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                position = db.Query<Position>("SELECT * FROM [Position] WHERE PositionId = @id", new { id }).FirstOrDefault();
            }
            return position;
        }

        public Position GetPosition(string name)
        {
            Position position = new Position();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                position = db.Query<Position>("SELECT * FROM [Service] WHERE Name = @name", new { name }).FirstOrDefault();
            }
            return position;
        }

        public Position CreatePosition(Position position)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                int id = db.Query<int>("EXEC CreatePosition @Name; SELECT CAST(SCOPE_IDENTITY() as Int)", position).FirstOrDefault();
                position.PositionId = id;
            }
            return position;
        }

        public void EditPosition(Position position)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EXEC EditPosition @Name, @PositionId", position);
            }
        }

        public void DeletePosition(Position position)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EXEC DeletePosition @PositionId", position.PositionId);
            }
        }
        #endregion

        #region Access to Employee
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                employees = db.Query<Employee>("SELECT * FROM [Employee]").ToList();
            }
            return employees.ToList();
        }

        public Employee GetEmployee(int id)
        {
            Employee employee = new Employee();
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                employee = db.Query<Employee>("SELECT * FROM [Employee] WHERE EmployeeId = @id", new { id }).FirstOrDefault();
            }
            return employee;
        }

        public Employee GetEmployee(string surname)
        {
            Employee employee = new Employee();
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                employee = db.Query<Employee>("SELECT * FROM [Employee] WHERE Surname = @surname", new { surname }).FirstOrDefault();
            }
            return employee;
        }

        public Employee CreateEmployee(Employee employee)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                int id = db.Query<int>("EXEC CreateEmployee @Name, @Surname, @Phone, @Email, @PositionId", employee).FirstOrDefault();
                employee.EmployeeId = id;
            }
            return employee;
        }

        public void EditEmployee(Employee employee)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EXEC EditEmployee @Name, @Surname, @Phone, @Email, @PositionId, @EmployeeId", employee);
            }
        }

        public void DeleteEmployee(Employee employee)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EXEC DeleteEmployee @EmployeeId", employee.EmployeeId);
            }
        }
        #endregion

        #region Database operations manager
        
        #endregion
    }
}
