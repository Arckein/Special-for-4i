using System;
using System.Data.Entity;
using System.Windows;
using System.Windows.Threading;

namespace TestInterface.Windows
{
    /// <summary>
    /// Логика взаимодействия для ClientService.xaml
    /// </summary>
    public partial class ClientService : Window
    {
        ModelDB.ModelSalon db = new ModelDB.ModelSalon();
        public static ModelDB.ClientService clientService = new ModelDB.ClientService();
        public ClientService()
        {
            InitializeComponent();
            clientService = null;
            db.ClientService.Load();
            ClientServiceTableDtGrd.ItemsSource = db.ClientService.Local;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 30);
            timer.Start();
        }

        void ClientServiceClick()
        {
            clientService = (ModelDB.ClientService)ClientServiceTableDtGrd.SelectedItem;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ClientServiceTableDtGrd.ItemsSource = db.ClientService.Local;
        }

        private void AddClientServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            AddClientService addClientService = new AddClientService();
            addClientService.Show();
        }

        private void ChangeClientServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            ClientServiceClick();
            if (clientService != null)
            {
                ChangeClientService changeClientService = new ChangeClientService();
                changeClientService.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите запись для редактирования!", "Ошибка");
            }
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
