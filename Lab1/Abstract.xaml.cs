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

namespace Lab1
{
    /// <summary>
    /// Логика взаимодействия для Abstract.xaml
    /// </summary>
    public partial class Abstract : Window
    {
        public Abstract()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var n = Convert.ToInt32(N.Text);
            var a = new Clothes[n * 2];

            for (int i = 0; i < a.Length; i = i + 2) 
            {
                a[i] = new Coat(i + 100);
                a[i + 1] = new Suit(i + 100);
            }

            var result = 0.0;
            listBox.Items.Clear();

            for (int i = 0; i < a.Length; i++) 
            {
                listBox.Items.Add(a[i].Show()+ " Витрати = " + a[i].Expenses().ToString());

                result += a[i].Expenses();
            }

            Result.Content = result.ToString();
        }
    }
}
