using Flyers_Motor_Sports.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("ProductSans-Regular.ttf", Alias = "ProductSansRegular")]
[assembly: ExportFont("ProductSans-Medium.ttf", Alias = "ProductSansMedium")]
[assembly: ExportFont("ProductSans-Light.ttf", Alias = "ProductSansLight")]
[assembly: ExportFont("ProductSans-Thin.ttf", Alias = "ProductSansThin")]

namespace Flyers_Motor_Sports
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            //MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
