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
    /// Логика взаимодействия для ClientService.xaml
    /// </summary>
    public partial class ClientService : Window
    {
        public ClientService()
        {
            InitializeComponent();
        }

        private void AddClientServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            AddClientService addClientService = new AddClientService();
            addClientService.Show();
        }

        private void ChangeClientServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeClientService changeClientService = new ChangeClientService();
            changeClientService.Show();
        }

        private void RemoveClientServiceBtn_Click(object sender, RoutedEventArgs e)
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
