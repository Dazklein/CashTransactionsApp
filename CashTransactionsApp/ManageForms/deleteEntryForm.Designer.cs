namespace CashTransactionsApp.ManageForms
{
    partial class deleteEntryForm
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
            this.EntityLabel = new System.Windows.Forms.Label();
            this.CnclButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to delete this entity?";
            // 
            // EntityLabel
            // 
            this.EntityLabel.AutoSize = true;
            this.EntityLabel.ForeColor = System.Drawing.Color.Red;
            this.EntityLabel.Location = new System.Drawing.Point(130, 45);
            this.EntityLabel.Name = "EntityLabel";
            this.EntityLabel.Size = new System.Drawing.Size(65, 20);
            this.EntityLabel.TabIndex = 1;
            this.EntityLabel.Text = "..Entity..";
            this.EntityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CnclButton
            // 
            this.CnclButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CnclButton.Location = new System.Drawing.Point(35, 81);
            this.CnclButton.Name = "CnclButton";
            this.CnclButton.Size = new System.Drawing.Size(75, 30);
            this.CnclButton.TabIndex = 2;
            this.CnclButton.Text = "Cancel";
            this.CnclButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DeleteButton.Location = new System.Drawing.Point(224, 81);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 30);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // deleteEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 123);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CnclButton);
            this.Controls.Add(this.EntityLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "deleteEntryForm";
            this.Text = "Deleting entity...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EntityLabel;
        private System.Windows.Forms.Button CnclButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}