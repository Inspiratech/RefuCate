using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;//property changed

namespace RefuCate_WP7
{
    public class Settings : INotifyPropertyChanged
    {
        private String _userName = "";
        public String userName
        { 
            get { return _userName; } 
            set
            {
                _userName = value;
                NotifyPropertyChanged("userName");
            }
        }


        //Possibly SecureString?
        private String _password;
        public String password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyPropertyChanged("password");
            }
        }

        private String _serverAddress;
        public String serverAddress
        {
            get { return _serverAddress; }
            set
            {
                _serverAddress = value;
                NotifyPropertyChanged("serverAddress");
            }
        }

        private Boolean _saveSettings;
        public Boolean saveSettings
        {
            get { return _saveSettings; }
            set
            {
                _saveSettings = value;
                NotifyPropertyChanged("saveSettings");
            }
        }
        
        //private String language { get; set; } // Not yet used

        public void clear()
        {
            userName = "";
            password = "";
            saveSettings = false;
            //language = "";
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            if (null != PropertyChanged)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
