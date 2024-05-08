using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;


namespace WindSpareParts.Model
{
    public class ProductRepository
    {
        private List<Product> products; // liste til at gemme produkterne
        List<List<string>> datas = new List<List<string>>(); // Opretter en liste til at gemme dataene fra CSV-filen
        SearchedProduct searchedProduct = new SearchedProduct(); // Opretter et nyt objekt af klassen SearchedProduct

        

        public ProductRepository(SearchedProduct searchedProduct)
        {
            this.searchedProduct = searchedProduct; // Sætter det nye objekt af klassen SearchedProduct til at være det objekt, der er blevet sendt med som parameter
            products = new List<Product>(); //initialisering af produktlisten
        }

        public void CreateProduct(Product product)
        {
            products.Add(product); //det nye produkt tilføjes til listen products
        }

        public void DeleteProduct(Product product)
        {
            products.Remove(product); //sletter et produkt fra listen products
        }

        
        public List<List<string>> ReadFromFile()
        {
            string path = "C:\\Users\\nbjer\\source\\repos\\Team13-UCL\\WindSparePart\\WindSpareParts\\WindSpareParts\\Model\\inFlow_ProductDetails.csv";

            
            string[] lines = File.ReadAllLines(path); // Læser alle linjer fra CSV-filen og gemmer dem i et array af strenge

            foreach (string line in lines) //Itererer gennem hver linje i CSV-filen
            {
                // Opdeler den aktuelle linje ved kommaet og gemmer resultaterne i en liste af strenge
                List<string> columns = line.Split(',').ToList();
                datas.Add(columns); // Tilføjer den liste af kolonner til hovedlisten af data
            }
            return datas;
        }

        public void SearchProduct(string searchText)  
        {
            string searchWord = searchText.ToLower(); // Converter søgeordet til små bogstaver
            foreach (List<string> line in datas) // Itererer gennem hver linje i dataene
            {
                foreach (var item in line) // Itererer gennem hver kolonne i linjen
                {
                    if (item.ToLower().Contains(searchWord)) // Hvis kolonnen indeholder søgeordet
                    {
                        this.searchedProduct.Results.Text += string.Join(",", line) + "\n"; // Tilføj kolonnen til resultaterne
                        
                    }
                }
            }
            
        }
    }
}
