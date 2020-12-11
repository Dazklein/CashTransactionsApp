using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashTransactionsApp.Lib;
using CashTransactionsApp.Models;

namespace CashTransactionsApp
{
    public partial class startDialogForm : Form
    {
        public startDialogForm()
        {
            InitializeComponent();
        }

        private void startDialogForm_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            EmployeeComboBox.DataSource = db.GetEmployees();
            EmployeeComboBox.DisplayMember = "FullName";
            EmployeeComboBox.ValueMember = "EmployeeId";
        }

        private void startDialogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (EmployeeComboBox.SelectedItem != null)
            {
                cashOperationsForm cashOperationsForm = new cashOperationsForm((Employee)EmployeeComboBox.SelectedItem);
                cashOperationsForm.Owner = this;
                cashOperationsForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Select an employee");
            }
            
        }

        private void OpenDBManagerButton_Click(object sender, EventArgs e)
        {
            DBManagementForm dBManagementForm = new DBManagementForm();
            dBManagementForm.Owner = this;
            dBManagementForm.Show();
            Hide();
        }
    }
}
