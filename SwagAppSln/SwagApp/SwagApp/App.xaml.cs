using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwagApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new OrderedItemsPage());
            {
                //BarTextColor = Color.Black;
                //BarBackgroundColor = (Color)App.Current.Resources["white"];
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
