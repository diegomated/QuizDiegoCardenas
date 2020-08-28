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
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string clientName = txtProductname.Text;
            string category = lblCategoty.Content.ToString();
            string cantidadProd = lblCantidad.Content.ToString();
            string productoName = cmbProductos.Text;

            txtResults.Text = clientName + "\n" + category + "\n" + "x" + cantidadProd + " " + productoName;

            if (cbJugo.IsChecked == true)
            {
                txtResults.Text =txtResults.Text + "\n" + cbJugo.Content;
            }
            if (cbPapas.IsChecked == true)
            {
                txtResults.Text =txtResults.Text+"\n"+cbPapas.Content;
            }

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.IsChecked.Value)
            {
                lblCategoty.Content = rb.Content.ToString();
            }
        }

        private void sldCantidad_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double cantidad = Math.Truncate(sldCantidad.Value);
            lblCantidad.Content = cantidad.ToString();
        }
    }
}
