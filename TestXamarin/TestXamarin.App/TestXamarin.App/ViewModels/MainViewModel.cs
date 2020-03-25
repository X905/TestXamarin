using System;
using System.Collections.Generic;
using System.Text;

namespace TestXamarin.App.ViewModels
{
    public class MainViewModel
    {
        private static MainViewModel instance;

        public ProductsViewModel Products { get; set; }

        public MainViewModel()
        {
            instance = this;
        }
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();

            }
            return instance;
        }
    }
}
