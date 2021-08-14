using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Roster.Client.Models;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _title = AppResource.AppNameVersion1;
        public string Title
        {
            get => _title;
            set {
                _title = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Title)));
            }            
        }

        public ObservableCollection<Person> People { get; set; }

        public Command UpdateApplicationCommand { get; set; }

        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(UpdateApplicationCommandExecute);
            People = new ObservableCollection<Person>();
            People.Add(new Person() { Name="Delores Feil", Company= "Legros Group"});
            People.Add(new Person() { Name = "Ann Zboncak", Company = "Ledner - Ferry" });
            People.Add(new Person() { Name = "Jaime Lesch", Company = "Herzog and Sons" });

        }

        private void UpdateApplicationCommandExecute()
        {
            Title = AppResource.AppNameVersion2;
        }
    }
}
