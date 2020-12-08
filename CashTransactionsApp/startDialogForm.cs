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
            foreach (var item in db.GetEmployees())
            {
                EmployeeComboBox.Items.Add(item);
            }
            
        }

        private void startDialogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
