namespace Demo
{
    partial class NewIssueView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewIssueView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSaveIssue = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIssueResolveSteps = new System.Windows.Forms.ToolStripButton();
            this.panelDataEntry = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePickerIssueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxAnalyser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSerial = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIssueDescription = new System.Windows.Forms.TextBox();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.labelIssueDescription = new System.Windows.Forms.Label();
            this.checkBoxResolved = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewErrorMessageDisplay = new System.Windows.Forms.DataGridView();
            this.ErrorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panelResolvingSteps = new System.Windows.Forms.Panel();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.dataGridViewResolvingSteps = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBoxErrorData = new System.Windows.Forms.ListBox();
            this.textBoxErrorData = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.panelDataEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErrorMessageDisplay)).BeginInit();
            this.panelResolvingSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResolvingSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSaveIssue,
            this.toolStripButtonIssueResolveSteps});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(727, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSaveIssue
            // 
            this.toolStripButtonSaveIssue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveIssue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveIssue.Image")));
            this.toolStripButtonSaveIssue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveIssue.Name = "toolStripButtonSaveIssue";
            this.toolStripButtonSaveIssue.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveIssue.Text = "Save Issue";
            this.toolStripButtonSaveIssue.Click += new System.EventHandler(this.ToolStripButtonSaveIssue_Click);
            // 
            // toolStripButtonIssueResolveSteps
            // 
            this.toolStripButtonIssueResolveSteps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonIssueResolveSteps.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIssueResolveSteps.Image")));
            this.toolStripButtonIssueResolveSteps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIssueResolveSteps.Name = "toolStripButtonIssueResolveSteps";
            this.toolStripButtonIssueResolveSteps.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonIssueResolveSteps.Text = "Add / View Issue Resolve Steps";
            this.toolStripButtonIssueResolveSteps.Click += new System.EventHandler(this.ToolStripButtonIssueResolveSteps_Click);
            // 
            // panelDataEntry
            // 
            this.panelDataEntry.Controls.Add(this.textBoxErrorData);
            this.panelDataEntry.Controls.Add(this.listBoxErrorData);
            this.panelDataEntry.Controls.Add(this.pictureBox1);
            this.panelDataEntry.Controls.Add(this.buttonAdd);
            this.panelDataEntry.Controls.Add(this.dateTimePickerIssueDate);
            this.panelDataEntry.Controls.Add(this.label3);
            this.panelDataEntry.Controls.Add(this.groupBox2);
            this.panelDataEntry.Controls.Add(this.textBoxIssueDescription);
            this.panelDataEntry.Controls.Add(this.comboBoxCustomer);
            this.panelDataEntry.Controls.Add(this.labelIssueDescription);
            this.panelDataEntry.Controls.Add(this.checkBoxResolved);
            this.panelDataEntry.Controls.Add(this.groupBox1);
            this.panelDataEntry.Controls.Add(this.label1);
            this.panelDataEntry.Location = new System.Drawing.Point(0, 28);
            this.panelDataEntry.Name = "panelDataEntry";
            this.panelDataEntry.Size = new System.Drawing.Size(726, 314);
            this.panelDataEntry.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(650, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(651, 62);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(61, 25);
            this.buttonAdd.TabIndex = 30;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // dateTimePickerIssueDate
            // 
            this.dateTimePickerIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerIssueDate.Location = new System.Drawing.Point(79, 40);
            this.dateTimePickerIssueDate.Name = "dateTimePickerIssueDate";
            this.dateTimePickerIssueDate.Size = new System.Drawing.Size(154, 22);
            this.dateTimePickerIssueDate.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "Issue Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxAnalyser);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxSerial);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 87);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instrument Details";
            // 
            // comboBoxAnalyser
            // 
            this.comboBoxAnalyser.FormattingEnabled = true;
            this.comboBoxAnalyser.Items.AddRange(new object[] {
            "CP3000",
            "SAP 1"});
            this.comboBoxAnalyser.Location = new System.Drawing.Point(15, 38);
            this.comboBoxAnalyser.Name = "comboBoxAnalyser";
            this.comboBoxAnalyser.Size = new System.Drawing.Size(140, 22);
            this.comboBoxAnalyser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Analyser";
            // 
            // comboBoxSerial
            // 
            this.comboBoxSerial.FormattingEnabled = true;
            this.comboBoxSerial.Location = new System.Drawing.Point(170, 38);
            this.comboBoxSerial.Name = "comboBoxSerial";
            this.comboBoxSerial.Size = new System.Drawing.Size(140, 22);
            this.comboBoxSerial.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Serial #";
            // 
            // textBoxIssueDescription
            // 
            this.textBoxIssueDescription.Font = new System.Drawing.Font("Cambria", 9F);
            this.textBoxIssueDescription.Location = new System.Drawing.Point(12, 212);
            this.textBoxIssueDescription.Multiline = true;
            this.textBoxIssueDescription.Name = "textBoxIssueDescription";
            this.textBoxIssueDescription.Size = new System.Drawing.Size(343, 86);
            this.textBoxIssueDescription.TabIndex = 24;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Items.AddRange(new object[] {
            "CP3000",
            "SAP 1"});
            this.comboBoxCustomer.Location = new System.Drawing.Point(79, 12);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(276, 22);
            this.comboBoxCustomer.TabIndex = 21;
            // 
            // labelIssueDescription
            // 
            this.labelIssueDescription.AutoSize = true;
            this.labelIssueDescription.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssueDescription.Location = new System.Drawing.Point(12, 192);
            this.labelIssueDescription.Name = "labelIssueDescription";
            this.labelIssueDescription.Size = new System.Drawing.Size(96, 14);
            this.labelIssueDescription.TabIndex = 27;
            this.labelIssueDescription.Text = "Issue Description";
            // 
            // checkBoxResolved
            // 
            this.checkBoxResolved.AutoSize = true;
            this.checkBoxResolved.Location = new System.Drawing.Point(283, 42);
            this.checkBoxResolved.Name = "checkBoxResolved";
            this.checkBoxResolved.Size = new System.Drawing.Size(72, 18);
            this.checkBoxResolved.TabIndex = 28;
            this.checkBoxResolved.Text = "Resolved";
            this.checkBoxResolved.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewErrorMessageDisplay);
            this.groupBox1.Location = new System.Drawing.Point(367, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 209);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Error Message(s) / Code(s)";
            // 
            // dataGridViewErrorMessageDisplay
            // 
            this.dataGridViewErrorMessageDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewErrorMessageDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewErrorMessageDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ErrorCode,
            this.Message});
            this.dataGridViewErrorMessageDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewErrorMessageDisplay.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewErrorMessageDisplay.Name = "dataGridViewErrorMessageDisplay";
            this.dataGridViewErrorMessageDisplay.Size = new System.Drawing.Size(343, 188);
            this.dataGridViewErrorMessageDisplay.TabIndex = 5;
            this.dataGridViewErrorMessageDisplay.TabStop = false;
            // 
            // ErrorCode
            // 
            this.ErrorCode.DataPropertyName = "ErrorCode";
            this.ErrorCode.FillWeight = 20F;
            this.ErrorCode.HeaderText = "Error Code";
            this.ErrorCode.Name = "ErrorCode";
            // 
            // Message
            // 
            this.Message.DataPropertyName = "Message";
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 20;
            this.label1.Text = "Customer";
            // 
            // panelResolvingSteps
            // 
            this.panelResolvingSteps.Controls.Add(this.textBoxStep);
            this.panelResolvingSteps.Controls.Add(this.dataGridViewResolvingSteps);
            this.panelResolvingSteps.Location = new System.Drawing.Point(732, 28);
            this.panelResolvingSteps.Name = "panelResolvingSteps";
            this.panelResolvingSteps.Size = new System.Drawing.Size(726, 314);
            this.panelResolvingSteps.TabIndex = 31;
            // 
            // textBoxStep
            // 
            this.textBoxStep.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxStep.Location = new System.Drawing.Point(17, 12);
            this.textBoxStep.Multiline = true;
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(694, 42);
            this.textBoxStep.TabIndex = 32;
            this.textBoxStep.Tag = "Please input the step and press Control and Enter to add";
            this.textBoxStep.Text = "Please input the step and press Control and Enter to add";
            this.textBoxStep.Enter += new System.EventHandler(this.TextBoxStep_Enter);
            this.textBoxStep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxStep_KeyDown);
            this.textBoxStep.Leave += new System.EventHandler(this.TextBoxStep_Leave);
            // 
            // dataGridViewResolvingSteps
            // 
            this.dataGridViewResolvingSteps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResolvingSteps.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewResolvingSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResolvingSteps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Step});
            this.dataGridViewResolvingSteps.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewResolvingSteps.Location = new System.Drawing.Point(0, 60);
            this.dataGridViewResolvingSteps.Name = "dataGridViewResolvingSteps";
            this.dataGridViewResolvingSteps.Size = new System.Drawing.Size(726, 254);
            this.dataGridViewResolvingSteps.TabIndex = 31;
            // 
            // No
            // 
            this.No.DataPropertyName = "No";
            this.No.FillWeight = 15F;
            this.No.HeaderText = "#";
            this.No.Name = "No";
            // 
            // Step
            // 
            this.Step.DataPropertyName = "Step";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Step.DefaultCellStyle = dataGridViewCellStyle1;
            this.Step.HeaderText = "Step to Resolve";
            this.Step.Name = "Step";
            // 
            // listBoxErrorData
            // 
            this.listBoxErrorData.FormattingEnabled = true;
            this.listBoxErrorData.ItemHeight = 14;
            this.listBoxErrorData.Location = new System.Drawing.Point(370, 85);
            this.listBoxErrorData.Name = "listBoxErrorData";
            this.listBoxErrorData.Size = new System.Drawing.Size(275, 60);
            this.listBoxErrorData.TabIndex = 32;
            // 
            // textBoxErrorData
            // 
            this.textBoxErrorData.Location = new System.Drawing.Point(370, 64);
            this.textBoxErrorData.Name = "textBoxErrorData";
            this.textBoxErrorData.Size = new System.Drawing.Size(275, 22);
            this.textBoxErrorData.TabIndex = 33;
            // 
            // NewIssueView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 342);
            this.Controls.Add(this.panelResolvingSteps);
            this.Controls.Add(this.panelDataEntry);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Cambria", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewIssueView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Issue";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelDataEntry.ResumeLayout(false);
            this.panelDataEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErrorMessageDisplay)).EndInit();
            this.panelResolvingSteps.ResumeLayout(false);
            this.panelResolvingSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResolvingSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveIssue;
        private System.Windows.Forms.ToolStripButton toolStripButtonIssueResolveSteps;
        private System.Windows.Forms.Panel panelDataEntry;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxAnalyser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSerial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIssueDescription;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Label labelIssueDescription;
        private System.Windows.Forms.CheckBox checkBoxResolved;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewErrorMessageDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelResolvingSteps;
        private System.Windows.Forms.DataGridView dataGridViewResolvingSteps;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Step;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxErrorData;
        private System.Windows.Forms.TextBox textBoxErrorData;
    }
}