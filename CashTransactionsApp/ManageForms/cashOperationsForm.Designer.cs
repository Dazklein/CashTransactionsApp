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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your salary for the last month:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(276, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "..Salary..";
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
            // cashOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 322);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddServiceButton);
            this.Controls.Add(this.SelectServiceComboBox);
            this.Controls.Add(this.EmployeeFullNameLabel);
            this.Controls.Add(this.SignOutButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "cashOperationsForm";
            this.Text = "Cash Operations";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.Label EmployeeFullNameLabel;
        private System.Windows.Forms.ComboBox SelectServiceComboBox;
        private System.Windows.Forms.Button AddServiceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}