﻿using System;
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
using WindSpareParts.Model;

namespace WindSpareParts
{
    /// <summary>
    /// Interaction logic for SearchProduct.xaml
    /// </summary>
    public partial class SearchProduct : Window
    {
        
        public SearchProduct()
        {
            InitializeComponent();

        }

        private void Searchbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            search.IsEnabled = true;

        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            SearchedProduct searchedProduct = new SearchedProduct();
            ProductRepository productRepository = new ProductRepository(searchedProduct);
            productRepository.ReadFromFile();
            productRepository.SearchProduct(Searchbox.Text);
            searchedProduct.Show();
            this.Close();


        }
                       
    }

}