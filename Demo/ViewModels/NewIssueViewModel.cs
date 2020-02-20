using Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Demo.ViewModels
{
    public class NewIssueViewModel : INotifyPropertyChanged
    {
        #region Private Properties
        private string _selectedSerial;
        private int _selectedAnalyser;

        #endregion

        #region Events
        public delegate void PushMessageEventHandler(object sender, PushMessageEventArgs e);
       
        public event PropertyChangedEventHandler PropertyChanged;
        public event PushMessageEventHandler PushMessages;
        
        #endregion

        #region Default Constructor
        public NewIssueViewModel()
        {
            this.ErrorMessages = new BindingList<ErrorMessageDisplay>();
            this.PropertyChanged += NewIssueViewModel_PropertyChanged;
            LoadDemoData();
            FilteredErrorData =new BindingList<ErrorDataModel>() { new ErrorDataModel()};
        }

        #endregion

        #region PrivateMethods

        private void NewIssueViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == PropertyNames.SelectedSerial.ToString()) { UpdateSelectedAnalyser(this._selectedSerial); }
            if (e.PropertyName == PropertyNames.SelectedAnalyser.ToString()) { FilterAvailableErrorsList(this._selectedAnalyser); }
        }

        private void FilterAvailableErrorsList(int selectedAnalyser)
        {
            Debug.WriteLine($"Detected Analyser change: Analyser {selectedAnalyser}");
            FilteredErrorData.Clear();
            IEnumerable<ErrorDataModel> FilterResults = ErrorData.Where(e => e.AnalyserId == selectedAnalyser);
            Debug.WriteLine($"Filtered Results Count: {FilterResults.Count()}");


            foreach (var item in FilterResults)
            {
                FilteredErrorData.Add(item);
                Debug.WriteLine($"Match for Error Data, Message: {item.Message}");
                Debug.WriteLine($"Match for Error Data, Analyser Code: {item.AnalyserId}");

            }
        }

        private void UpdateSelectedAnalyser(string selectedSerial)
        {
            //The Analyser model will be null if there is no analyser match for the serial number
            AnalyserModel SelectedAnalyser = Analysers.SingleOrDefault(a => a.Serial == selectedSerial);
            if (SelectedAnalyser != null) { this.SelectedAnalyser = SelectedAnalyser.Id; }
        }

        private void LoadDemoData()
        {
            //set date
            this.IssueDate = DateTime.Today;

            //set issue description
            this.IssueDescription = "This is just a test issue. No worries!";

            //load customer list
            this.ErrorData = new List<ErrorDataModel>()
                {
                    new ErrorDataModel() 
                    { Id = 1, Code = "A001", Message = "This is CP3000 error", AnalyserId = 2 },
                    new ErrorDataModel() { Id = 2, Code = "A002", Message = "This is a Sapphire error", AnalyserId =1 }
                };

            //load customers
            this.Customers = new List<CustomerModel>()
                {
                    new CustomerModel() { Id = 1, Name = "Indira Gandhi Memorial Hospital" },
                    new CustomerModel() { Id = 2, Name = "Senehiya" },
                };

            //load serials
            this.Serials = new List<SerialModel>()
                {
                    new SerialModel() { Id = 1, SerialNo = "2653625ASJH" },
                    new SerialModel() { Id = 2, SerialNo = "HHF3625ASJH" }
                };



            //Load Analysers
            this.Analysers = new List<AnalyserModel>()
                {
                    new AnalyserModel() { Id = 1, Name = "Sapphire", Serial = "2653625ASJH" },
                    new AnalyserModel() { Id = 2, Name = "CP3000" , Serial = "HHF3625ASJH"}
                };

            //set demo resolving steps
            this.resolvingStepsModels = new BindingList<ResolvingStepsModel>()
            {
                new ResolvingStepsModel() {  No = 1, Step="This is a test resolving step!"},
                new ResolvingStepsModel() {  No = 2, Step="This is another test resolving step!"}
            };

            //set resolved status
            this.IsResolved = false;

        }
        #endregion

        #region Public Proprties
        public DateTime IssueDate { get; set; }
        public string IssueDescription { get; set; }
        public List<ErrorDataModel> ErrorData { get; set; }
        public BindingList<ErrorDataModel> FilteredErrorData { get; set; }
        public bool IsResolved { get; set; }

        public List<CustomerModel> Customers { get; set; }
        public List<AnalyserModel> Analysers { get; set; }
        public List<SerialModel> Serials { get; set; }
        public BindingList<ErrorMessageDisplay> ErrorMessages { get; set; }
        public BindingList<ResolvingStepsModel> resolvingStepsModels { get; set; }

        #region SelectedDataFromViews
        public string SelectedSerial
        {
            get => _selectedSerial;
            set
            {
                _selectedSerial = value;
                Debug.WriteLine($"The Selected Serial is: {_selectedSerial}");
                NotifyPropertyChanged();
            }
        }
        public int SelectedAnalyser
        {
            get => _selectedAnalyser; set
            {
                _selectedAnalyser = value;
                NotifyPropertyChanged();
            }
        }

        #endregion

        #endregion

        #region PublicMethods

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SaveIssue()
        {
            //save the issue
        }

        public void SaveResolvingSteps()
        {
            //Save resolving steps.
        }

        #endregion

        private enum PropertyNames
        {
            SelectedSerial,
            SelectedAnalyser
        }

    }



}
