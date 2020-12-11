using CashTransactionsApp.Lib;
using CashTransactionsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashTransactionsApp.EditForms
{
    public partial class editEmployeeForm : Form
    {
        public Employee CurrentEmployee { get; set; }
        public editEmployeeForm(Employee employee)
        {
            DataAccess db = new DataAccess();

            InitializeComponent();
            CurrentEmployee = employee;
            NameTextBox.Text = employee.Name;
            SurnameTextBox.Text = employee.Surname;
            PhoneTextBox.Text = employee.Phone;
            EmailTextBox.Text = employee.Email;

            PositionComboBox.DataSource = db.GetPositions();
            PositionComboBox.DisplayMember = "Name";
            PositionComboBox.ValueMember = "PositionId";
            PositionComboBox.SelectedIndex = employee.PositionId - 1;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Employee employee = new Employee();

            CurrentEmployee.Name = NameTextBox.Text;
            CurrentEmployee.Surname = SurnameTextBox.Text;
            CurrentEmployee.Phone = PhoneTextBox.Text;
            CurrentEmployee.Email = EmailTextBox.Text;
            CurrentEmployee.PositionId = PositionComboBox.SelectedIndex + 1;



            db.EditEmployee(CurrentEmployee);
            Close();
        }

        private void CnclButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
