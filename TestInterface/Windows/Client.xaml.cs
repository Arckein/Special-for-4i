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

namespace TestInterface.Windows
{
    /// <summary>
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Window
    {
        public Client()
        {
            InitializeComponent();
        }

        private void AddClientBtn_Click(object sender, RoutedEventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.Show();
        }

        private void ChangeClientBtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeClient changeClient = new ChangeClient();
            changeClient.Show();
        }

        private void RemoveClientBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult remove = MessageBox.Show("Подтвердите удаление записи", "Внимание!", MessageBoxButton.YesNo);
            switch (remove)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Запись удалена!", "Удалено!");
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
