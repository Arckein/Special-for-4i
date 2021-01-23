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
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {
        ModelDB.ModelSalon db = new ModelDB.ModelSalon();
        
        public AddClient()
        {
            InitializeComponent();
            db.Gender.Load();
            GenderBox.ItemsSource = db.Gender.Local;
        }


        private void AddClientBtn_Click(object sender, RoutedEventArgs e)
        {
            ModelDB.Client client = new ModelDB.Client();
            if (FirstNameTxt != null && LastNameTxt != null && PatronymicTxt != null && BirthdayPicker.SelectedDate != null && GenderBox != null && PhoneTxt.Text != null && EMailTxt != null)
            {
                client.FirstName = FirstNameTxt.Text;
                client.LastName = LastNameTxt.Text;
                client.Patronymic = PatronymicTxt.Text;

                //DateTime date = new DateTime(BirthdayPicker.SelectedDate.Value.Year, BirthdayPicker.SelectedDate.Value.Month, BirthdayPicker.SelectedDate.Value.Day);
                //string DP = BirthdayPicker.SelectedDate.Value.Year + "." + BirthdayPicker.SelectedDate.Value.Month + "." + ;
                // date = Convert.ToDateTime(DP);
                
                client.Birthday = BirthdayPicker.SelectedDate.Value.Date;
                
                client.GenderCode = db.Gender.Where(x=> x.Name == GenderBox.Text).FirstOrDefault().Code;
                client.Phone = PhoneTxt.Text;
                client.Email = EMailTxt.Text;
                 db.Client.Add(client);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Некоректное заполнение данных!", "Ошибка!");
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
