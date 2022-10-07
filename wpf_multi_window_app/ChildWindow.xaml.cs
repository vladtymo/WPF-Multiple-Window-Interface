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
using System.Windows.Shapes;

namespace wpf_multi_window_app
{
    /// <summary>
    /// Interaction logic for ChildWindow.xaml
    /// </summary>
    public partial class ChildWindow : Window
    {
        public string? Username { get; set; }
        public ChildWindow()
        {
            InitializeComponent();
        }
        public ChildWindow(string username)
        {
            InitializeComponent();
            this.Title = $"Hello, dear {username}";
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ShowUsername_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Username: " + Username);
        }
    }
}
