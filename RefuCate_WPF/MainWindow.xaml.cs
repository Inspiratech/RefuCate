using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RefuCate_WPF.Classes;

namespace RefuCate_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        People list;

        public MainWindow()
        {
            InitializeComponent();
            list = new People();
          
        }

        private void createPerson_Click(object sender, RoutedEventArgs e)
        {
            Person temp = new Person();
            temp.firstName = this.firstName.Text;
            temp.lastName = this.secondName.Text;

            list.addPerson(temp);
        }

        private void listPeople_Click(object sender, RoutedEventArgs e)
        {
            foreach (Person p in list.getList())
            {
                MessageBox.Show(p.firstName + " " + p.lastName);
            }

        }
    }
}
