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

namespace Sliyanie_Vetok
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            string ch1 = textBoxChisl.Text.Replace('.', ','); //замена . на ,
            string ch2 = textBoxChisl2.Text.Replace('.', ',');
            if ((textBoxChisl.Text == "")||(textBoxChisl2.Text==""))
            {
                Rez.Content = "Введите оба значения!";
                return;
            }

            Rez.Content = Convert.ToDouble(ch1) + Convert.ToDouble(ch2);
        }
    }
}
