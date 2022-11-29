using Flyers_Motor_Sports.DatabaseTable;
using Xamarin.Forms.Xaml;

namespace Flyers_Motor_Sports.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile), XamlFilePath("Views\\CreateJobPage.xaml")]
    public class CreateJobPageBase
    {
        IRepository repository = new InmemoryRepository();
    }
}