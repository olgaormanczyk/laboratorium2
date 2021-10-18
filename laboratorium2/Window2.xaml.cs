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
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public int cena1 = 0;
        public Window2()
        {
            InitializeComponent();
        }

        private void moc_combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cena1 += 10000;
            cena_label.Content = cena1;
        }

        private void diesel_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            cena1 += 10000;
            cena_label.Content = cena1;
        }

        private void gaz_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            cena1 += 50000;
            cena_label.Content = cena1;
        }

        private void hybryda_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            cena1 += 90000;
            cena_label.Content = cena1;
        }

        private void hybryda_radiobutton_Unchecked(object sender, RoutedEventArgs e)
        {
            cena1 -= 90000;
            cena_label.Content = cena1;
        }

        private void gaz_radiobutton_Unchecked(object sender, RoutedEventArgs e)
        {
            cena1 -= 50000;
            cena_label.Content = cena1;
        }

        private void diesel_radiobutton_Unchecked(object sender, RoutedEventArgs e)
        {
            cena1 -= 10000;
            cena_label.Content = cena1;
        }

        private void benzyna_radiobutton_Unchecked(object sender, RoutedEventArgs e)
        {
            cena1 -= 30000;
            cena_label.Content = cena1;
        }

        private void benzyna_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            cena1 += 30000;
            cena_label.Content = cena1;
        }
    }
}
