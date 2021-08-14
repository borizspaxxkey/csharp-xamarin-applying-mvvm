using Xamarin.Forms;

namespace Roster.Client.Views
{
    [System.ComponentModel.DesignTimeVisible(false)]
    public partial class HomeView : ContentPage
    {
        object v = new { Title = "Roster App" };

        public HomeView()
        {
            InitializeComponent();
            BindingContext = v;
        }
    }
}