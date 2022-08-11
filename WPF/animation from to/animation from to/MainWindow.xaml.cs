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

namespace animation_from_to
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Demonstrates the From and To properties used together.

            Rectangle myRectangle = new Rectangle();

            // Assign the Rectangle a name so that
            // it can be targeted by a Storyboard.
            this.RegisterName(
                "fromToAnimatedRectangle", myRectangle);
            myRectangle.Height = 10;
            myRectangle.Width = 100;
            myRectangle.HorizontalAlignment = HorizontalAlignment.Left;
            myRectangle.Fill = Brushes.Black;

            // Demonstrates the From and To properties used together.
            // Animates the rectangle's Width property from 50 to 300 over 10 seconds.
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = 50;
            myDoubleAnimation.To = 300;
            myDoubleAnimation.Duration =
                new Duration(TimeSpan.FromSeconds(1));

            Storyboard.SetTargetName(myDoubleAnimation, "fromToAnimatedRectangle");
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
