using HandBookApp.Pages;
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

namespace HandBookApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AddingPage addingPage;


        public MainWindow()
        {
            InitializeComponent();
            addingPage = new AddingPage();
            MainFrame.Content = addingPage;
        }

        private void AddingButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = addingPage;
        }
        
        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ShowingPage();
        }
    }
}
