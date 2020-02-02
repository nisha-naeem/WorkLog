using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Demo.Models
{
    public class HistoryModel : INotifyPropertyChanged
    {

        public HistoryModel()
        {
            this.StepsToResolve = new List<ResolvingStepsModel>();
            this.ErrorData = new List<ErrorDataModel>();
        }

        
        private int issueNumber;
        private string errorCode;
        private string analyser;
        private string customerName;
        public int IssueNumber
        {
            get => issueNumber;

            set
            {
                if (issueNumber != value)
                {
                    issueNumber = value;
                    OnPropertyChanged(nameof(IssueNumber));
                }

            }
        }
        public string Description { get; set; }
        public bool ResolvedStatus { get; set; }
        public DateTime IssueDateTime { get; set; }
        public string ErrorCode
        {
            get => errorCode;
            set
            {
                if (errorCode != value)
                {
                    errorCode = value;
                    OnPropertyChanged(nameof(ErrorCode));

                }

            }
        }
        public string Serial { get; set; }
        public string Analyser
        {
            get => analyser; 
            set
            {
                if (analyser != value)
                {
                    analyser = value;
                    OnPropertyChanged(nameof(Analyser));

                }


            }
        }
        public string CustomerName
        {
            get => customerName; 
            set
            {
                if (customerName != value)
                {
                    customerName = value;
                    OnPropertyChanged(nameof(CustomerName));
                }
            }
        }
        public List<ResolvingStepsModel> StepsToResolve;
        public List<ErrorDataModel> ErrorData;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
