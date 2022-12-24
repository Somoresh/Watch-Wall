using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace WatchWall.ViewModel
{
   public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            Products = GetProducts();
            MenuList = GetMenus();
        }

        private Product selectedProduct;
        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set { selectedProduct = value; }
            
        }
        
        
        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        private ObservableCollection<Menu> menuList;

        public ObservableCollection<Menu> MenuList
        {
            get { return menuList; }
            set { menuList = value; }
        }

        public void ShowDetails()
        {
            var page = new DetailsPage() { BindingContext = new DetailsViewModel { SelectedProduct = SelectedProduct } };
            App.Current.MainPage.Navigation.PushAsync(page);
        }

        private ObservableCollection<Menu> GetMenus()
        {
            return new ObservableCollection<Menu>
            {
                new Menu { Icon ="order.png", Name="My Order"},
                new Menu { Icon ="favourite.png", Name="My Wishlist"},
                new Menu { Icon ="cart.png", Name="Shopping Cart"},
                new Menu { Icon ="setting.png", Name="Settings"}
            };
        }

        public ObservableCollection<Product> GetProducts()
        {
            return new ObservableCollection<Product>
            {
                new Product {Name ="Classic", Price=780.00f, Image="curren.png", Model="Model 2020",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout." },
                new Product {Name ="Noise", Price=880.00f, Image="noise.png", Model="Model 2021",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
                new Product {Name ="Tissot", Price=580.00f, Image="tissot.png", Model="Model 2022",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
                new Product {Name ="OnePlus", Price=620.00f, Image="oneplus.png", Model="Model 2022",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
                new Product {Name ="Casio Classic", Price=280.00f, Image="casioClassic.png", Model="Model 2007",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
                new Product {Name ="Bulova", Price=980.00f, Image="bulovaClassic.png", Model="Model 2019",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
                new Product {Name ="Galaxy 4", Price=780.00f, Image="galaxy.png", Model="Model 2022",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
                new Product {Name ="Leather", Price=580.00f, Image="leather.png", Model="Model 2021",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
                new Product {Name ="Glaxy 4 White", Price=790.00f, Image="galaxy4.png", Model="Model 2022",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
                new Product {Name ="Curren", Price=780.00f, Image="curren.png", Model="Model 2020",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
                new Product {Name ="Classic", Price=780.00f, Image="curren.png", Model="Model 2020",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout." },
                new Product {Name ="Noise", Price=880.00f, Image="noise.png", Model="Model 2021",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
                new Product {Name ="Tissot", Price=580.00f, Image="tissot.png", Model="Model 2022",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
                new Product {Name ="OnePlus", Price=620.00f, Image="oneplus.png", Model="Model 2022",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
                new Product {Name ="Casio Classic", Price=280.00f, Image="casioClassic.png", Model="Model 2007",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
                new Product {Name ="Bulova", Price=980.00f, Image="bulovaClassic.png", Model="Model 2019"},
                new Product {Name ="Galaxy 4", Price=780.00f, Image="galaxy.png", Model="Model 2022"},
                new Product {Name ="Leather", Price=580.00f, Image="leather.png", Model="Model 2021"},
                new Product {Name ="Glaxy 4 White", Price=790.00f, Image="galaxy4.png", Model="Model 2022"},
                new Product {Name ="Curren", Price=780.00f, Image="curren.png", Model="Model 2020"}

            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name ="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
        public string Model { get; set; }
        public string Rating { get; set; }
        public string Views { get; set; }
        public string Description { get; set; }
    }

    public class Menu
    {
        public string Name { get; set; }
        public string Icon { get; set; }
    }
}
