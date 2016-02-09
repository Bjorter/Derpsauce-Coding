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

namespace Ikkuna
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

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            int Height = int.Parse(height.Text);
            int Length = int.Parse(length.Text);
            int Thickness = int.Parse(thickness.Text);

            int WindowArea = (Height+(Thickness*2))*(Length+(Thickness*2));
            int GlassArea = Height*Length;
            int FrameCircum = Height*2 + Thickness*4 + Length*2;

            windowResult.Text = WindowArea.ToString();
            glassResult.Text = GlassArea.ToString();
            frameResult.Text = FrameCircum.ToString();
        }
    }
}
