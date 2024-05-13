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
using WindSpareParts.View.Clients;
using WindSpareParts.View.Discounts;
using WindSpareParts.View.Products;

namespace WindSpareParts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }

        private void OpretTilbud_Click(object sender, RoutedEventArgs e)
        {
            // Instantiate the CreateDiscount window
            CreateDiscount createDiscount = new CreateDiscount();

            // Shows the desired window
            createDiscount.Show();

            // Closes the current window (MainWindow)
            this.Close();
        }

        private void FjernTilbud_Click(object sender, RoutedEventArgs e)
        {
            RemoveDiscount removeDiscount= new RemoveDiscount();
            removeDiscount.Show();
            this.Close();
        }

        private void KundeTilbud_Click(object sender, RoutedEventArgs e)
        {
            ClientDiscont clientDiscount = new ClientDiscont();
            clientDiscount.Show();
            this.Close();
        }

        private void OpretProdukt_Click(object sender, RoutedEventArgs e)
        {
            
            SearchProduct searchProduct = new SearchProduct();
            searchProduct.Show();
            this.Close();
        }

        private void FjernProdukter_Click(object sender, RoutedEventArgs e)
        {
            RemoveProducts removeProducts = new RemoveProducts();
            removeProducts.Show();
            this.Close();
        }

        private void VisProdukter_Click(object sender, RoutedEventArgs e)
        {
            ViewProducts viewProducts = new ViewProducts();
            viewProducts.Show();
            this.Close();
        }

        private void OpretKunde_Click(object sender, RoutedEventArgs e)
        {
            CreateClient createClient = new CreateClient();
            createClient.Show();
            this.Close();
        }

        private void KundeOverblik_Click(object sender, RoutedEventArgs e)
        {
            ClientOverview clientOverview = new ClientOverview();
            clientOverview.Show();
            this.Close();
        }
        private void RedigerKunde_Click(object sender, RoutedEventArgs e)
        {
            EditClients editClients = new EditClients();
            editClients.Show();
            this.Close();
        }
        
    }
}