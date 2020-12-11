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
    public partial class editServiceForm : Form
    {
        public Service CurrentService { get; set; }
        public editServiceForm(Service service)
        {
            DataAccess db = new DataAccess();

            CurrentService = service;
            InitializeComponent();
            NameTextBox.Text = service.Name;
            CostTextBox.Text = service.Cost.ToString();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            CurrentService.Name = NameTextBox.Text;
            CurrentService.Cost = Convert.ToDecimal(CostTextBox.Text);
            db.EditService(CurrentService);
            Close();
        }

        private void CnclButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
