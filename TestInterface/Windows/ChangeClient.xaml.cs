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
    /// Логика взаимодействия для ChangeClient.xaml
    /// </summary>
    public partial class ChangeClient : Window
    {
        
        public ChangeClient()
        {
            InitializeComponent();
            FirstNameTxt.Text = Client.client.FirstName;
            LastNameTxt.Text = Client.client.LastName;
            PatronymicTxt.Text = Client.client.Patronymic;
            BirthdayTxt.Text = Convert.ToString(Client.client.Birthday);
            GenderTxt.Text = Client.client.Gender.Name;
            PhoneTxt.Text = Client.client.Phone;
            EMailTxt.Text = Client.client.Email;           
        }

        private void ChangeClientBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
