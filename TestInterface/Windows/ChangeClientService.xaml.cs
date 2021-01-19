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
    /// Логика взаимодействия для ChangeClientService.xaml
    /// </summary>
    public partial class ChangeClientService : Window
    {
        public ChangeClientService()
        {
            InitializeComponent();
        }

        private void ChangeClientServiceBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
