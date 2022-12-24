using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WatchWall
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Notice", "Your order has been Confirm", "OK");
        }
    }
}