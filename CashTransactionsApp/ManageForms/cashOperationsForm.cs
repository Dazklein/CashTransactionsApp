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

namespace CashTransactionsApp
{
    public partial class cashOperationsForm : Form
    {
        protected Employee CurrentEmployee { get; set; }
        protected List<PerformedServices> PerfServices { get; set; }
        public cashOperationsForm(Employee employee)
        {
            InitializeComponent();
            CurrentEmployee = employee;
            EmployeeFullNameLabel.Text = employee.FullName;
        }

        protected void UpdateDataGridView()
        {
            DataAccess db = new DataAccess();

            srvOprtnDataGridView.DataSource = db.GetPerformedServicesByEmployeeId(CurrentEmployee.EmployeeId);
            SalaryLabel.Text = '$' + db.ShowMonthSalaryByEmployeeId(CurrentEmployee.EmployeeId).ToString();
        }

        private void cashOperationsForm_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            UpdateDataGridView();

            srvOprtnDataGridView.Columns[0].HeaderText = "Service";
            srvOprtnDataGridView.Columns[1].HeaderText = "Cost";
            srvOprtnDataGridView.Columns[2].HeaderText = "Operation Data";

            SelectServiceComboBox.DataSource = db.GetServices();
            SelectServiceComboBox.DisplayMember = "Name";
            SelectServiceComboBox.ValueMember = "ServiceId";
        }

        private void cashOperationsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            Service service = (Service)SelectServiceComboBox.SelectedItem;
            for (int i = 0; i < Convert.ToInt32(CountTextBox.Text); i++)
            {
                db.CreateOperation(service.ServiceId, CurrentEmployee.EmployeeId);
            }
            UpdateDataGridView();
        }

        private void CountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }
    }
}
