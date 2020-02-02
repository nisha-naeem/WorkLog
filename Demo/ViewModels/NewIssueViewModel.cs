using Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace Demo.ViewModels
{
    public class NewIssueViewModel
    {
        public NewIssueViewModel()
        {
            this.ErrorMessages = new BindingList<ErrorMessageDisplay>();
            LoadDemoData();
        }


        #region PrivateMethods
        private void LoadDemoData()
        {
            //set date
            this.IssueDate = DateTime.Today;
            
            //set issue description
            this.IssueDescription = "This is just a test issue. No worries!";

            //load customer list
            this.ErrorData = new List<ErrorDataModel>()
                {
                    new ErrorDataModel() { Id = 1, Code = "A001", Message = "Test Error Message" },
                    new ErrorDataModel() { Id = 2, Code = "A002", Message = "Another Error Message" }
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
                    new AnalyserModel() { Id = 1, Name = "Sapphire" },
                    new AnalyserModel() { Id = 2, Name = "CP3000" }
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

        #region Proprties
        public DateTime IssueDate { get; set; }
        public string IssueDescription { get; set; }
        public List<ErrorDataModel> ErrorData { get; set; }
        public bool IsResolved { get; set; }

        public List<CustomerModel> Customers { get; set; }
        public List<AnalyserModel> Analysers { get; set; }
        public List<SerialModel> Serials { get; set; }
        public BindingList<ErrorMessageDisplay> ErrorMessages { get; set; }
        public BindingList<ResolvingStepsModel> resolvingStepsModels { get; set; }

        #endregion

        #region PublicMethods
        public void SaveIssue()
        {
            //save the issue
        }

        public void SaveResolvingSteps()
        {
            //Save resolving steps.
        }

        #endregion


    }



}
