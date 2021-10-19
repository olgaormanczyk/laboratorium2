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

namespace laboratorium2
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public int cena1 = 0;
        public int polisa = 0;
        public Window1()
        {
            InitializeComponent();
            cena_label.Content = this.cena1;
        }


        private void fiat_radiobutton_Unchecked(object sender, RoutedEventArgs e)
        {
            cena1 -= 10000;
            cena_label.Content = cena1 + polisa;
        }

        private void ford_radiobutton_Unchecked(object sender, RoutedEventArgs e)
        {
            cena1 -= 50000;
            cena_label.Content = cena1 + polisa;
        }

        private void ford_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            cena1 += 50000;
            cena_label.Content = cena1 + polisa;
        }

        private void fiat_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            cena1 += 10000;
            cena_label.Content = cena1 + polisa;
        }

        private void ferrari_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            cena1 += 2000000;
            cena_label.Content = cena1 + polisa;
        }

        private void ferrari_radiobutton_Unchecked(object sender, RoutedEventArgs e)
        {
            cena1 -= 2000000;
            cena_label.Content = cena1 + polisa;
        }

        private void elektryczne_szyby_checkbox_Checked(object sender, RoutedEventArgs e)
        {
            cena1 += 200;
            cena_label.Content = cena1 + polisa;
        }

        private void podgrzewane_lusterks_checkbox_Checked(object sender, RoutedEventArgs e)
        {
            cena1 += 200;
            cena_label.Content = cena1 + polisa;
        }

        private void radio_checkbox_Checked(object sender, RoutedEventArgs e)
        {
            cena1 += 500;
            cena_label.Content = cena1 + polisa;
        }


        private void czujniki_checkbox_Checked(object sender, RoutedEventArgs e)
        {
            cena1 += 1000;
            cena_label.Content = cena1 + polisa;
        }

        private void klimatyzacja_checkbox_Checked(object sender, RoutedEventArgs e)
        {
            cena1 += 2000;
            cena_label.Content = cena1 + polisa;
        }

        private void elektryczne_szyby_checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            cena1 -= 200;
            cena_label.Content = cena1 + polisa;
        }
 

        private void podgrzewane_lusterks_checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            cena1 -= 200;
            cena_label.Content = cena1 + polisa;
        }


        private void radio_checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            cena1 -= 500;
            cena_label.Content = cena1 + polisa;
        }

        private void klimatyzacja_checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            cena1 -= 2000;
            cena_label.Content = cena1 + polisa;
        }

        private void czujniki_checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            cena1 -= 1000;
            cena_label.Content = cena1 + polisa;
        }

        private void polisa_textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if(!int.TryParse(polisa_textbox.Text, out polisa))
            {
                polisa = 0;
            }
            cena_label.Content = cena1 + polisa;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cena_label.Content = cena1 + polisa;
        }
    }
}
