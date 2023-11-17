using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Lab1
{
    /// <summary>
    /// Логика взаимодействия для Inheritance.xaml
    /// </summary>
    public partial class Inheritance : Window
    {
        public Inheritance()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var table = new Table(name.Text, Convert.ToInt32(S.Text));
            var wrtable = new WritingTable(material.Text, name.Text, Convert.ToInt32(S2.Text));

            C.Content = Math.Round(table.C(), 2);
            Proc.Content = Math.Round(wrtable.Proc(), 2);
            C2.Content = Math.Round(wrtable.C(), 2);
            Full.Content = Math.Round(wrtable.Full(), 2);
        }
    }
}
