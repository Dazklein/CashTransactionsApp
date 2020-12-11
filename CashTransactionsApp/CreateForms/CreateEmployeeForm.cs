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

namespace CashTransactionsApp.CreateForms
{
    public partial class createEmployeeForm : Form
    {
        public createEmployeeForm()
        {
            DataAccess db = new DataAccess();

            InitializeComponent();
            PositionComboBox.DataSource = db.GetPositions();
            PositionComboBox.DisplayMember = "Name";
            PositionComboBox.ValueMember = "PositionId";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            Employee employee = new Employee();
            employee.Name = NameTextBox.Text;
            employee.Surname = NameTextBox.Text;
            employee.Phone = PhoneTextBox.Text;
            employee.Email = EmailTextBox.Text;
            employee.PositionId = PositionComboBox.SelectedIndex + 1;
            db.CreateEmployee(employee);
            Close();
        }

        private void CnclButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
