using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace RefuCate_WP7
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            Settings userSettings = (App.Current.RootVisual as PhoneApplicationFrame).DataContext as Settings;
            if (chk_save.IsChecked == true)
            {
                Utils.saveUserSettings(userSettings);
            }
            else
            {
                Utils.clearUserSettings();
            }

            Utils.LoginStatus status = Utils.login(userSettings);

            //If login is successful load capture page, otherwise determine error (login/connection)
            //TODO: enumeration for status results: Success, Invalid credentials, Connection error
            if (status == Utils.LoginStatus.SUCCESS)
            {
                NavigationService.Navigate(new Uri("/CapturePage.xaml", UriKind.Relative));
            }
            else if (status == Utils.LoginStatus.AUTH_ERROR)
            {
                MessageBox.Show("The username or password entered was incorrect");
            }
            else if (status == Utils.LoginStatus.CON_ERROR)
            {
                MessageBox.Show("No data connection available, please try again");
            }

        }
    }
}
