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

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "diegomated" && txtPassword.Password == "autofarm123")
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.mainFrame.NavigationService.Navigate(new Home());
            }
            else
            {
                MessageBox.Show("Username o Contraseña incorrecta");
            }
        }
    }
}
