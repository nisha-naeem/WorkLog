using Demo.Models;
using Demo.ViewModels;
using Demo.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Demo
{
    public partial class WorkLogUIView : Form
    {

        public WorkLogUIView()
        {
            InitializeComponent();
            PrepareForAuthentication();
            ShowAuthenticationView();
        }

        private void PrepareForAuthentication()
        {
            this.toolStrip1.Enabled = false;
            this.toolStrip1.Visible = false;   
        }

        private void ShowAuthenticationView()
        {
            Authentication authentication = new Authentication( new AuthenticationViewModel())
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen
            };

            authentication.OnUserAuthenticated += Authentication_OnUserAuthenticated;

            authentication.Show();
        }

        private void Authentication_OnUserAuthenticated(object sender, EventArgs e)
        {
            ReactionOnSuccessfulAuthentication();
        }

        private void ReactionOnSuccessfulAuthentication()
        {
            this.toolStrip1.Enabled = true;
            this.toolStrip1.Visible = true;
        }

        private void ToolStripButtonNewIssue_Click(object sender, EventArgs e)
        {


            //new View model
            var NewIssue = new NewIssueViewModel();
        
        
            var newIssue = new NewIssueView(NewIssue) { MdiParent = this };
            newIssue.Show();
        }

        private void ToolStripButtonHistory_Click(object sender, EventArgs e)
        {
            if (IsViewOpen(typeof(HistoryView)) == true) { return; }
            var History = new HistoryView(new HistoryViewModel()) {  MdiParent = this};
           // this.toolStrip1.Hide();
            History.Show();
        }

        private bool IsViewOpen(Type view)
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == view)
                {
                    form.Activate();
                    IsOpen = true;
                }
            }

            return IsOpen;
        }
    }
}
