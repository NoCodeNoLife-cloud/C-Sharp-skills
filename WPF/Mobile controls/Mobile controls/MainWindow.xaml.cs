using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Mobile_controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private Point _mouseLocate;
        private Point _controlLocate;
        private bool _mouseDown;

        public MainWindow()
        {
            InitializeComponent();
            _mouseDown = false;
        }

        private void Button_OnMousePreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            _mouseDown = true;
            Control control = sender as Control;
            _mouseLocate = e.GetPosition(this);
            TranslateTransform transform = control.RenderTransform as TranslateTransform;
            if (transform == null)
            {
                transform = new TranslateTransform();
                control.RenderTransform = transform;
            }

            _controlLocate.X = transform.X;
            _controlLocate.Y = transform.Y;
        }

        private void Button_OnMousePreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Control control = sender as Control;
                Point nowLocate = e.GetPosition(this);
                Vector vector = nowLocate - _mouseLocate;
                TranslateTransform transform = control.RenderTransform as TranslateTransform;
                transform.X = _controlLocate.X + vector.X;
                transform.Y = _controlLocate.Y + vector.Y;
            }
        }

        private void Button_OnMousePreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            _mouseDown = false;
        }
    }
}