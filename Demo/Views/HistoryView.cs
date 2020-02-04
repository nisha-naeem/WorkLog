using Demo.ViewModels;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WorkLogIcons;

namespace Demo.Views
{
    public partial class HistoryView : Form
    {
        private IconsHandler iconHandler = new IconsHandler();
        private HistoryViewModel _viewModel;
        public HistoryView(HistoryViewModel viewModel)
        {
            InitializeComponent();
            this._viewModel = viewModel;

            InitialiseBindings();
            this.buttonSearch.Image = iconHandler.GetIcon(IconNames.Search);
        }

        #region Bindings
        private void InitialiseBindings()
        {
            dataGridViewHistory.DataSource = _viewModel.IssueHistoryData;

            //bind the controls

            // Binding Issue Number
            groupBoxSelectedIssueDetails.DataBindings.Add(new Binding("Text", _viewModel, nameof(_viewModel.SelectedIssueNumber)));

            //Issue Desc. -groupbox textbox
            textBoxIssueDescription.DataBindings.Add(new Binding("Text", _viewModel, nameof(_viewModel.SelectedIssueDescription)));

            //Resolved status - groupbox textbox.text & back colour
            labelIssueStatus.DataBindings.Add(new Binding("Text", _viewModel, nameof(_viewModel.DisplayStringResolvedStatus)));
            labelIssueStatus.DataBindings.Add(new Binding("BackColor", _viewModel, nameof(_viewModel.ResolvedStatusColour)));

            //Date - groupbox textbox.text
            labelIssueDate.DataBindings.Add(new Binding("Text", _viewModel, nameof(_viewModel.SelectedDateTime)));

            //Customer Name - groupbox textbox.text
            labelCustomerName.DataBindings.Add(new Binding("Text", _viewModel, nameof(_viewModel.SelectedCustomerName)));

            //Analyser - groupbox textbox.text
            labelAnalyser.DataBindings.Add(new Binding("Text", _viewModel, nameof(_viewModel.SelectedAnalyser)));

            //Serial - groupbox textbox.text
            labelSerial.DataBindings.Add(new Binding("Text", _viewModel, nameof(_viewModel.SelectedSerial)));

            //Error Messages(s) - Grid
            dataGridViewErrorData.DataSource = _viewModel.SelectedErrorData;

            //Resolvigng steps -datagrid

            dataGridViewResolvingSteps.DataSource = _viewModel.SelectedStepsToResolve;

            //Search Issues Binding
            //Search ErrorCode 

            textBoxSearchErrorCode.DataBindings.Add(new Binding("Text", _viewModel, nameof(_viewModel.SearchErrorCode)));

            //Search Analyser

            comboBoxAnalyserSearch.DataBindings.Add(new Binding("Text", _viewModel, nameof(_viewModel.SearchAnalyser)));

            //Search Customer

            comboBoxSearchCustomer.DataBindings.Add(new Binding("Text", _viewModel, nameof(_viewModel.SearchCustomer)));

            //Search Issue Description

            textBoxIssueSearchDescription.DataBindings.Add(new Binding("Text", _viewModel, nameof(_viewModel.SearchIssueDescription)));

            //Search Resolved Status

            checkBoxSearchResolved.DataBindings.Add(new Binding("Checked", _viewModel, nameof(_viewModel.SearchIsResolvedStatus)));


        }
        #endregion

        private void buttonGetDemoData_Click(object sender, EventArgs e)
        {
            _viewModel.GetDemoData();

        }

        private void dataGridViewHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            this._viewModel.SelectedAnalyser = dataGridViewHistory[(int)ColumnIndex.Analyser, e.RowIndex]?.Value.ToString();
            this._viewModel.SelectedCustomerName = dataGridViewHistory[(int)ColumnIndex.Customer, e.RowIndex]?.Value.ToString();
            this._viewModel.SelectedIssueNumber = dataGridViewHistory[(int)ColumnIndex.IssueNumber, e.RowIndex]?.Value.ToString();
            this._viewModel.SelectedIssueDescription = dataGridViewHistory[(int)ColumnIndex.IssueDescription, e.RowIndex]?.Value.ToString();
            this._viewModel.SelectedSerial = dataGridViewHistory[(int)ColumnIndex.Serial, e.RowIndex]?.Value.ToString();
            this._viewModel.SelectedDateTime = DateTime.Parse((dataGridViewHistory[(int)ColumnIndex.IssueDate, e.RowIndex].Value.ToString()));
            this._viewModel.SelectedResolvedStatus = bool.Parse((dataGridViewHistory[(int)ColumnIndex.ResolvedStatus, e.RowIndex].Value.ToString()));

        }


        private enum ColumnIndex
        {
            IssueNumber,
            IssueDescription,
            ResolvedStatus,
            IssueDate,
            ErrorCode,
            Serial,
            Analyser,
            Customer
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            _viewModel.Search();
        }

        private void buttonViewReport_Click(object sender, EventArgs e)
        {
            // _viewModel.PrepReportData();
            List<ReportParameter> parameters = new List<ReportParameter>();
            parameters.Add(new ReportParameter ("Servicenumber",_viewModel.SelectedIssueNumber));
            parameters.Add(new ReportParameter("CustomerName", _viewModel.SelectedCustomerName));
            parameters.Add(new ReportParameter("Customer", _viewModel.SelectedCustomerName));
            parameters.Add(new ReportParameter("Location", "TLA static"));
            parameters.Add(new ReportParameter("EquipmentName", "Hematology Analyser Static"));
            parameters.Add(new ReportParameter("Model", _viewModel.SelectedAnalyser));
            parameters.Add(new ReportParameter("SerialNumber", _viewModel.SelectedSerial));
            parameters.Add(new ReportParameter("Manufacturer", "Abbott Static"));
            parameters.Add(new ReportParameter("CountryOfOrigin", "USA static"));
            parameters.Add(new ReportParameter("ServiceDate", "02/02/20"));
            parameters.Add(new ReportParameter("ServiceType", "Breakdown"));
            parameters.Add(new ReportParameter("ComplaintFaults", "Breakdown"));
            parameters.Add(new ReportParameter("WorkDonePartsReplaced", "Breakdown"));
            parameters.Add(new ReportParameter("Remarks", "Breakdown"));
            parameters.Add(new ReportParameter("EmployeeName", "Breakdown"));
            parameters.Add(new ReportParameter("EmployeeDesignation", "Breakdown"));


            ReportView reportView = new ReportView(parameters) { MdiParent =  this.MdiParent};
            reportView.Show();
        }
        
    }
}