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

namespace HandBookApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для ShowingPage.xaml
    /// </summary>
    public partial class ShowingPage : Page
    {
        public ShowingPage()
        {
            InitializeComponent();
            TextBlock.Text += "Список абонентов:\n";
            using (var context = new AppContext())
            {
                foreach (var person in context.People)
                {
                    TextBlock.Text += $"Имя - {person.Name}\n";
                    TextBlock.Text += $"Номер телефона - {person.Phone}\n\n";
                }
            }
        }


    }
}
