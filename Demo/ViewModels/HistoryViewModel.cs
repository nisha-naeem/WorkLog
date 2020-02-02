using Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace Demo.ViewModels
{
    public class HistoryViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Public Properties
        public Color ResolvedStatusColour
        {
            get => resolvedStatusColour;
            private set
            {
                resolvedStatusColour = value;
                OnPropertyChanged(nameof(ResolvedStatusColour));
            }
        }

        public BindingList<ErrorDataModel> SelectedErrorData;

        public BindingList<ResolvingStepsModel> SelectedStepsToResolve;

        public string _selectedIssueDesc { get; set; }
        public string _selectedIssueNumber { get; set; }
        public string _selectedCustomerName { get; set; }
        public DateTime _selectedDateTime { get; set; }
        public string _selectedAnalyser { get; set; }
        public string _selectedSerial { get; set; }
        public string _selectedErrorMessages { get; set; }
        public bool _selectedResolvedStatus { get; set; }
        public string SearchErrorCode
        {
            get => _searchErrorCode; set
            {
                _searchErrorCode = value;
                OnPropertyChanged(nameof(SearchErrorCode));
            }
        }
        public string SearchAnalyser
        {
            get => _searchAnalyser; set
            {
                _searchAnalyser = value;
                OnPropertyChanged(nameof(SearchAnalyser));
            }
        }
        public string SearchCustomer
        {
            get => _searchCustomer; set
            {
                _searchCustomer = value;
                OnPropertyChanged(nameof(SearchCustomer));
            }
        }
        public string SearchIssueDescription
        {
            get => _searchIssueDescription; set
            {
                _searchIssueDescription = value;
                OnPropertyChanged(nameof(SearchIssueDescription));

            }
        }
        public bool SearchIsResolvedStatus
        {
            get => _searchIsResolvedStatus;
            set
            {
                _searchIsResolvedStatus = value;
                OnPropertyChanged(nameof(SearchIsResolvedStatus));
            }
        }
        public string SelectedIssueNumber
        {
            get
            {
                return "Issue #" + _selectedIssueNumber;
            }
            set
            {
                this._selectedIssueNumber = value;
                OnPropertyChanged(nameof(SelectedIssueNumber));
            }
        }
        public string SelectedIssueDescription
        {
            get
            {
                return _selectedIssueDesc;
            }
            set
            {
                this._selectedIssueDesc = value;
                OnPropertyChanged(nameof(SelectedIssueDescription));
            }
        }

        public string SelectedCustomerName
        {
            get
            {
                return _selectedCustomerName;
            }
            set
            {
                this._selectedCustomerName = value;
                OnPropertyChanged(nameof(SelectedCustomerName));
            }
        }

        public DateTime SelectedDateTime
        {
            get
            {
                return _selectedDateTime;
            }
            set
            {
                this._selectedDateTime = value;
                OnPropertyChanged(nameof(SelectedDateTime));
            }
        }

        public string SelectedAnalyser
        {
            get
            {
                return _selectedAnalyser;
            }
            set
            {
                this._selectedAnalyser = value;
                OnPropertyChanged(nameof(SelectedAnalyser));
            }
        }

        public string SelectedSerial
        {
            get
            {
                return _selectedSerial;
            }
            set
            {
                this._selectedSerial = value;
                OnPropertyChanged(nameof(SelectedSerial));
            }
        }

        public string SelectedErrorMessages
        {
            get
            {
                return _selectedErrorMessages;
            }
            set
            {
                this._selectedErrorMessages = value;
                OnPropertyChanged(nameof(SelectedErrorMessages));
            }
        }

        public string DisplayStringResolvedStatus
        {
            get { return _displayStringResolvedStatus; }
            private set
            {
                _displayStringResolvedStatus = value;
                OnPropertyChanged(nameof(DisplayStringResolvedStatus));
            }
        }

        public bool SelectedResolvedStatus
        {
            get
            {
                return _selectedResolvedStatus;
            }
            set
            {
                this._selectedResolvedStatus = value;

                if (_selectedResolvedStatus == true)
                {
                    ResolvedStatusColour = Color.LightGreen;
                    DisplayStringResolvedStatus = $"Issue Status: {ResolvedStatus.Resolved.ToString()}";
                }
                else
                {
                    ResolvedStatusColour = Color.PaleVioletRed;
                    DisplayStringResolvedStatus = $"Issue Status: {ResolvedStatus.Open.ToString()}";

                }

            }
        }
        public BindingList<HistoryModel> IssueHistoryData { get; set; }


        #endregion

        #region Constructor

        public HistoryViewModel()
        {
            this.IssueHistoryData = new BindingList<HistoryModel>();
            this.SelectedErrorData = new BindingList<ErrorDataModel>();
            this.SelectedStepsToResolve = new BindingList<ResolvingStepsModel>();

            this.PropertyChanged += HistoryViewModel_PropertyChanged;
        }
        #endregion

        #region Private Methods
        private void HistoryViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //if (e.PropertyName.Contains("Search")) { Debug.WriteLine(e.PropertyName); }
            //this handles selected error data display 
            if (e.PropertyName == nameof(this.SelectedIssueNumber))
            {
                var a = this.IssueHistoryData.FirstOrDefault(i => i.IssueNumber == int.Parse(this._selectedIssueNumber));
                this.SelectedErrorData.Clear();

                foreach (var item in a.ErrorData)
                {
                    this.SelectedErrorData.Add(item);
                }

            }

            //This handles selected steps to resolved selected issue.

            if (e.PropertyName == nameof(this.SelectedIssueNumber))
            {
                var b = this.IssueHistoryData.FirstOrDefault(i => i.IssueNumber == int.Parse(this._selectedIssueNumber));
                this.SelectedStepsToResolve.Clear();

                foreach (var item in b.StepsToResolve)
                {
                    this.SelectedStepsToResolve.Add(item);
                }


            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Private Propertiies

        private bool SelectedIsResolved { get; set; }
        private string _displayStringResolvedStatus;
        private Color resolvedStatusColour;
        private bool _searchIsResolvedStatus;
        private string _searchIssueDescription;
        private string _searchCustomer;
        private string _searchAnalyser;
        private string _searchErrorCode;

        #endregion

        #region DemoData
        internal void GetDemoData()
        {

            this.IssueHistoryData.Add(new HistoryModel()
            {
                CustomerName = "IGMH",
                ErrorCode = "H2012",
                Analyser = "CP3000",
                Description = "Sub-CPU Error",
                IssueNumber = 4321,
                IssueDateTime = DateTime.Now,
                Serial = "CP325182",
                ResolvedStatus = true,
                ErrorData = new List<ErrorDataModel>()
                 {
                     new ErrorDataModel()
                     {
                          Code = "ER01",
                          Id=1,
                          Message="This is the demo error for IGMH"
                     }
                 },
                StepsToResolve = new List<ResolvingStepsModel>()
                {
                    new ResolvingStepsModel()
                    {
                         No = 1,
                         Step = "This is the first resolving step of IGMH",

                    }
                },

            });

            //Checking whether search controls are bound
            this.SearchAnalyser = "asd";
            this.SearchCustomer = "asd";
            this.SearchErrorCode = "asd";
            this.SearchIsResolvedStatus = true;
            this.SearchIssueDescription = "asd";


            this.IssueHistoryData.Add(new HistoryModel()
            {
                CustomerName = "Senehiya",
                ErrorCode = "s374567",
                Analyser = "ci4100",
                Description = "Aspiration Error",
                IssueNumber = 34653,
                IssueDateTime = DateTime.Now,
                Serial = "vi4892679",
                ResolvedStatus = false,
                ErrorData = new List<ErrorDataModel>()
                 {
                     new ErrorDataModel()
                     {
                          Code = "ER0323",
                          Id=1,
                          Message="This is the demo error for Senehiya"
                     }
                 },
                StepsToResolve = new List<ResolvingStepsModel>()
                {
                    new ResolvingStepsModel()
                    {
                         No = 1,
                         Step = "This is the first resolving step of Senahiya",

                    },

                    new ResolvingStepsModel()
                    {
                         No = 2,
                         Step = "This is the second resolving step of Senahiya",
                    }
                }
            });

        }
        #endregion

        #region Public Methods

        public void Search()
        {
            var searchModel = new List<IssueHistorySearchModel>();
            var FieldForSearch = GetSearchTermWithValues();
            foreach (var item in FieldForSearch)
            {
                searchModel.Add(new IssueHistorySearchModel() { property = item.property, value = item.value });
            }

            //call the API

        }

        private dynamic GetSearchTermWithValues()
        {


            return this.GetType().GetProperties()
                .Select(x => new { property = x.Name, value = x.GetValue(this)?.ToString() })
                .Where(x => x.value != null && x.property.Contains("Search"))
                .Where(x => x.value.ToString() != string.Empty)
                .ToList();
        }

        #endregion



        public enum ResolvedStatus
        {
            Resolved,
            Open
        }





    }
}
