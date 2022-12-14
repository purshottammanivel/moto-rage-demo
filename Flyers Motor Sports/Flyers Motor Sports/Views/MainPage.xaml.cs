using Flyers_Motor_Sports.DatabaseTable;
using Flyers_Motor_Sports.ViewModel;
using Flyers_Motor_Sports.Views;
using System;
using Xamarin.Forms;

namespace Flyers_Motor_Sports
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel mainPageViewModel;
        IRepository repository = new InmemoryRepository();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void CreateJob_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateJobPage());
        }

        private async void CreateCheckList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateJobPage());
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new EditJobPage());
        }
    }
}
