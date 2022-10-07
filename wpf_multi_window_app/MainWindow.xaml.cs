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

namespace wpf_multi_window_app
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

        private void OpenChildWindow_Click(object sender, RoutedEventArgs e)
        {
            // Information: you can set a startup window in App.xaml file

            // create window instance
            ChildWindow window = new ChildWindow();

            // send data from parent to child window
            // 1: using constructor
            //ChildWindow window = new ChildWindow("Vladyslav");

            // 2: using properties
            //window.Title = "My custom title";
            //window.Username = "prodoq";

            // show window
            if (modalRadio.IsChecked == true)
                window.Show();
            else
                window.ShowDialog();

            if (isWillClose.IsChecked == true)
            {
                this.Close();
            }
        }
    }
}
