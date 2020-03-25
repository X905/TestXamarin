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
        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }

        public ProductsViewModel()
        {

            this.apiService = new ApiServices();
            this.LoadProducts();
        }


        private async void LoadProducts()
        {
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
            this.Products = new ObservableCollection<Product>(myProducts);
        }
    }
}
