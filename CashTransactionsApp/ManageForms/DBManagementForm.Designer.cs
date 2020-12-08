namespace CashTransactionsApp
{
    partial class DBManagementForm
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
            this.EmployeeSelectionButton = new System.Windows.Forms.Button();
            this.SelectTableComboBox = new System.Windows.Forms.ComboBox();
            this.EntryDataGridView = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ShowPerfomanceButton = new System.Windows.Forms.Button();
            this.SelectedTableLabel = new System.Windows.Forms.Label();
            this.HighPrftEmplButton = new System.Windows.Forms.Button();
            this.ShowPplSrvButton = new System.Windows.Forms.Button();
            this.HighPrftSrvssButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EntryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeSelectionButton
            // 
            this.EmployeeSelectionButton.Location = new System.Drawing.Point(568, 5);
            this.EmployeeSelectionButton.Name = "EmployeeSelectionButton";
            this.EmployeeSelectionButton.Size = new System.Drawing.Size(217, 30);
            this.EmployeeSelectionButton.TabIndex = 0;
            this.EmployeeSelectionButton.Text = "Employee selection window";
            this.EmployeeSelectionButton.UseVisualStyleBackColor = true;
            // 
            // SelectTableComboBox
            // 
            this.SelectTableComboBox.FormattingEnabled = true;
            this.SelectTableComboBox.Location = new System.Drawing.Point(12, 12);
            this.SelectTableComboBox.Name = "SelectTableComboBox";
            this.SelectTableComboBox.Size = new System.Drawing.Size(168, 28);
            this.SelectTableComboBox.TabIndex = 2;
            this.SelectTableComboBox.Text = "Select a table..";
            // 
            // EntryDataGridView
            // 
            this.EntryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EntryDataGridView.Location = new System.Drawing.Point(12, 56);
            this.EntryDataGridView.Name = "EntryDataGridView";
            this.EntryDataGridView.Size = new System.Drawing.Size(638, 310);
            this.EntryDataGridView.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(656, 56);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(102, 29);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(656, 91);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(102, 29);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(656, 126);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(102, 29);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ShowPerfomanceButton
            // 
            this.ShowPerfomanceButton.Location = new System.Drawing.Point(656, 212);
            this.ShowPerfomanceButton.Name = "ShowPerfomanceButton";
            this.ShowPerfomanceButton.Size = new System.Drawing.Size(129, 74);
            this.ShowPerfomanceButton.TabIndex = 5;
            this.ShowPerfomanceButton.Text = "Show employee performance";
            this.ShowPerfomanceButton.UseVisualStyleBackColor = true;
            // 
            // SelectedTableLabel
            // 
            this.SelectedTableLabel.AutoSize = true;
            this.SelectedTableLabel.Location = new System.Drawing.Point(269, 15);
            this.SelectedTableLabel.Name = "SelectedTableLabel";
            this.SelectedTableLabel.Size = new System.Drawing.Size(131, 20);
            this.SelectedTableLabel.TabIndex = 6;
            this.SelectedTableLabel.Text = "..Selected Table..";
            // 
            // HighPrftEmplButton
            // 
            this.HighPrftEmplButton.Location = new System.Drawing.Point(13, 373);
            this.HighPrftEmplButton.Name = "HighPrftEmplButton";
            this.HighPrftEmplButton.Size = new System.Drawing.Size(151, 48);
            this.HighPrftEmplButton.TabIndex = 7;
            this.HighPrftEmplButton.Text = "Highest profit among employees";
            this.HighPrftEmplButton.UseVisualStyleBackColor = true;
            // 
            // ShowPplSrvButton
            // 
            this.ShowPplSrvButton.Location = new System.Drawing.Point(656, 292);
            this.ShowPplSrvButton.Name = "ShowPplSrvButton";
            this.ShowPplSrvButton.Size = new System.Drawing.Size(129, 74);
            this.ShowPplSrvButton.TabIndex = 5;
            this.ShowPplSrvButton.Text = "Most popular services";
            this.ShowPplSrvButton.UseVisualStyleBackColor = true;
            // 
            // HighPrftSrvssButton
            // 
            this.HighPrftSrvssButton.Location = new System.Drawing.Point(170, 373);
            this.HighPrftSrvssButton.Name = "HighPrftSrvssButton";
            this.HighPrftSrvssButton.Size = new System.Drawing.Size(151, 48);
            this.HighPrftSrvssButton.TabIndex = 7;
            this.HighPrftSrvssButton.Text = "Highest profit among services";
            this.HighPrftSrvssButton.UseVisualStyleBackColor = true;
            // 
            // DBManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 430);
            this.Controls.Add(this.HighPrftSrvssButton);
            this.Controls.Add(this.HighPrftEmplButton);
            this.Controls.Add(this.SelectedTableLabel);
            this.Controls.Add(this.ShowPplSrvButton);
            this.Controls.Add(this.ShowPerfomanceButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EntryDataGridView);
            this.Controls.Add(this.SelectTableComboBox);
            this.Controls.Add(this.EmployeeSelectionButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DBManagementForm";
            this.Text = "Database manager";
            ((System.ComponentModel.ISupportInitialize)(this.EntryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EmployeeSelectionButton;
        private System.Windows.Forms.ComboBox SelectTableComboBox;
        private System.Windows.Forms.DataGridView EntryDataGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ShowPerfomanceButton;
        private System.Windows.Forms.Label SelectedTableLabel;
        private System.Windows.Forms.Button HighPrftEmplButton;
        private System.Windows.Forms.Button ShowPplSrvButton;
        private System.Windows.Forms.Button HighPrftSrvssButton;
    }
}