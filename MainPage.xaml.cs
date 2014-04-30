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
    public partial class MainPage : PhoneApplicationPage
    {
        
        int intTotal = 0;
        int value1 = 0;
        int value2 = 0;
        int value3 = 0;
        int value4 = 0;
        // Constructor
        public MainPage()
        {
            
            InitializeComponent();
            txtTotal.Text = intTotal.ToString();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e) 
        { 
           
            base.OnNavigatedTo(e); 
            string newparameter = this.NavigationContext.QueryString["parameter"];
            int comma1 = newparameter.IndexOf(',');
            int comma2 = newparameter.IndexOf(',', comma1 + 1);
            int comma3 = newparameter.IndexOf(',', comma2 + 1);
            for (int index = 0; index < comma1; index++)
                value1 = value1 * 10 + (newparameter[index] - 48);
   
            for (int index=comma1+1; index < comma2; index++) 
                value2 = value2 * 10 + (newparameter[index] - 48);

            for (int index=comma2+1; index < comma3; index++) 
                value3 = value3 * 10 + (newparameter[index] - 48);

            for (int index = comma3 + 1; index < newparameter.Length; index++)
                value4 = value4 * 10 + (newparameter[index] - 48);
            
            this.btn1Point.Content = value1;
            this.btn2Point.Content = value2;
            this.btn3Point.Content = value3; 
            this.btn4Point.Content = value4;

            if (value1 != 0) this.btn1Point.Visibility = Visibility.Visible;
            if (value2 != 0) this.btn2Point.Visibility = Visibility.Visible;
            if (value3 != 0) this.btn3Point.Visibility = Visibility.Visible;
            if (value4 != 0) this.btn4Point.Visibility = Visibility.Visible;
        } 

        private void btn1Point_Click(object sender, RoutedEventArgs e)
        {
            intTotal += value1;
            txtTotal.Text = intTotal.ToString();
        }

        private void btn2Point_Click(object sender, RoutedEventArgs e)
        {
            intTotal += value2;
            txtTotal.Text = intTotal.ToString();
        }

        private void btn3Point_Click(object sender, RoutedEventArgs e)
        {
            intTotal += value3;
            txtTotal.Text = intTotal.ToString();
        }

        private void btn4Point_Click(object sender, RoutedEventArgs e)
        {
            intTotal += value4;
            txtTotal.Text = intTotal.ToString();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            intTotal = 0;
            txtTotal.Text = intTotal.ToString();
        }



    }
}