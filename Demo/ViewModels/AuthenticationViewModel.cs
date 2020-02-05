using Demo.Models;
using Hashing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ViewModels
{
    public class AuthenticationViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;
        private string demoGoodhash = "SHA512:88:h6pvTFtO/T3jX6+y8hcooFyKPoJqCPjJ0A==:Pz1TipWOZYTRDOzTXtiPaFIQC1+m6TlzubVsx2bXEJrGTZuAx1CScW7rH0zuFqIkQV8rXGGT/tbCc7TcG6REvQ==";
        
        public AuthenticationViewModel()
        {

        }

        public string Username
        {
            get => _username;
            set
            {
                if (_username == value) return;
                _username = value;
                NotifyPropertyChanged();
            }
        }
        public string Password 
        {
            get => _password;
            set
            {
                if (_password == value) return;
                _password = value;
                NotifyPropertyChanged();
            }
        }

        public bool IsLoginButtonEnabled
        {
            get
            {
                if (string.IsNullOrEmpty(this.Username) || string.IsNullOrEmpty(this.Password))
                {
                    return false;
                }
                else { return true; }

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool Authenticate()
        {
            //fetch the user with hash.
            if (Sha512.VerifyPassword(this.Password, GetUser(this.Username).Hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private User GetUser(string username)
        {
            //call API to get user
            if (this._username == "admin")
            return new User() { Hash = this.demoGoodhash };
            else return new User() { Hash = "SHA512:88:h6pvTFtO/T3jX6+y8hcooFyKPoJqCPjJ0A==:Pz1TipWOyYTRDOzTXtiPaFIQC1+m6TlzubVsx2bXEJrGTZuAx1CScW7rH0zuFqIkQV8rXGGT/tbCc7TcG6REvQ==" };
        }
    }
}
