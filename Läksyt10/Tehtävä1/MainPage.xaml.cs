using System;
using System.Collections.Generic;
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

namespace Tehtävä1
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

        private void buy_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)milk.IsChecked)
            {
                list.Text += " " + milk.Content.ToString();
            }

            if ((bool)butter.IsChecked)
            {
                list.Text += " " + butter.Content.ToString();
            }

            if ((bool)meat.IsChecked)
            {
                list.Text += " " + meat.Content.ToString();
            }

            if ((bool)juice.IsChecked)
            {
                list.Text += " " + juice.Content.ToString();
            }

            if ((bool)rice.IsChecked)
            {
                list.Text += " " + rice.Content.ToString();
            }
        }
    }
}
//Milk butter meat juice rice