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

namespace laboratorium2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int cena = 0;
        public MainWindow()
        {
            InitializeComponent();
            cena_label.Content = this.cena;
        }

        private void marka_button_Click(object sender, RoutedEventArgs e)
        {
            Window1 okno1 = new Window1();
            okno1.Show();
        }

        private void silnik_button_Click(object sender, RoutedEventArgs e)
        {
            Window1 okno2 = new Window1();
            okno2.Show();
        }
    }
}
