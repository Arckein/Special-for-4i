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
    /// Логика взаимодействия для Service.xaml
    /// </summary>
    public partial class Service : Window
    {
        ModelDB.ModelSalon db = new ModelDB.ModelSalon();

        public Service()
        {
            InitializeComponent();
            
            db.Service.Load();
            ListServiceView.ItemsSource = db.Service.Local;
        }

        private void AddServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            AddService addService = new AddService();
            addService.Show();
            this.Hide();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void NextListBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackListBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveService_Click(object sender, RoutedEventArgs e)
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

        private void ChanceService_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
