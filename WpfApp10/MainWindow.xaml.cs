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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition(this);
            MessageBox.Show("Координата x=" + p.X.ToString() + " y=" + p.Y.ToString());
        }

        //private void Window_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    mouseOverMe = true;
        //}

        //private void Window_MouseLeave(object sender, MouseEventArgs e)
        //{
        //    mouseOverMe = false;
        //}

        //public void DoSomething()
        //{
        //    if (Mouse.LeftButton == MouseButtonState.Pressed)
        //    {
        //        if (mouseOverMe)
        //        {
        //            MessageBox.Show("Im a mouse down in the window");
        //        }
        //    }
        //}






        //private void StackPanel_MouseUp(object sender, MouseButtonEventArgs e)
        //{
        //    textBlock1.Text = textBlock1.Text + "sender: " + sender.ToString() + "\n";
        //    textBlock1.Text = textBlock1.Text + "source: " + e.Source.ToString() + "\n\n";
        //}

        //private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    textBlock1.Text = textBlock1.Text + "sender: " + sender.ToString() + "\n";
        //    textBlock1.Text = textBlock1.Text + "source: " + e.Source.ToString() + "\n\n";
        //}

    }
}
