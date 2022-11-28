using Flyers_Motor_Sports.DatabaseTable;
using Flyers_Motor_Sports.View;
using Flyers_Motor_Sports.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Flyers_Motor_Sports
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel mainPageViewModel;

        public string Vehicle_Number { get; set; }
        public string Submitted_By { get; set; }

        ObservableCollection<MainPage> listofJobs { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            mainPageViewModel = new MainPageViewModel();

            if (mainPageViewModel.DepartmentCollection != null)
            {
                //department.ItemsSource = mainPageViewModel.DepartmentCollection.ToList();
            }
        }

        private async void SubmitButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JobPage());
        }

        private void department_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            var selectedDepartment = (Department)picker.SelectedItem;
            if(selectedDepartment != null)
            {
                //employees.ItemsSource = selectedDepartment.Employees;
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateJobPage());
        }

        private void MockDataForMainPage()
        {
        }
    }
}
