using Flyers_Motor_Sports.DatabaseTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Flyers_Motor_Sports.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateJobPage : ContentPage
    {
        IRepository repository = new InmemoryRepository();
        public CreateJobPage()
        {
            InitializeComponent();

        }

        private async void SaveJob_Clicked(object sender, EventArgs e)
        {
            bool isvehicleNumber = !String.IsNullOrEmpty(vehicleNumberField.Text);
            bool isvehicleModel = !String.IsNullOrEmpty(vehicleModelField.Text);
            bool issubmittedBy = !String.IsNullOrEmpty(submittedBy.Text);
            if (isvehicleNumber && isvehicleModel && issubmittedBy)
            {
                var newRecord = new Job()
                {
                    VehicleNumber = vehicleModelField.Text,
                    VehicleModel = vehicleModelField.Text,
                    SubmittedBy = submittedBy.Text,
                    StartDate = DateTime.Now,
                };
                repository.CreateJob(newRecord);
            }

            await Navigation.PushAsync(new MainPage());
        }
    }
}