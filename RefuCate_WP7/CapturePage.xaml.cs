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
using RefuCate_WPF.Classes;

namespace RefuCate_WP7
{
    public partial class CapturePage : PhoneApplicationPage
    {
        Person person = new Person();
        public CapturePage()
        {
            InitializeComponent();
            person = (App.Current.RootVisual as PhoneApplicationFrame).DataContext as Person;
        }
    }
}
