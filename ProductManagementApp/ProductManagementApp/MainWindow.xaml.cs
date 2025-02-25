using System.Windows;

namespace ProductManagementApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RefreshDataSource();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow addProductDialog = new AddProductWindow();
            bool? isDialogSucceeded = addProductDialog.ShowDialog();
            if (isDialogSucceeded.Value)
            {
                RefreshDataSource();
            }

            addProductDialog.Close();
        }

        public void RefreshDataSource()
        {
            productsListBox.ItemsSource = null;
            productsListBox.ItemsSource = Data.Products;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            Product selectedProduct = productsListBox.SelectedItem as Product;
            Data.Products.Remove(selectedProduct);
            RefreshDataSource();
        }
    }
}