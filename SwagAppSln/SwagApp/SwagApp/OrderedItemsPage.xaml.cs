using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwagApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderedItemsPage : ContentPage
    {

        public OrderedItemsPage()
        {
            InitializeComponent();
        }

       private async void Save_Clicked(object sender, EventArgs e)
        {
            var orders = (OrderedItems)BindingContext;
            OrderedItemsDatabase database = OrderedItemsDatabase.Instance;
            database.SaveOrder(orders);
            await Navigation.PopAsync();
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            var orders = (OrderedItems)BindingContext;
            OrderedItemsDatabase database = OrderedItemsDatabase.Instance;
            database.SaveOrder(orders);
            await Navigation.PopAsync();
        }

        private async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}