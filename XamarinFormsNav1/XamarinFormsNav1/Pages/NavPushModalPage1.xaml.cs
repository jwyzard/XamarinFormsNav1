using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsNav1.Pages
{
    public partial class NavPushModalPage1 : ContentPage
    {
        public NavPushModalPage1()
        {
            InitializeComponent();
        }

        private void ButtonGoBack_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                DisplayAlert("Exception Received", ex.Message, "OK");
            }
        }

        private void ButtonNavToMainPage_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushModalAsync(new MainPage());
            }
            catch (Exception ex)
            {
                DisplayAlert("Exception Received", ex.Message, "OK");
            }
        }
    }
}
