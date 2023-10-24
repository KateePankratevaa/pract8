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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp8.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        private User user { get; set; } = new User();
        public UserPage()
        {
            InitializeComponent();
            user.UserName = "Vasya";
            user.Status = "Manager";
            user.LastLogin = new DateTime(2007, 07, 07);
            DataContext = user;
        }

        private void ChangePropertiesButton_Click(object sender, RoutedEventArgs e)
        {
            user.UserName = "Natashya";
            user.Status = "Admin";
        }

        private void CheckProperties_Click(object sender, RoutedEventArgs e)
        {
            string pattern = "UserName: {0}; Status: {1}";
            MessageBox.Show(string.Format(pattern, user.UserName, user.Status));
        }

    }
}
