using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinApp_crossplatform
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageHistory : ContentPage
	{
		public PageHistory ()
		{
			InitializeComponent ();
		}

        private void ClickedButtonBack(object sender, EventArgs e)
        {
            
        }

        protected override bool OnBackButtonPressed()
        {
            Application.Current.MainPage = new MasterDetailNavigation();
            return true; // base.OnBackButtonPressed();
        }

    }
}