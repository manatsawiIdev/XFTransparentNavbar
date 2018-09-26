using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFTransparentNavbar.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TransparentNavbarView : ContentPage
	{
		public TransparentNavbarView ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new TestNavbarView());
        }
    }
}