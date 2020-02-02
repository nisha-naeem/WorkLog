namespace Demo.Views
{
    partial class HistoryView
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
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.ErrorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Analyser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxIssueHistory = new System.Windows.Forms.GroupBox();
            this.groupBoxSearchIssue = new System.Windows.Forms.GroupBox();
            this.buttonGetDemoData = new System.Windows.Forms.Button();
            this.checkBoxSearchResolved = new System.Windows.Forms.CheckBox();
            this.comboBoxSearchCustomer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxAnalyserSearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIssueSearchDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearchErrorCode = new System.Windows.Forms.TextBox();
            this.groupBoxErrorandTroubleshooting = new System.Windows.Forms.GroupBox();
            this.dataGridViewErrorData = new System.Windows.Forms.DataGridView();
            this.dataGridViewResolvingSteps = new System.Windows.Forms.DataGridView();
            this.groupBoxSelectedIssueDetails = new System.Windows.Forms.GroupBox();
            this.textBoxIssueDescription = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxIssueDetails = new System.Windows.Forms.GroupBox();
            this.labelIssueStatus = new System.Windows.Forms.Label();
            this.labelSerial = new System.Windows.Forms.Label();
            this.labelAnalyser = new System.Windows.Forms.Label();
            this.labelIssueDate = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.groupBoxIssueHistory.SuspendLayout();
            this.groupBoxSearchIssue.SuspendLayout();
            this.groupBoxErrorandTroubleshooting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErrorData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResolvingSteps)).BeginInit();
            this.groupBoxSelectedIssueDetails.SuspendLayout();
            this.groupBoxIssueDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.AllowUserToDeleteRows = false;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ErrorCode,
            this.Analyser,
            this.Customer});
            this.dataGridViewHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHistory.Location = new System.Drawing.Point(4, 18);
            this.dataGridViewHistory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistory.Size = new System.Drawing.Size(309, 287);
            this.dataGridViewHistory.TabIndex = 0;
            this.dataGridViewHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistory_CellClick);
            // 
            // ErrorCode
            // 
            this.ErrorCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ErrorCode.DataPropertyName = "ErrorCode";
            this.ErrorCode.HeaderText = "Error Code";
            this.ErrorCode.Name = "ErrorCode";
            this.ErrorCode.ReadOnly = true;
            this.ErrorCode.Width = 89;
            // 
            // Analyser
            // 
            this.Analyser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Analyser.DataPropertyName = "Analyser";
            this.Analyser.HeaderText = "Analyser";
            this.Analyser.Name = "Analyser";
            this.Analyser.ReadOnly = true;
            this.Analyser.Width = 77;
            // 
            // Customer
            // 
            this.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Customer.DataPropertyName = "CustomerName";
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.Width = 82;
            // 
            // groupBoxIssueHistory
            // 
            this.groupBoxIssueHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxIssueHistory.Controls.Add(this.dataGridViewHistory);
            this.groupBoxIssueHistory.Location = new System.Drawing.Point(0, 77);
            this.groupBoxIssueHistory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxIssueHistory.Name = "groupBoxIssueHistory";
            this.groupBoxIssueHistory.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxIssueHistory.Size = new System.Drawing.Size(317, 308);
            this.groupBoxIssueHistory.TabIndex = 2;
            this.groupBoxIssueHistory.TabStop = false;
            this.groupBoxIssueHistory.Text = "Issue History";
            // 
            // groupBoxSearchIssue
            // 
            this.groupBoxSearchIssue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchIssue.Controls.Add(this.buttonSearch);
            this.groupBoxSearchIssue.Controls.Add(this.buttonGetDemoData);
            this.groupBoxSearchIssue.Controls.Add(this.checkBoxSearchResolved);
            this.groupBoxSearchIssue.Controls.Add(this.comboBoxSearchCustomer);
            this.groupBoxSearchIssue.Controls.Add(this.label5);
            this.groupBoxSearchIssue.Controls.Add(this.comboBoxAnalyserSearch);
            this.groupBoxSearchIssue.Controls.Add(this.label4);
            this.groupBoxSearchIssue.Controls.Add(this.label3);
            this.groupBoxSearchIssue.Controls.Add(this.textBoxIssueSearchDescription);
            this.groupBoxSearchIssue.Controls.Add(this.label2);
            this.groupBoxSearchIssue.Controls.Add(this.textBoxSearchErrorCode);
            this.groupBoxSearchIssue.Location = new System.Drawing.Point(0, 385);
            this.groupBoxSearchIssue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchIssue.Name = "groupBoxSearchIssue";
            this.groupBoxSearchIssue.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchIssue.Size = new System.Drawing.Size(934, 70);
            this.groupBoxSearchIssue.TabIndex = 3;
            this.groupBoxSearchIssue.TabStop = false;
            this.groupBoxSearchIssue.Text = "Search Issues";
            // 
            // buttonGetDemoData
            // 
            this.buttonGetDemoData.Location = new System.Drawing.Point(663, 14);
            this.buttonGetDemoData.Name = "buttonGetDemoData";
            this.buttonGetDemoData.Size = new System.Drawing.Size(99, 23);
            this.buttonGetDemoData.TabIndex = 10;
            this.buttonGetDemoData.Text = "Get Demo Data";
            this.buttonGetDemoData.UseVisualStyleBackColor = true;
            this.buttonGetDemoData.Click += new System.EventHandler(this.buttonGetDemoData_Click);
            // 
            // checkBoxSearchResolved
            // 
            this.checkBoxSearchResolved.AutoSize = true;
            this.checkBoxSearchResolved.Location = new System.Drawing.Point(481, 47);
            this.checkBoxSearchResolved.Name = "checkBoxSearchResolved";
            this.checkBoxSearchResolved.Size = new System.Drawing.Size(72, 18);
            this.checkBoxSearchResolved.TabIndex = 9;
            this.checkBoxSearchResolved.Text = "Resolved";
            this.checkBoxSearchResolved.UseVisualStyleBackColor = true;
            // 
            // comboBoxSearchCustomer
            // 
            this.comboBoxSearchCustomer.FormattingEnabled = true;
            this.comboBoxSearchCustomer.Location = new System.Drawing.Point(481, 15);
            this.comboBoxSearchCustomer.Name = "comboBoxSearchCustomer";
            this.comboBoxSearchCustomer.Size = new System.Drawing.Size(121, 22);
            this.comboBoxSearchCustomer.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "Customer";
            // 
            // comboBoxAnalyserSearch
            // 
            this.comboBoxAnalyserSearch.FormattingEnabled = true;
            this.comboBoxAnalyserSearch.Location = new System.Drawing.Point(274, 15);
            this.comboBoxAnalyserSearch.Name = "comboBoxAnalyserSearch";
            this.comboBoxAnalyserSearch.Size = new System.Drawing.Size(121, 22);
            this.comboBoxAnalyserSearch.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Analayser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Issue Desc.";
            // 
            // textBoxIssueSearchDescription
            // 
            this.textBoxIssueSearchDescription.Location = new System.Drawing.Point(82, 43);
            this.textBoxIssueSearchDescription.Name = "textBoxIssueSearchDescription";
            this.textBoxIssueSearchDescription.Size = new System.Drawing.Size(313, 22);
            this.textBoxIssueSearchDescription.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Error Code";
            // 
            // textBoxSearchErrorCode
            // 
            this.textBoxSearchErrorCode.Location = new System.Drawing.Point(82, 15);
            this.textBoxSearchErrorCode.Name = "textBoxSearchErrorCode";
            this.textBoxSearchErrorCode.Size = new System.Drawing.Size(106, 22);
            this.textBoxSearchErrorCode.TabIndex = 0;
            // 
            // groupBoxErrorandTroubleshooting
            // 
            this.groupBoxErrorandTroubleshooting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxErrorandTroubleshooting.Controls.Add(this.dataGridViewErrorData);
            this.groupBoxErrorandTroubleshooting.Controls.Add(this.dataGridViewResolvingSteps);
            this.groupBoxErrorandTroubleshooting.Location = new System.Drawing.Point(325, 77);
            this.groupBoxErrorandTroubleshooting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxErrorandTroubleshooting.Name = "groupBoxErrorandTroubleshooting";
            this.groupBoxErrorandTroubleshooting.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxErrorandTroubleshooting.Size = new System.Drawing.Size(602, 305);
            this.groupBoxErrorandTroubleshooting.TabIndex = 4;
            this.groupBoxErrorandTroubleshooting.TabStop = false;
            this.groupBoxErrorandTroubleshooting.Text = "Error Description and Troubleshooting Details";
            // 
            // dataGridViewErrorData
            // 
            this.dataGridViewErrorData.AllowUserToAddRows = false;
            this.dataGridViewErrorData.AllowUserToDeleteRows = false;
            this.dataGridViewErrorData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewErrorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewErrorData.Location = new System.Drawing.Point(8, 18);
            this.dataGridViewErrorData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewErrorData.Name = "dataGridViewErrorData";
            this.dataGridViewErrorData.ReadOnly = true;
            this.dataGridViewErrorData.Size = new System.Drawing.Size(587, 126);
            this.dataGridViewErrorData.TabIndex = 3;
            // 
            // dataGridViewResolvingSteps
            // 
            this.dataGridViewResolvingSteps.AllowUserToAddRows = false;
            this.dataGridViewResolvingSteps.AllowUserToDeleteRows = false;
            this.dataGridViewResolvingSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResolvingSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResolvingSteps.Location = new System.Drawing.Point(7, 150);
            this.dataGridViewResolvingSteps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewResolvingSteps.Name = "dataGridViewResolvingSteps";
            this.dataGridViewResolvingSteps.ReadOnly = true;
            this.dataGridViewResolvingSteps.Size = new System.Drawing.Size(587, 155);
            this.dataGridViewResolvingSteps.TabIndex = 2;
            // 
            // groupBoxSelectedIssueDetails
            // 
            this.groupBoxSelectedIssueDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSelectedIssueDetails.Controls.Add(this.textBoxIssueDescription);
            this.groupBoxSelectedIssueDetails.Location = new System.Drawing.Point(4, 3);
            this.groupBoxSelectedIssueDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSelectedIssueDetails.Name = "groupBoxSelectedIssueDetails";
            this.groupBoxSelectedIssueDetails.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSelectedIssueDetails.Size = new System.Drawing.Size(428, 68);
            this.groupBoxSelectedIssueDetails.TabIndex = 4;
            this.groupBoxSelectedIssueDetails.TabStop = false;
            this.groupBoxSelectedIssueDetails.Tag = "Issue #";
            this.groupBoxSelectedIssueDetails.Text = "Issue # 56759";
            // 
            // textBoxIssueDescription
            // 
            this.textBoxIssueDescription.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxIssueDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIssueDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIssueDescription.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIssueDescription.Location = new System.Drawing.Point(4, 18);
            this.textBoxIssueDescription.Multiline = true;
            this.textBoxIssueDescription.Name = "textBoxIssueDescription";
            this.textBoxIssueDescription.Size = new System.Drawing.Size(420, 47);
            this.textBoxIssueDescription.TabIndex = 3;
            this.textBoxIssueDescription.Text = "werguwerg";
            // 
            // groupBoxIssueDetails
            // 
            this.groupBoxIssueDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIssueDetails.Controls.Add(this.labelIssueStatus);
            this.groupBoxIssueDetails.Controls.Add(this.labelSerial);
            this.groupBoxIssueDetails.Controls.Add(this.labelAnalyser);
            this.groupBoxIssueDetails.Controls.Add(this.labelIssueDate);
            this.groupBoxIssueDetails.Controls.Add(this.labelCustomerName);
            this.groupBoxIssueDetails.Location = new System.Drawing.Point(434, 3);
            this.groupBoxIssueDetails.Name = "groupBoxIssueDetails";
            this.groupBoxIssueDetails.Size = new System.Drawing.Size(500, 68);
            this.groupBoxIssueDetails.TabIndex = 5;
            this.groupBoxIssueDetails.TabStop = false;
            // 
            // labelIssueStatus
            // 
            this.labelIssueStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIssueStatus.AutoSize = true;
            this.labelIssueStatus.BackColor = System.Drawing.Color.LightGreen;
            this.labelIssueStatus.Location = new System.Drawing.Point(8, 18);
            this.labelIssueStatus.Name = "labelIssueStatus";
            this.labelIssueStatus.Size = new System.Drawing.Size(53, 14);
            this.labelIssueStatus.TabIndex = 11;
            this.labelIssueStatus.Tag = "";
            this.labelIssueStatus.Text = "Resolved";
            // 
            // labelSerial
            // 
            this.labelSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSerial.AutoSize = true;
            this.labelSerial.Location = new System.Drawing.Point(196, 46);
            this.labelSerial.Name = "labelSerial";
            this.labelSerial.Size = new System.Drawing.Size(36, 14);
            this.labelSerial.TabIndex = 10;
            this.labelSerial.Tag = "";
            this.labelSerial.Text = "Serial";
            // 
            // labelAnalyser
            // 
            this.labelAnalyser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAnalyser.AutoSize = true;
            this.labelAnalyser.Location = new System.Drawing.Point(196, 32);
            this.labelAnalyser.Name = "labelAnalyser";
            this.labelAnalyser.Size = new System.Drawing.Size(52, 14);
            this.labelAnalyser.TabIndex = 9;
            this.labelAnalyser.Tag = "";
            this.labelAnalyser.Text = "Analyser";
            // 
            // labelIssueDate
            // 
            this.labelIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIssueDate.AutoSize = true;
            this.labelIssueDate.Location = new System.Drawing.Point(7, 45);
            this.labelIssueDate.Name = "labelIssueDate";
            this.labelIssueDate.Size = new System.Drawing.Size(37, 14);
            this.labelIssueDate.TabIndex = 8;
            this.labelIssueDate.Tag = "";
            this.labelIssueDate.Text = "Date: ";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.BackColor = System.Drawing.SystemColors.Control;
            this.labelCustomerName.Location = new System.Drawing.Point(196, 18);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(90, 14);
            this.labelCustomerName.TabIndex = 7;
            this.labelCustomerName.Tag = "";
            this.labelCustomerName.Text = "Customer Name";
            // 
            // buttonSearch
            // 
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(663, 41);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(99, 23);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // HistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 455);
            this.Controls.Add(this.groupBoxIssueDetails);
            this.Controls.Add(this.groupBoxErrorandTroubleshooting);
            this.Controls.Add(this.groupBoxSelectedIssueDetails);
            this.Controls.Add(this.groupBoxSearchIssue);
            this.Controls.Add(this.groupBoxIssueHistory);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HistoryView";
            this.Text = "History View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.groupBoxIssueHistory.ResumeLayout(false);
            this.groupBoxSearchIssue.ResumeLayout(false);
            this.groupBoxSearchIssue.PerformLayout();
            this.groupBoxErrorandTroubleshooting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErrorData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResolvingSteps)).EndInit();
            this.groupBoxSelectedIssueDetails.ResumeLayout(false);
            this.groupBoxSelectedIssueDetails.PerformLayout();
            this.groupBoxIssueDetails.ResumeLayout(false);
            this.groupBoxIssueDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.GroupBox groupBoxIssueHistory;
        private System.Windows.Forms.GroupBox groupBoxSearchIssue;
        private System.Windows.Forms.GroupBox groupBoxErrorandTroubleshooting;
        private System.Windows.Forms.GroupBox groupBoxSelectedIssueDetails;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxIssueDescription;
        private System.Windows.Forms.GroupBox groupBoxIssueDetails;
        private System.Windows.Forms.Label labelSerial;
        private System.Windows.Forms.Label labelAnalyser;
        private System.Windows.Forms.Label labelIssueDate;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelIssueStatus;
        private System.Windows.Forms.DataGridView dataGridViewResolvingSteps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIssueSearchDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearchErrorCode;
        private System.Windows.Forms.ComboBox comboBoxAnalyserSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxSearchResolved;
        private System.Windows.Forms.ComboBox comboBoxSearchCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGetDemoData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Analyser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridView dataGridViewErrorData;
        private System.Windows.Forms.Button buttonSearch;
    }
}