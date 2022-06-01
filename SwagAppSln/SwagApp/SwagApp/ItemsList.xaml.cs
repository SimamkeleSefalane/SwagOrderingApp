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
    public partial class ItemsList : ContentPage
    {
        public ItemsList()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            OrderedItemsDatabase database = OrderedItemsDatabase.Instance;
            listView.ItemsSource = database.GetOrderItems();
        }
        private async void AddOrder_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderedItemsPage
            {
                BindingContext = new OrderedItems()
            });
        }

        async void ItemsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new OrderedItemsPage
                {
                    BindingContext = e.SelectedItem as OrderedItems

                });

            }

        }

        
    }
}