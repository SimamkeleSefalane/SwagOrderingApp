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
    public partial class BrowsePage : ContentPage
    {
        public BrowsePage()
        {
            InitializeComponent();
        }

        private void View_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ItemsList());
        }

        private void History_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ItemsList());
        }
    }
   

}