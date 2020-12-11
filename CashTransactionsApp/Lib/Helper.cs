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
            List<Service> result = new List<Service>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                result = db.Query<Service>("SELECT * FROM [Service]").ToList();
            }
            return result;
        }

        public Service GetService(int id)
        {
            Service result = new Service();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                result = db.Query<Service>("SELECT * FROM [Service] WHERE ServiceId = @id", new { id }).FirstOrDefault();
            }
            return result;
        }

        public Service GetService(string name)
        {
            Service result = new Service();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                result = db.Query<Service>("SELECT * FROM [Service] WHERE Name = @name", new { name }).FirstOrDefault();
            }
            return result;
        }

        public void CreateService(Service service)
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EXEC CreateService @Name, @Cost; SELECT CAST(SCOPE_IDENTITY() as Int)", service);
            }
        }

        public void EditService(Service service)
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EXEC EditService @Name, @Cost, @ServiceId", service);
            }
        }

        public void DeleteService(int serviceId)
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EXEC DeleteService @serviceId", new { serviceId });
            }
        }
        #endregion

        #region Access to positions
        public List<Position> GetPositions()
        {
            List<Position> result = new List<Position>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                result = db.Query<Position>("SELECT * FROM Position").ToList();
            }
            return result;
        }

        public Position GetPosition(int id)
        {
            Position result = new Position();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                result = db.Query<Position>("SELECT * FROM [Position] WHERE PositionId = @id", new { id }).FirstOrDefault();
            }
            return result;
        }

        public Position GetPosition(string name)
        {
            Position result = new Position();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                result = db.Query<Position>("SELECT * FROM [Service] WHERE Name = @name", new { name }).FirstOrDefault();
            }
            return result;
        }

        public void CreatePosition(Position position)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EXEC CreatePosition @Name; SELECT CAST(SCOPE_IDENTITY() as Int)", position);
            }
        }

        public void EditPosition(Position position)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EXEC EditPosition @Name, @PositionId", position);
            }
        }

        public void DeletePosition(int positionId)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EXEC DeletePosition @positionId", new { positionId });
            }
        }
        #endregion

        #region Access to Employee
        public List<Employee> GetEmployees()
        {
            List<Employee> result = new List<Employee>();
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                result = db.Query<Employee>("SELECT * FROM [Employee]").ToList();
            }
            return result;
        }

        public Employee GetEmployee(int id)
        {
            Employee result = new Employee();
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                result = db.Query<Employee>("SELECT * FROM [Employee] WHERE EmployeeId = @id", new { id }).FirstOrDefault();
            }
            return result;
        }

        public Employee GetEmployee(string surname)
        {
            Employee result = new Employee();
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                result = db.Query<Employee>("SELECT * FROM [Employee] WHERE Surname = @surname", new { surname }).FirstOrDefault();
            }
            return result;
        }

        public void CreateEmployee(Employee employee)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EXEC CreateEmployee @Name, @Surname, @Phone, @Email, @PositionId", employee);
            }
        }

        public void EditEmployee(Employee employee)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EXEC EditEmployee @Name, @Surname, @Phone, @Email, @PositionId, @EmployeeId", employee);
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EXEC DeleteEmployee @employeeId", new { employeeId });
            }
        }
        #endregion

        #region Database operations manager
        public List<PerformedServices> GetPerformedServicesByEmployeeId(int id)
        {
            List<PerformedServices> result = new List<PerformedServices>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                result = db.Query<PerformedServices>("EXEC GetPerformedServicesById @id", new { id }).ToList();
            }
            return result;
        }

        public void CreateOperation(int serviceId, int employeeId)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EXEC CreateOperation @serviceId, @employeeId;", new { serviceId, employeeId });
            }
        }

        public decimal ShowMonthSalaryByEmployeeId(int employeeId)
        {
            decimal result = 0;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                try
                {
                    result = db.Query<decimal>("EXEC ShowMonthSalaryByEmployeeId @employeeId", new { employeeId }).FirstOrDefault();
                }
                catch (Exception)
                {

                }
            }
            return result;
        }

        public List<string> GetTables()
        {
            List<string> result = new List<string>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                result = db.Query<string>("EXEC GetTables").ToList();
            }
            return result;
        }

        public List<EmployeePerfomance> ShowEmployeePerfomance()
        {
            List<EmployeePerfomance> result = new List<EmployeePerfomance>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                result = db.Query<EmployeePerfomance>("EXEC ShowEmployeePerfomance").ToList();
            }
            return result;
        }

        public List<MostPopularServices> ShowMostPopularServices()
        {
            List<MostPopularServices> result = new List<MostPopularServices>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                result = db.Query<MostPopularServices>("EXEC ShowMostPopularServices").ToList();
            }
            return result;
        }
        #endregion
    }
}
