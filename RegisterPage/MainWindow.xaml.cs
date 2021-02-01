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

namespace RegisterPage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string first, last;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TestRun_Click(object sender, RoutedEventArgs e)
        {
            first = firstName.Text;
            last = lastName.Text;
            MessageBox.Show($"Email address: {emailAddress.Text} \nFirst name: {first} \nLast name: {last}");
        }
    }
}
