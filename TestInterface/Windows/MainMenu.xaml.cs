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
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ServiceClientBtn_Click(object sender, RoutedEventArgs e)
        {
            ClientService clientService = new ClientService();
            clientService.Show();
            this.Hide();
        }
                

        private void ServiceBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClientBtn_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client();
            client.Show();
            this.Hide();
        }
        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
    }
}
