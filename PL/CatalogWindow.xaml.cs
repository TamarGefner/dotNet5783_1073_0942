﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using BlApi;
using BO;

namespace PL
{
    /// <summary>
    /// Interaction logic for CatalogWindow.xaml
    /// </summary>
    public partial class CatalogWindow : Window
    {
        private static readonly IBl bl = BlApi.Factory.Get();
       

        public CatalogWindow(BO.Cart cart)
        {
            InitializeComponent();
            catalogListView.ItemsSource = bl.Product.GetProductItems(cart);
        }
           
      
        

        

        
    }
}
