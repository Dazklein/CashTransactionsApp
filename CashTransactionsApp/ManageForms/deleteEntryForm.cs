using CashTransactionsApp.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashTransactionsApp.ManageForms
{
    public partial class deleteEntryForm : Form
    {
        public string EntityTable { get; set; }
        public int EntityId { get; set; }
        public deleteEntryForm(string table, int entityId, string name)
        {
            InitializeComponent();
            EntityLabel.Text = name;
            EntityTable = table;
            EntityId = entityId;
        }

        private void CnclButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            switch (EntityTable)
            {
                case "Employee": 
                    db.DeleteEmployee(EntityId);
                    break;
                case "Service":
                    db.DeleteService(EntityId);
                    break;
                case "Position":
                    db.DeletePosition(EntityId);
                    break;
                default:
                    break;
            }
            Close();
        }
    }
}
