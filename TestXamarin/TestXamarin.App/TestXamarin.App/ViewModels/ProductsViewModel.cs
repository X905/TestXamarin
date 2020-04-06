using System;
using System.Collections.Generic;
using System.Text;

namespace TestXamarin.App.ViewModels
{
    using Services;
    using System.Collections.ObjectModel;
    using TestXamarin.App.Models;
    using Xamarin.Forms;

    public class ProductsViewModel : BaseViewModel
    {
        private readonly ApiServices apiService;
        private ObservableCollection<Product> products;
        private ObservableCollection<Category> categories;
        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }
        public ObservableCollection<Category> Categories
        {
            get { return this.categories; }
            set { this.SetValue(ref this.categories, value); }
        }

        public ProductsViewModel()
        {

            this.apiService = new ApiServices();
            this.LoadProducts();
        }

       

        private async void LoadProducts()
        {
            List<Category> categories = new List<Category>();
            Color[] c = { Color.FromHex("#ffcc06"), Color.FromHex("#2148ae"), 
                Color.FromHex("#f5260c"), Color.FromHex("#0ec076")
                ,Color.FromHex("#256f9e"), Color.FromHex("#0ac7d6"), 
                Color.FromHex("#fc7b00"), Color.FromHex("#145a5c"), Color.FromHex("#8bd21d") };
            Random rand = new Random();

            var response = await this.apiService.GetListAsync<Product>(
                "http://castangel-001-site1.etempurl.com",
                "/api",
                "/Products");

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept"
                    );
                return;
            }

            var myProducts = (List<Product>)response.Result;

            foreach (var product in myProducts)
            {

                if (!categories.Exists(x=>x.Id == product.Category.Id))
                {
                    product.Category.ButtonBackGroundColor =  c[rand.Next(0, c.Length)];
                    categories.Add(product.Category);
                }
                

            }

            categories.Add(new Category
            {
                NameCategory = "All",
                ButtonBackGroundColor = Color.Black,
                Id = 0
            });

            this.Categories = new ObservableCollection<Category>(categories);
            this.Products = new ObservableCollection<Product>(myProducts);
        }
    }
}
