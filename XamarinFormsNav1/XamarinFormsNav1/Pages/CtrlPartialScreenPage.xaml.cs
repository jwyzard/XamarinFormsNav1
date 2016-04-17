using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsNav1.Pages
{
    public partial class CtrlPartialScreenPage : ContentPage
    {
        private ContentView _CurrentView = null;

        public CtrlPartialScreenPage()
        {
            InitializeComponent();

            SwitchScreens(new Controls.PartialScreen1Ctrl());
        }

        private void SwitchScreens(ContentView cView)
        {
            if (_CurrentView != null)
            {
                GridMain.Children.Remove(_CurrentView);
                _CurrentView = null;
            }

            _CurrentView = cView;
            Grid.SetColumn(_CurrentView, 0);
            Grid.SetRow(_CurrentView, 0);
            GridMain.Children.Add(_CurrentView);
        }

        private void ButtonScreen1_Clicked(object sender, EventArgs e)
        {
            try
            {
                SwitchScreens(new Controls.PartialScreen1Ctrl());
            }
            catch (Exception ex)
            {
                DisplayAlert("Exception Received", ex.Message, "OK");
            }
        }

        private void ButtonScreen2_Clicked(object sender, EventArgs e)
        {
            try
            {
                SwitchScreens(new Controls.PartialScreen2Ctrl());
            }
            catch (Exception ex)
            {
                DisplayAlert("Exception Received", ex.Message, "OK");
            }
        }

        private void ButtonReturn_Clicked(object sender, EventArgs e)
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
    }
}
