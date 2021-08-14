using Roster.Client.ViewModels;
using Xamarin.Forms;

namespace Roster.Client.Views
{
    [System.ComponentModel.DesignTimeVisible(false)]
    public partial class HomeView : ContentPage
    {
        #region Constructor
        public HomeView()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }
        #endregion

        #region Private Methods

        #endregion

        #region Public Methods

        #endregion
    }
}