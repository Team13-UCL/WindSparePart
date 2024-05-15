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
        List<List<string>> products = new List<List<string>>(); // Opretter en liste til at gemme dataene fra CSV-filen
        
        public void CreateProduct(Product product)
        {
            //products.Add(product); //det nye produkt tilføjes til listen products
        }

        public void DeleteProduct(Product product)
        {
            //products.Remove(product); //sletter et produkt fra listen products
        }


        public List<List<string>> ReadFromFile()
        {
            // super smart, den går 3 mappetrin op og ind i Model-mappen og finder csv-filen
            string path = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\Model", "inFlow_ProductDetails.csv");


            string[] lines = File.ReadAllLines(path); // Læser alle linjer fra CSV-filen og gemmer dem i et array af strenge

            foreach (string line in lines) //Itererer gennem hver linje i CSV-filen
            {
                // Opdeler den aktuelle linje ved kommaet og gemmer resultaterne i en liste af strenge
                List<string> columns = line.Split(',').ToList();
                products.Add(columns); // Tilføjer den liste af kolonner til hovedlisten af datas
            }
            return products;
        }

        public List<string> SearchProduct(string searchWord)
        {
            List<string> searchResults = new List<string>();


            searchWord = searchWord.ToLower(); // Convert search word to lower case
            foreach (List<string> line in products) // Iterate through each line in the data
            {
                foreach (var item in line) // Iterate through each column in the line
                {
                    if (item.ToLower().Contains(searchWord)) // If the column contains the search word
                    {
                        searchResults.Add(string.Join(",", line)); // Add the column to the results
                    }

                }
            }
            if (searchResults.Count == 0) // hvis ingen resultater er fundet
            {
                searchResults.Add("Produktet findes ikke");
            }
            return searchResults;
        }

        public void SaveToFile(string searchText)
        {

            // super smart, den går 3 mappetrin op og ind i Model-mappen og finder csv-filen
            string path = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\Model", "oprettedeprodukter.csv");

            using (StreamWriter sw = new StreamWriter(path, true)) //true for at tilføje til filen og ikke overskrive
            {
                sw.WriteLine(searchText);
            }

        }

    }
}
