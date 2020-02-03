﻿using Demo.Models;
using Demo.ViewModels;
using System;
using System.Drawing;
using System.Windows.Forms;
using WorkLogIcons;

namespace Demo
{
    public partial class NewIssueView : Form
    {
        private NewIssueViewModel _issueData;
        private IconsHandler iconHandler = new IconsHandler();

        private Point DisplayLocation = new Point(0, 28);
        private Point HiddenLocation = new Point(732, 28);
        private UiState? uiState;

        private bool isControlKeyPressed = false;

        public Image GetIcon { get; private set; }

        public NewIssueView(NewIssueViewModel newIssue)
        {
            InitializeComponent();
            this._issueData = newIssue;

            //Data bind the controls
            InitializeBinding();

            DisplayDataEntryPage();

        }

        private void InitializeBinding()
        {
            //Binding Customer
            comboBoxCustomer.DataSource = _issueData.Customers;
            comboBoxCustomer.DisplayMember = nameof(CustomerModel.Name);
            comboBoxCustomer.ValueMember = nameof(CustomerModel.Id);

            //Bind Issue Date
            dateTimePickerIssueDate.DataBindings.Add("Value", _issueData, nameof(_issueData.IssueDate));

            //Bind Analyser 
            comboBoxAnalyser.DataSource = _issueData.Analysers;
            comboBoxAnalyser.DisplayMember = nameof(AnalyserModel.Name);
            comboBoxAnalyser.ValueMember = nameof(AnalyserModel.Id);

            //Bind Serial
            comboBoxSerial.DataSource = _issueData.Serials;
            comboBoxSerial.DisplayMember = nameof(SerialModel.SerialNo);
            comboBoxSerial.ValueMember = nameof(SerialModel.Id);

            //Bind Issue description
            textBoxIssueDescription.DataBindings.Add("Text", _issueData, nameof(_issueData.IssueDescription));

            //Bind ErrorData (Dropdown Box)
            comboBoxErrorData.DataSource = _issueData.ErrorData;
            comboBoxErrorData.DisplayMember = nameof(ErrorDataModel.Message);
            comboBoxErrorData.ValueMember = nameof(ErrorDataModel.Id);

            //Bind ErrorMessageDisplay (Table)
            dataGridViewErrorMessageDisplay.DataSource = _issueData.ErrorMessages;

            //Bind Resolved Checkbox
            checkBoxResolved.DataBindings.Add(new Binding("Checked", _issueData, nameof(_issueData.IsResolved)));

            //Bind the resolving steps table
            dataGridViewResolvingSteps.DataSource = _issueData.resolvingStepsModels;

        }


        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var SelectedError = (ErrorDataModel)comboBoxErrorData.SelectedItem;

            _issueData.ErrorMessages.Add(new ErrorMessageDisplay() { ErrorCode = SelectedError.Code, Message = SelectedError.Message });
        }

        private void ToolStripButtonIssueResolveSteps_Click(object sender, EventArgs e)
        {
            DisplayResolvingStepsEntryPage();
        }

        private void DisplayDataEntryPage()
        {
            if (uiState != UiState.DataEntry || uiState == null)
            {
                panelDataEntry.Location = DisplayLocation;
                panelResolvingSteps.Location = HiddenLocation;
                panelDataEntry.Show();
                panelResolvingSteps.Hide();
                this.toolStripButtonSaveIssue.Image = iconHandler.GetIcon(IconNames.Save);
                this.uiState = UiState.DataEntry;
            }
        }

        private void DisplayResolvingStepsEntryPage()
        {
            if (uiState != UiState.ResolvingStepsEntry)
            {
                panelResolvingSteps.Location = DisplayLocation;
                panelDataEntry.Location = HiddenLocation;
                panelResolvingSteps.Show();
                panelDataEntry.Hide();
                this.toolStripButtonSaveIssue.Image = iconHandler.GetIcon(IconNames.Back);
                this.uiState = UiState.ResolvingStepsEntry;
            }
        }



        private void ToolStripButtonSaveIssue_Click(object sender, EventArgs e)
        {
            switch (uiState)
            {
                case UiState.DataEntry:
                    break;
                //Save the Issue and Details
                case UiState.ResolvingStepsEntry:
                    //Move the focus to data entry page.
                    textBoxStep.Text = "";
                    DisplayDataEntryPage();
                    break;
                default:
                    break;
            }
        }

        private void TextBoxStep_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.ControlKey:
                    isControlKeyPressed = true;
                    break;
                case Keys.Enter:
                    if (isControlKeyPressed == true & textBoxStep.Text != null)
                    {
                        int StepNumber = _issueData.resolvingStepsModels.Count + 1;
                        _issueData.resolvingStepsModels.Add(new ResolvingStepsModel { No = StepNumber, Step = textBoxStep.Text });
                        textBoxStep.Text = null;
                    }

                    break;
                default:
                    isControlKeyPressed = false;
                    break;
            }
        }

        /// <summary>
        /// Removes the instructions to the user in the textbox
        /// </summary>
        private void TextBoxStep_Enter(object sender, EventArgs e)
        {
            if (textBoxStep.Text == textBoxStep.Tag.ToString()) { textBoxStep.Text = null; }
            textBoxStep.ForeColor = Color.Black;
        }

        private void TextBoxStep_Leave(object sender, EventArgs e)
        {
            if (textBoxStep.Text == "")
            {
                textBoxStep.Text = textBoxStep.Tag.ToString();
            }
            textBoxStep.ForeColor = Color.Gray;

        }
    }

    public enum UiState
    {
        DataEntry,
        ResolvingStepsEntry
    }
}