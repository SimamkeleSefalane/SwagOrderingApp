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

        async void Save_Clicked(object sender, EventArgs e)
        {
            var OrderedItems = (OrderedItems)BindingContext;
            OrderedItemsDatabase database = OrderedItemsDatabase.Instance;
            database.SaveOrder(OrderedItems);
            await Navigation.PopAsync();
        }

        async void Delete_Clicked(object sender, EventArgs e)
        {
            var OrderedItems = (OrderedItems)BindingContext;
            OrderedItemsDatabase database = OrderedItemsDatabase.Instance;
            database.SaveOrder(OrderedItems);
            await Navigation.PopAsync();
        }

        private async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}