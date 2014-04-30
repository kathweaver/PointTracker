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

namespace PointTracker
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnAccumulator_Click(object sender, RoutedEventArgs e)
        {
            string parameter1 = textBox1.Text;
            string parameter2 = textBox2.Text;
            string parameter3 = textBox3.Text;
            string parameter4 = textBox4.Text;
            string parameterString = parameter1 + "," + parameter2 + "," + parameter3 + "," + parameter4;
            NavigationService.Navigate(new Uri(string.Format("/Mainpage.xaml?parameter={0}", parameterString), UriKind.Relative)); 

        }

        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}