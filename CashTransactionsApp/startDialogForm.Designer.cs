namespace CashTransactionsApp
{
    partial class startDialogForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.OpenDBManagerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select an Employee...";
            // 
            // EmployeeComboBox
            // 
            this.EmployeeComboBox.FormattingEnabled = true;
            this.EmployeeComboBox.Location = new System.Drawing.Point(180, 6);
            this.EmployeeComboBox.Name = "EmployeeComboBox";
            this.EmployeeComboBox.Size = new System.Drawing.Size(180, 28);
            this.EmployeeComboBox.TabIndex = 1;
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(277, 40);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(83, 31);
            this.SignInButton.TabIndex = 2;
            this.SignInButton.Text = "Sign in";
            this.SignInButton.UseVisualStyleBackColor = true;
            // 
            // OpenDBManagerButton
            // 
            this.OpenDBManagerButton.Location = new System.Drawing.Point(16, 73);
            this.OpenDBManagerButton.Name = "OpenDBManagerButton";
            this.OpenDBManagerButton.Size = new System.Drawing.Size(116, 29);
            this.OpenDBManagerButton.TabIndex = 3;
            this.OpenDBManagerButton.Text = "DBManager";
            this.OpenDBManagerButton.UseVisualStyleBackColor = true;
            // 
            // startDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 114);
            this.Controls.Add(this.OpenDBManagerButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.EmployeeComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "startDialogForm";
            this.Text = "Employee selection...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.startDialogForm_FormClosed);
            this.Load += new System.EventHandler(this.startDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EmployeeComboBox;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button OpenDBManagerButton;
    }
}