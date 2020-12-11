using CashTransactionsApp.CreateForms;
using CashTransactionsApp.EditForms;
using CashTransactionsApp.Lib;
using CashTransactionsApp.ManageForms;
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
    public partial class DBManagementForm : Form
    {
        public object SelectedItemGrid { get; set; }
        public DBManagementForm()
        {
            DataAccess db = new DataAccess();

            InitializeComponent();
            SelectTableComboBox.DataSource = db.GetTables();
        }

        protected void UpdateGrid()
        {
            DataAccess db = new DataAccess();

            switch (SelectTableComboBox.Text)
            {
                case "Employee": EntryDataGridView.DataSource = db.GetEmployees(); break;
                case "Service": EntryDataGridView.DataSource = db.GetServices(); break;
                case "Position": EntryDataGridView.DataSource = db.GetPositions(); break;
            }
            SelectedTableLabel.Text = SelectTableComboBox.Text;

        }

        private void DBManagementForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void SelectTableComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void EmployeeSelectionButton_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private void DBManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            switch (SelectTableComboBox.Text)
            {
                case "Employee":
                    createEmployeeForm createEmployee = new createEmployeeForm();
                    createEmployee.Show();
                    break;
                case "Service":
                    createServiceForm createService = new createServiceForm();
                    createService.Show();
                    break;
                case "Position":
                    createPositionForm createPosition = new createPositionForm();
                    createPosition.Show();
                    break;
                default:
                    break;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = EntryDataGridView.SelectedRows[0];
            switch (SelectTableComboBox.Text)
            {
                case "Employee":
                    Employee employee = new Employee();
                    employee.EmployeeId = Convert.ToInt32(selectedRow.Cells["EmployeeId"].Value);
                    employee.Name = Convert.ToString(selectedRow.Cells["Name"].Value);
                    employee.Surname = Convert.ToString(selectedRow.Cells["Surname"].Value);
                    employee.PositionId = Convert.ToInt32(selectedRow.Cells["PositionId"].Value);
                    employee.Email = Convert.ToString(selectedRow.Cells["Email"].Value);
                    employee.Phone = Convert.ToString(selectedRow.Cells["Phone"].Value);
                    editEmployeeForm editEmployee = new editEmployeeForm(employee);
                    editEmployee.Show();
                    break;
                case "Service":
                    Service service = new Service();
                    service.ServiceId = Convert.ToInt32(selectedRow.Cells["ServiceId"].Value);
                    service.Name = Convert.ToString(selectedRow.Cells["Name"].Value);
                    service.Cost = Convert.ToDecimal(selectedRow.Cells["Cost"].Value);
                    editServiceForm editService = new editServiceForm(service);
                    editService.Show();
                    break;
                case "Position":
                    Position position = new Position();
                    position.PositionId = Convert.ToInt32(selectedRow.Cells["PositionId"].Value);
                    position.Name = Convert.ToString(selectedRow.Cells["Name"].Value);
                    editPositionForm editPosition = new editPositionForm(position);
                    editPosition.Show();
                    break;
                default:
                    break;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = EntryDataGridView.SelectedRows[0];
            switch (SelectTableComboBox.Text)
            {
                case "Employee":
                    
                    deleteEntryForm deleteEntry1 = new deleteEntryForm("Employee", Convert.ToInt32(selectedRow.Cells["EmployeeId"].Value), Convert.ToString(selectedRow.Cells["FullName"].Value));
                    deleteEntry1.Show();
                    break;
                case "Service":
                    deleteEntryForm deleteEntry2 = new deleteEntryForm("Service", Convert.ToInt32(selectedRow.Cells["ServiceId"].Value), Convert.ToString(selectedRow.Cells["Name"].Value));
                    deleteEntry2.Show();
                    break;
                case "Position":
                    deleteEntryForm deleteEntry3 = new deleteEntryForm("Position", Convert.ToInt32(selectedRow.Cells["PositionId"].Value), Convert.ToString(selectedRow.Cells["Name"].Value));
                    deleteEntry3.Show();
                    break;
                default:
                    break;
            }
        }

        private void DBManagementForm_Activated(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void ShowPerfomanceButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            EntryDataGridView.DataSource = db.ShowEmployeePerfomance();
            EntryDataGridView.Columns[0].HeaderText = "Full Name";
            EntryDataGridView.Columns[1].HeaderText = "Total earned";
        }

        private void ShowPplSrvButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            EntryDataGridView.DataSource = db.ShowMostPopularServices();
            EntryDataGridView.Columns[0].HeaderText = "Service name";
            EntryDataGridView.Columns[1].HeaderText = "Number of services performed";
        }
    }
}
