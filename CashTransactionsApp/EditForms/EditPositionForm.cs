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
    public partial class editPositionForm : Form
    {
        public Position CurrentPosition { get; set; }
        public editPositionForm(Position position)
        {
            DataAccess db = new DataAccess();

            CurrentPosition = position;
            InitializeComponent();
            NameTextBox.Text = position.Name;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            CurrentPosition.Name = NameTextBox.Text;
            db.EditPosition(CurrentPosition);
            Close();
        }

        private void CnclButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
