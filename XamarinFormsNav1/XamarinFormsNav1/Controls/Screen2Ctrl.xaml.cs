using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsNav1.Controls
{
    public partial class Screen2Ctrl : ContentView
    {
        public Screen2Ctrl()
        {
            InitializeComponent();
        }

        private void ButtonReturn_Clicked(object sender, EventArgs e)
        {
            try
            {
                Pages.CtrlFullScreenPage.CurrentPage.Content = new Screen1Ctrl();
            }
            catch (Exception ex)
            {
                //DisplayAlert("Exception Received", ex.Message, "OK");
            }
        }
    }
}
