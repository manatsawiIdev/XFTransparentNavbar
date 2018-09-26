using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

using Xamarin.Forms;
using XFTransparentNavbar.Views;
using XFTransparentNavbar.iOS.RenderersIOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomNavigation), typeof(CustomNavigationRenderer))]
namespace XFTransparentNavbar.iOS.RenderersIOS
{
    public class CustomNavigationRenderer : NavigationRenderer
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            UINavigationBar.Appearance.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);
            UINavigationBar.Appearance.ShadowImage = new UIImage();
            UINavigationBar.Appearance.BackgroundColor = UIColor.Clear;
            UINavigationBar.Appearance.TintColor = UIColor.White;
            UINavigationBar.Appearance.BarTintColor = UIColor.Clear;
            UINavigationBar.Appearance.Translucent = true;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }

            base.Dispose(disposing);
        }
    }
}