using PRAK3.Core;
using PRAK3.Model;
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

namespace PRAK3.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainLoginPage.xaml
    /// </summary>
    public partial class MainLoginPage : Window
    {
        public MainLoginPage()
        {
            InitializeComponent();
        }


        private void BtnLogin_Click(Object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbLogin.Text) ||
                string.IsNullOrWhiteSpace(PbPassword.Password))
            {
                MessageBox.Show($"{userModel.login} - выполнен успешный вход",
                    "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    User userModel = CoreConnection.DB.Users.
                }
            }
        }

    }
}
