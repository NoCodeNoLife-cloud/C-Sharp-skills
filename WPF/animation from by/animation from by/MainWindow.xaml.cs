using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace animation_from_by
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Rectangle myRectangle = new Rectangle();

            // Assign the Rectangle a name so that
            // it can be targeted by a Storyboard.
            this.RegisterName(
                "byAnimatedRectangle", myRectangle);
            myRectangle.Height = 10;
            myRectangle.Width = 100;
            myRectangle.HorizontalAlignment = HorizontalAlignment.Left;
            myRectangle.Fill = Brushes.BlueViolet;

            // Demonstrates the From and By properties used together.
            // Increments the Rectangle's Width property by 300 over 10 seconds.
            // As a result, the Width property is animated from 50
            // to 350 (50 + 300) over 10 seconds.
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = 50;
            myDoubleAnimation.By = 300;
            myDoubleAnimation.Duration =
                new Duration(TimeSpan.FromSeconds(10));

            Storyboard.SetTargetName(myDoubleAnimation, "byAnimatedRectangle");
            Storyboard.SetTargetProperty(myDoubleAnimation,
                new PropertyPath(Rectangle.WidthProperty));
            Storyboard myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myDoubleAnimation);

            // Use an anonymous event handler to begin the animation
            // when the rectangle is clicked.
            myRectangle.MouseLeftButtonDown += delegate (object sender, MouseButtonEventArgs args)
            {
                myStoryboard.Begin(myRectangle);
            };

            this.Content = myRectangle;
        }
    }
}
