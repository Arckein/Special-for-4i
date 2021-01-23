using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
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

namespace TestInterface.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddClientService.xaml
    /// </summary>
    public partial class AddClientService : Window
    {
        ModelDB.ModelSalon db = new ModelDB.ModelSalon();
        public AddClientService()
        {
            InitializeComponent();
            MessageBoxResult addClientService = MessageBox.Show("Клиент уже есть в базе?", "Внимание", MessageBoxButton.YesNo);
            switch (addClientService)
            {
                case MessageBoxResult.Yes: 
                    {
                        db.Client.Load();
                        FirstNameBox.ItemsSource = db.Client.Local;
                        LastNameBox.ItemsSource = db.Client.Local;
                        PatronymicBox.ItemsSource = db.Client.Local;
                        //if (FirstNameBox.SelectedItem != null)
                        //{
                        //    LastNameBox.ItemsSource = Client.client.LastName;
                        //    PatronymicBox.ItemsSource = Client.client.Patronymic;
                        //}
                        break;
                    }
                    
                case MessageBoxResult.No:
                    {
                        AddClient addClient = new AddClient();
                        addClient.Show();
                        break;
                    }     
            }
        }

        private void AddClientServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            ModelDB.ClientService clientService = new ModelDB.ClientService();
            if (FirstNameBox != null && LastNameBox != null && PatronymicBox != null && DatePicker.SelectedDate !=null && TimeTxt != null)
            {
                
            }
            else
            {
                MessageBox.Show("Некоректное заполнение данных!", "Ошибка!");
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
