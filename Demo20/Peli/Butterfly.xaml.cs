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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Peli
{
    public sealed partial class Butterfly : UserControl
    {
        // Animate
        private DispatcherTimer timer;
        // Offset
        private int currentframe = 0;
        private int direction = 1; // 1 or -1
        private int frameheight = 132;
        // Location
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        // Speed
        private readonly double MaxSpeed = 10.0;
        private readonly double Accelerate = 0.5;
        private double speed;
        // Angle
        private double Angle = 0;
        private readonly double AngleStep = 5;

        // Constructor
        public Butterfly()
        {
            this.InitializeComponent();

            // Start Animation
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0,0,0,0,125);
            timer.Start();
        }

        private void Timer_Tick(object sender, object e)
        {
            // Frame, 0,1,2,3,4,3,2,1,0....
            if (direction == 1) currentframe++;
            else currentframe--;
            // Direction
            if (currentframe == 0 || currentframe == 4) direction *= -1;
            // Set Offset
            SpriteSheetOffset.Y = currentframe * -frameheight;
        }

        // Show Butterfly in Right Position on Canvas
        public void UpdatePosition()
        {
            SetValue(Canvas.LeftProperty, LocationX);
            SetValue(Canvas.TopProperty, LocationY);
        }

        // Rotate

        public void Rotate(int angleDirection)
        {
            Angle += AngleStep * angleDirection; // -5 tai 5 riippuen suunnasta
            ButterflyRotateAngle.Angle = Angle;
        }

        // Move
        public void Move()
        {
            // VGS
            speed += Accelerate;
            if (speed > MaxSpeed) speed = MaxSpeed;
            // Update Location
            LocationX -= (Math.Cos(Math.PI / 180 * (Angle + 90))) * speed;
            LocationY -= (Math.Sin(Math.PI / 180 * (Angle + 90))) * speed;

        }


    } // Class
}// Namespace
