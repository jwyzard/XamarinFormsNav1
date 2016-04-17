using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsNav1.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            try
            {
                if (Navigation.NavigationStack != null)
                    LabelNavStackCount.Text = Navigation.NavigationStack.Count.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Exception Received", ex.Message, "OK");
            }

            try
            {
                if (Navigation.ModalStack != null)
                    LabelModalStackCount.Text = Navigation.ModalStack.Count.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Exception Received", ex.Message, "OK");
            }
        }

        private void ButtonNavPush_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new NavPushPage1());
            }
            catch (Exception ex)
            {
                DisplayAlert("Exception Received", ex.Message, "OK");
            }
        }

        private void ButtonNavPushModal_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushModalAsync(new NavPushModalPage1());
            }
            catch (Exception ex)
            {
                DisplayAlert("Exception Received", ex.Message, "OK");
            }
        }

        private void ButtonCtrlFullScreen_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushModalAsync(new CtrlFullScreenPage());
            }
            catch (Exception ex)
            {
                DisplayAlert("Exception Received", ex.Message, "OK");
            }
        }

        private void ButtonCtrlFullScreenUsingXaml_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushModalAsync(new CtrlFullScreenUsingXamlPage());
            }
            catch (Exception ex)
            {
                DisplayAlert("Exception Received", ex.Message, "OK");
            }
        }

        private void ButtonCtrlPartialScreen_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushModalAsync(new CtrlPartialScreenPage());
            }
            catch (Exception ex)
            {
                DisplayAlert("Exception Received", ex.Message, "OK");
            }
        }
    }
}
