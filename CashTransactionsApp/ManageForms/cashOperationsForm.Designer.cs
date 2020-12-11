namespace CashTransactionsApp
{
    partial class cashOperationsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SignOutButton = new System.Windows.Forms.Button();
            this.EmployeeFullNameLabel = new System.Windows.Forms.Label();
            this.SelectServiceComboBox = new System.Windows.Forms.ComboBox();
            this.AddServiceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.srvOprtnDataGridView = new System.Windows.Forms.DataGridView();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.srvOprtnDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SignOutButton
            // 
            this.SignOutButton.Location = new System.Drawing.Point(284, 5);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(93, 28);
            this.SignOutButton.TabIndex = 0;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // EmployeeFullNameLabel
            // 
            this.EmployeeFullNameLabel.AutoSize = true;
            this.EmployeeFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeFullNameLabel.Location = new System.Drawing.Point(12, 9);
            this.EmployeeFullNameLabel.Name = "EmployeeFullNameLabel";
            this.EmployeeFullNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmployeeFullNameLabel.Size = new System.Drawing.Size(170, 20);
            this.EmployeeFullNameLabel.TabIndex = 1;
            this.EmployeeFullNameLabel.Text = "..Employee Full Name..";
            this.EmployeeFullNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SelectServiceComboBox
            // 
            this.SelectServiceComboBox.FormattingEnabled = true;
            this.SelectServiceComboBox.Location = new System.Drawing.Point(16, 53);
            this.SelectServiceComboBox.Name = "SelectServiceComboBox";
            this.SelectServiceComboBox.Size = new System.Drawing.Size(217, 28);
            this.SelectServiceComboBox.TabIndex = 2;
            this.SelectServiceComboBox.Text = "Select service...";
            // 
            // AddServiceButton
            // 
            this.AddServiceButton.Location = new System.Drawing.Point(284, 53);
            this.AddServiceButton.Name = "AddServiceButton";
            this.AddServiceButton.Size = new System.Drawing.Size(93, 28);
            this.AddServiceButton.TabIndex = 3;
            this.AddServiceButton.Text = "Add";
            this.AddServiceButton.UseVisualStyleBackColor = true;
            this.AddServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your salary for the last month:";
            // 
            // srvOprtnDataGridView
            // 
            this.srvOprtnDataGridView.AllowUserToAddRows = false;
            this.srvOprtnDataGridView.AllowUserToDeleteRows = false;
            this.srvOprtnDataGridView.AllowUserToResizeColumns = false;
            this.srvOprtnDataGridView.AllowUserToResizeRows = false;
            this.srvOprtnDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.srvOprtnDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.srvOprtnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.srvOprtnDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.srvOprtnDataGridView.Location = new System.Drawing.Point(16, 117);
            this.srvOprtnDataGridView.Name = "srvOprtnDataGridView";
            this.srvOprtnDataGridView.RowHeadersVisible = false;
            this.srvOprtnDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.srvOprtnDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.srvOprtnDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srvOprtnDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.srvOprtnDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.srvOprtnDataGridView.Size = new System.Drawing.Size(361, 295);
            this.srvOprtnDataGridView.TabIndex = 5;
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SalaryLabel.Location = new System.Drawing.Point(276, 428);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(69, 20);
            this.SalaryLabel.TabIndex = 6;
            this.SalaryLabel.Text = "..Salary..";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Services you performed:";
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(239, 55);
            this.CountTextBox.MaxLength = 1000;
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(39, 26);
            this.CountTextBox.TabIndex = 8;
            this.CountTextBox.Text = "1";
            this.CountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(241, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Count";
            // 
            // cashOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 457);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.srvOprtnDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddServiceButton);
            this.Controls.Add(this.SelectServiceComboBox);
            this.Controls.Add(this.EmployeeFullNameLabel);
            this.Controls.Add(this.SignOutButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "cashOperationsForm";
            this.Text = "Cash Operations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cashOperationsForm_FormClosed);
            this.Load += new System.EventHandler(this.cashOperationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.srvOprtnDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.Label EmployeeFullNameLabel;
        private System.Windows.Forms.ComboBox SelectServiceComboBox;
        private System.Windows.Forms.Button AddServiceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView srvOprtnDataGridView;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Label label4;
    }
}