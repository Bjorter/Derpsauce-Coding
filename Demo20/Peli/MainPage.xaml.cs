using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Peli
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // Butterfly
        private Butterfly butterfly;

        // Flower

        private Flower flower;

        // Audio

        private MediaElement mediaElement;

        // Random

        private Random random = new Random();

        // Canvas Width Height
        private double CanvasWidth;
        private double CanvasHeight;

        // Which Keys Are Pressed

        private bool UpPressed;
        private bool LeftPressed;
        private bool RightPressed;

        // timer "Game Loop"

        private DispatcherTimer timer;

        public MainPage()
        {
            this.InitializeComponent();

            // Window Size
            ApplicationView.PreferredLaunchWindowingMode
                = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            ApplicationView.PreferredLaunchViewSize = new Size(800, 600);

            // Get Canvas Size
            CanvasWidth = MyCanvas.Width;
            CanvasHeight = MyCanvas.Height;

            // Add Butterfly
            butterfly = new Butterfly
            {
                LocationX = CanvasWidth / 2,
                LocationY = CanvasHeight / 2
            };

            MyCanvas.Children.Add(butterfly);
            butterfly.UpdatePosition();

            // Add Flower
            AddFlower();

            // Load Audio
            LoadAudio();            

            // Key Listeners
            Window.Current.CoreWindow.KeyDown += CoreWindow_KeyDown;
            Window.Current.CoreWindow.KeyUp += CoreWindow_KeyUp;

            // Initialise Game Loop

            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0,0,0,0,1000/60); //try 60 fps
            timer.Start();
        }

        // Load Audio From Assets
        public async void LoadAudio()
        {
            mediaElement = new MediaElement();
            mediaElement.AutoPlay = false;
            StorageFolder folder =
                await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            StorageFile file =
                await folder.GetFileAsync("tada.wav");
            var stream = await file.OpenAsync(FileAccessMode.Read);
            mediaElement.SetSource(stream, file.ContentType);
        }

        // Add a New Flower
        public void AddFlower()
        {
            flower = new Flower()
            {
                LocationX = random.Next(1, (int) CanvasWidth - 50),
                LocationY = random.Next(1, (int) CanvasHeight -50)
            };
            // Add to Canvas
            MyCanvas.Children.Add(flower);
            flower.UpdatePosition();
        }

        // Game Loop... 60 fps
        private void Timer_Tick(object sender, object e)
        {
            // Move
            if (UpPressed) butterfly.Move();
            // Rotate
            if (LeftPressed) butterfly.Rotate(-1); // -1 == left
            if (RightPressed) butterfly.Rotate(1); // 1 == right
            butterfly.UpdatePosition();
            // Collision... flower
            CheckCollision();
            // Update
            butterfly.UpdatePosition();
        }

        // Check Collision of Flower and Butterfly
        public void CheckCollision()
        {
            // Get Rectangles
            Rect r1 = new Rect(butterfly.LocationX, butterfly.LocationY, butterfly.ActualWidth, butterfly.ActualHeight);
            Rect r2 = new Rect(flower.LocationX, flower.LocationY, flower.ActualWidth, flower.ActualHeight);
            // Does Intersect...
            r1.Intersect(r2);
            if (!r1.IsEmpty) // Not Empty --> Intersected
            {
                // Remove Flower
                MyCanvas.Children.Remove(flower);
                // Play Tada
                mediaElement.Play();
                // Add a New Flower
                AddFlower();
            }
        }

        private void CoreWindow_KeyUp(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
        {
            switch (args.VirtualKey)
            {
                case Windows.System.VirtualKey.Up:
                    UpPressed = false;
                    Debug.WriteLine("Up Released!");
                    break;

                case Windows.System.VirtualKey.Left:
                    LeftPressed = false;
                    break;

                case Windows.System.VirtualKey.Right:
                    RightPressed = false;
                    break;

                default:
                    break;
            }
        }

        private void CoreWindow_KeyDown(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
        {
            switch (args.VirtualKey)
            {
                case Windows.System.VirtualKey.Up:
                    UpPressed = true;
                    Debug.WriteLine("Up pressed!");
                    break;

                case Windows.System.VirtualKey.Left:
                    LeftPressed = true;
                    break;

                case Windows.System.VirtualKey.Right:
                    RightPressed = true;
                    break;

                default:
                    break;
            }
        }
    }
}
