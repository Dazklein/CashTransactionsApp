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
    public partial class createServiceForm : Form
    {
        public createServiceForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            Service service = new Service();
            service.Name = NameTextBox.Text;
            service.Cost = Convert.ToDecimal(CostTextBox.Text);
            db.CreateService(service);
            Close();
        }

        private void CnclButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
