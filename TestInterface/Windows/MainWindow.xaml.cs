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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestInterface.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ModelDB.ModelSalon db = new ModelDB.ModelSalon();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AutorizationBtn_Click(object sender, RoutedEventArgs e)
        {
            db.Authorization.Load();
            if (db.Authorization.AsNoTracking().Where(x => x.login == LoginTxt.Text && x.password == PasswordTxt.Password) != null)
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Введен неверный логин или пароль!", "Ошибка!");
            };                
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
    }
}
