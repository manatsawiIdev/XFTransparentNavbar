using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using AView = Android.Views.View;
using XFTransparentNavbar.Views;
using XFTransparentNavbar.Droid.RenderersAndroid;
using Xamarin.Forms.Platform.Android.AppCompat;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomNavigation), typeof(CustomNavigationRenderer))]
namespace XFTransparentNavbar.Droid.RenderersAndroid
{
    public class CustomNavigationRenderer : NavigationPageRenderer
    {
        public CustomNavigationRenderer(Context context) : base(context)
        {

        }

        IPageController PageController => Element as IPageController;
        CustomNavigation CustomNavigationPage => Element as CustomNavigation;

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            CustomNavigationPage.IgnoreLayoutChange = true;
            base.OnLayout(changed, l, t, r, b);
            CustomNavigationPage.IgnoreLayoutChange = false;

            int containerHeight = b - t;

            PageController.ContainerArea = new Rectangle(0, 0, Context.FromPixels(r - l), Context.FromPixels(containerHeight));

            for (var i = 0; i < ChildCount; i++)
            {
                AView child = GetChildAt(i);

                if (child is Android.Support.V7.Widget.Toolbar)
                {
                    continue;
                }

                child.Layout(0, 0, r, b);
            }
        }
    }
}