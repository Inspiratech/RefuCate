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
        private String m_userName = "";
        public String userName
        { 
            get { return m_userName; } 
            set
            {
                m_userName = value;
                NotifyPropertyChanged("userName");
            }
        }


        //Possibly SecureString?
        private String m_password;
        public String password
        {
            get { return m_password; }
            set
            {
                m_password = value;
                NotifyPropertyChanged("password");
            }
        }

        private String m_serverAddress;
        public String serverAddress
        {
            get { return m_serverAddress; }
            set
            {
                m_serverAddress = value;
                NotifyPropertyChanged("serverAddress");
            }
        }

        private Boolean m_saveSettings;
        public Boolean saveSettings
        {
            get { return m_saveSettings; }
            set
            {
                m_saveSettings = value;
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
