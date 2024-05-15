using System;
using System.Collections.Generic;
using System.DirectoryServices;
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
using WindSpareParts.Model;

namespace WindSpareParts
{
    /// <summary>
    /// Interaction logic for SearchProduct.xaml
    /// </summary>
    public partial class SearchProduct : Window
    {
        ProductRepository productRepository = new ProductRepository(); // opretter et nyt produkt
        public SearchProduct()
        {
            InitializeComponent();

        }

        private void search_Click(object sender, RoutedEventArgs e)
        {

            this.CreateProduct.IsEnabled = false;
            productRepository.ReadFromFile();
            productRepository.SearchProduct(Searchbox.Text); // søgning efter produkt
            List<string> searchResults = productRepository.SearchProduct(Searchbox.Text);

            Searchbox.Text = ""; // clear the list box before adding new items
            foreach (string item in searchResults)
            {
                Searchbox.Text += item + "\n"; // add each search result to the list box
            }
        }

        private void CreateProduct_Click(object sender, RoutedEventArgs e)
        {
            productRepository.SaveToFile(Searchbox.Text);
            Searchbox.Text = "Produktet er gemt \nTilføj et produkt eller søg efter nyt produkt"; // clear boxen
            CreateProduct.IsEnabled = false;

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            CreateProduct.IsEnabled = false;
            Searchbox.Text = "Søg eller opret produkt"; // clear boxen
        }

        private void Searchbox_KeyDown(object sender, KeyEventArgs e)
        {
            CreateProduct.IsEnabled = true;
        }
    }

}
