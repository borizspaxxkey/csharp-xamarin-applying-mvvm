using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel: INotifyPropertyChanged
    {
        private string title;
        public string Title
        {
            get { return AppResource.AppNameVersion1; }
            set { title = value; NotifyPropertyChanged(); }            
        } 

        #region Command
        public ICommand UpdateApplicationCommand { get; private set; }
        #endregion

        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(() => Title = AppResource.AppNameVersion2);
                       
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
