using Demo.ViewModels;
using Hashing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.Views
{
    public partial class Authentication : Form
    {
        private AuthenticationViewModel _viewModel;
        public event EventHandler OnUserAuthenticated;
        public Authentication(AuthenticationViewModel viewModel)
        {
            InitializeComponent();
            this._viewModel = viewModel;
            InitialiseBindings();
        }

        private void InitialiseBindings()
        {
            textBoxUsername.DataBindings.Add(new Binding("Text", _viewModel, nameof(_viewModel.Username)));
            textBoxPassword.DataBindings.Add(new Binding("Text", _viewModel, nameof(_viewModel.Password)));

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (_viewModel.Authenticate())
            {
                UserAuthenticationCompleted();
                this.Close();
                this.Dispose();
                GC.Collect();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }

        private void UserAuthenticationCompleted()
        {
            this.OnUserAuthenticated(this, new AutheticatedUserEventArgs());
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
           var CancelMessageBoxResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo);
            if (CancelMessageBoxResult == DialogResult.Yes)
            Application.Exit();
        }
    }

    public class AutheticatedUserEventArgs : EventArgs
    {
        public int Id { get; set; }
        public string Useranme { get; set; }
        public string Designation { get; set; }
    }
}
