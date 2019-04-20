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
    /// Логика взаимодействия для AddingPage.xaml
    /// </summary>
    public partial class AddingPage : Page
    {
        public AddingPage()
        {
            InitializeComponent();

            PhoneTextBox.MaxLength = 6;

            using (var context = new AppContext())
            {
                foreach (var city in context.Cities.ToList())
                {
                    CitiesComboBox.Items.Add(city.Name);
                }
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CitiesComboBox.Text.Length < 1 || PhoneTextBox.Text.Length < 6 || NameTextBox.Text.Length < 1)
            {
                MessageBox.Show("Данные введены не верно!");
            }
            else
            {
                string phone = "";
                using (var context = new AppContext())
                {
                    foreach (var city in context.Cities.ToList())
                    {
                        if (city.Name == CitiesComboBox.Text)
                        {
                            phone = "+7" + city.Code.ToString();
                            break;
                        }
                    }

                    phone += PhoneTextBox.Text;

                    context.People.Add(new Person { Name = NameTextBox.Text, Phone = phone });
                    context.SaveChanges();
                }
                MessageBox.Show("Абонент успешно добавлен!");
                CitiesComboBox.Text = "";
                PhoneTextBox.Text = "";
                NameTextBox.Text = "";
            }
        }

        private void PhoneTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PhoneTextBox.Text.Length >= 1)
            {

                char lastSymbol = PhoneTextBox.Text.ToCharArray()[PhoneTextBox.Text.Length - 1];
                for (int i = 0; i < 10; i++)
                {
                    if (lastSymbol.ToString() == i.ToString())
                    {
                        return;
                    }
                }
                PhoneTextBox.Text = "";
            }

        }
    }
}
