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
    public partial class createPositionForm : Form
    {
        public createPositionForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            Position position = new Position();
            position.Name = NameTextBox.Text;
            db.CreatePosition(position);
            Close();
        }

        private void CnclButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
