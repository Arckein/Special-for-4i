using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        ModelDB.ModelSalon db = new ModelDB.ModelSalon();
        public static ModelDB.Client client = new ModelDB.Client();
        public Client()
        {
            InitializeComponent();
            client = null;
            db.Client.Load();
            ClientTableDtGrd.ItemsSource = db.Client.Local;
        }

        void ClientClick()
        {
           client = (ModelDB.Client)ClientTableDtGrd.SelectedItem;
        }

        private void AddClientBtn_Click(object sender, RoutedEventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.Show();
        }

        private void ChangeClientBtn_Click(object sender, RoutedEventArgs e)
        {
            ClientClick();
            if (client != null)
            {
                ChangeClient changeClient = new ChangeClient();
                changeClient.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите запись для редактирования!","Ошибка");
            }
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
