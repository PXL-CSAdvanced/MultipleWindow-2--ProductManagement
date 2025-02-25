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

namespace ProductManagementApp
{
    /// <summary>
    /// Interaction logic for ProductToevoegen.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        public AddProductWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string id = idTextBox.Text;
            string name = nameTextBox.Text;
            
            if (!Decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Price could not be parsed to Decimal.");
                return;
            };
            
            if (!Int32.TryParse(stockTextBox.Text, out int stock))
            {
                MessageBox.Show("Stock could not be parsed to Decimal.");
                return;
            }

            if (stock < 0)
            {
                MessageBox.Show("Stock could not lower than 0");
                return;
            }

            if (price < 0)
            {
                MessageBox.Show("Price could not lower than 0");
                return;
            }

            Product product = new Product(id, name, price, stock);

            Data.Products.Add(product);

            this.DialogResult = true;
            this.Close();

        }
    }
}
