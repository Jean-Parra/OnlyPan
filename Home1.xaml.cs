using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventParadigm
{
    /// <summary>
    /// Lógica de interacción para Home1.xaml
    /// </summary>
    public partial class Home1 : Page
    {
        public Home1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombre.Text;
            string documento = txtDocumento.Text;
            string hora = txtHora.Text;
            string category = lblCategory.Content.ToString();
         
            txtResults.Text = nombre + "\n" + documento + "\n" + hora + "\n" + category;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.IsChecked.Value)
            {
                lblCategory.Content = rb.Content.ToString();
            }
        }
    }    
}
