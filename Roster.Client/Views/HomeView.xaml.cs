using Xamarin.Forms;

namespace Roster.Client.Views
{
    [System.ComponentModel.DesignTimeVisible(false)]
    public partial class HomeView : ContentPage
    {
        object v = new { Title = 108 };

        public HomeView()
        {
            InitializeComponent();
            BindingContext = v;
        }
    }
}