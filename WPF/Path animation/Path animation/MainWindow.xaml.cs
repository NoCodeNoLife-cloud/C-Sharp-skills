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

namespace Path_animation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            rotatingLine.RenderTransformOrigin = new Point(0.5, 0.5);
            Canvas.SetLeft(rotatingLine, -rotatingLine.ActualWidth * rotatingLine.RenderTransformOrigin.X);
            Canvas.SetTop(rotatingLine, -rotatingLine.ActualHeight * rotatingLine.RenderTransformOrigin.Y);
            MatrixTransform MatrixTransform_01 = new MatrixTransform();

            this.RegisterName("MatrixTransform_01", MatrixTransform_01);
            rotatingLine.RenderTransform = MatrixTransform_01;

            Point centerPt = new Point(150, 150);
            ese1.Margin = new Thickness(centerPt.X, centerPt.Y, 0, 0);                    //指示中心点
            Canvas.SetLeft(ese1, -ese1.ActualWidth / 2);
            Canvas.SetTop(ese1, -ese1.ActualHeight / 2);

            PathGeometry aniPath = new PathGeometry();
            EllipseGeometry egStandard = new EllipseGeometry(centerPt, 100, 80);
            aniPath.AddGeometry(egStandard);

            //外层
            Path ph = new Path();
            SolidColorBrush StrokeBrush = (SolidColorBrush)mainCanvas.Resources["PathStrokeBrush01"];
            ph.Stroke = StrokeBrush;
            ph.StrokeThickness = 1;
            EllipseGeometry eg2 = new EllipseGeometry(centerPt, egStandard.RadiusX + rotatingLine.ActualHeight / 2, egStandard.RadiusY + rotatingLine.ActualHeight / 2);
            ph.Data = eg2;
            mainCanvas.Children.Add(ph);

            //内层
            Path ph3 = new Path();
            ph3.Stroke = StrokeBrush;
            //ph.Fill = System.Windows.Media.Brushes.MediumSlateBlue;
            ph3.StrokeThickness = 1;
            EllipseGeometry eg3 = new EllipseGeometry(centerPt, egStandard.RadiusX - rotatingLine.ActualHeight / 2, egStandard.RadiusY - rotatingLine.ActualHeight / 2);
            ph3.Data = eg3;
            mainCanvas.Children.Add(ph3);

            Path phStandard = new Path();
            phStandard.Stroke = System.Windows.Media.Brushes.Blue;
            //ph.Fill = System.Windows.Media.Brushes.MediumSlateBlue;
            phStandard.StrokeThickness = 1;
            phStandard.Data = egStandard;
            mainCanvas.Children.Add(phStandard);

            MatrixAnimationUsingPath matrixAnimation = new MatrixAnimationUsingPath();
            matrixAnimation.PathGeometry = aniPath;                                //动画的路径
            matrixAnimation.Duration = TimeSpan.FromSeconds(10);
            matrixAnimation.RepeatBehavior = RepeatBehavior.Forever;
            matrixAnimation.DoesRotateWithTangent = true;

            Storyboard.SetTargetName(matrixAnimation, "MatrixTransform_01");                        //动画的对象
            Storyboard.SetTargetProperty(matrixAnimation, new PropertyPath(MatrixTransform.MatrixProperty));

            Storyboard pathAnimationStoryboard = new Storyboard();
            pathAnimationStoryboard.Children.Add(matrixAnimation);
            pathAnimationStoryboard.Begin(this);
        }
    }
}
