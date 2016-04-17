using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsNav1.Pages
{
    public partial class CtrlFullScreenPage : ContentPage
    {
        public static ContentPage CurrentPage { get; set; }

        public CtrlFullScreenPage()
        {
            InitializeComponent();

            CurrentPage = this;

            this.Content = new Controls.Screen1Ctrl();
        }
    }
}
