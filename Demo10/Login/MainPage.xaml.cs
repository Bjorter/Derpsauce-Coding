using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Login
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Name is {0}", nameTextBox.Text);
            Debug.WriteLine("Email is {0}", emailTextBox.Text);

            if ((bool)normalUserCheckBox.IsChecked)
            {
                Debug.WriteLine("Normal User!");
            }

            if ((bool)adminUserCheckBox.IsChecked)
            {
                Debug.WriteLine("Admin User!");
            }
        }

        private void normalUserCheckBox_Click(object sender, RoutedEventArgs e)
        {
            normalUserCheckBox.IsChecked = true;
            adminUserCheckBox.IsChecked = false;
        }

        private void adminUserCheckBox_Click(object sender, RoutedEventArgs e)
        {
            adminUserCheckBox.IsChecked = true;
            normalUserCheckBox.IsChecked = false;
        }
    }
}
