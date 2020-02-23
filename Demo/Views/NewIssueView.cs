using Demo.Models;
using Demo.ViewModels;
using System;
using System.Diagnostics;
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

       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>")]
        public NewIssueView(NewIssueViewModel newIssue)
        {
            InitializeComponent();
            if (newIssue != null)
            {
                this._issueData = newIssue;
                _issueData.PushMessages += _issueData_PushMessages;
            }

            //Data bind the controls
            InitializeBinding();
            DisplayDataEntryPage();

            //Subscribe for events

        }

        private void _issueData_PushMessages(string CallBackMemberName, PushMessageEventArgs e)
        {
            MessageBox.Show(e.Message,e.Title,e.Buttons);
        }

        private void InitializeBinding()
        {
            //Binding Customer
            sfComboBoxCustomer.DataSource = _issueData.Customers;
            sfComboBoxCustomer.DisplayMember = nameof(CustomerModel.Name);
            sfComboBoxCustomer.ValueMember = nameof(CustomerModel.Id);

            //Bind Issue Date
            dateTimePickerIssueDate.DataBindings.Add("Value", _issueData, nameof(_issueData.IssueDate));

            //Bind Analyser 
            sfComboBoxAnalyser.DataSource = _issueData.Analysers;
            sfComboBoxAnalyser.DisplayMember = nameof(AnalyserModel.Name);
            sfComboBoxAnalyser.ValueMember = nameof(AnalyserModel.Id);

            sfComboBoxAnalyser.DataBindings.Add("SelectedValue", _issueData, nameof(_issueData.SelectedAnalyser));

            //Bind Serial
            sfComboBoxSerial.DataSource = _issueData.Serials;
            sfComboBoxSerial.DisplayMember = nameof(SerialModel.SerialNo);
            //sfComboBoxSerial.ValueMember = nameof(SerialModel.Id);

            sfComboBoxSerial.DataBindings.Add("SelectedValue", _issueData, nameof(_issueData.SelectedSerial));

            //Bind Issue description
            textBoxIssueDescription.DataBindings.Add("Text", _issueData, nameof(_issueData.IssueDescription));

            //Bind ErrorData (Dropdown Box)
            sfComboBoxSelectErrorData.DataSource = _issueData.FilteredErrorData;


            //Bind ErrorMessageDisplay (Table)
            dataGridViewErrorMessageDisplay.DataSource = _issueData.ErrorMessages;

            //Bind Resolved Checkbox
            checkBoxResolved.DataBindings.Add(new Binding("Checked", _issueData, nameof(_issueData.IsResolved)));

            //Bind the resolving steps table
            dataGridViewResolvingSteps.DataSource = _issueData.resolvingStepsModels;

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var SelectedError = (ErrorDataModel)sfComboBoxSelectErrorData.SelectedItem;

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
            if (textBoxStep.Text.Length == 0)
            {
                textBoxStep.Text = textBoxStep.Tag.ToString();
            }
            textBoxStep.ForeColor = Color.Gray;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sfComboBoxSelectErrorData.Refresh();
            Debug.WriteLine("Clicked the image");

        }
    }

    public enum UiState
    {
        DataEntry,
        ResolvingStepsEntry
    }
}
