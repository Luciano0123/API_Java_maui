using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;


namespace study.ViewModels
{
    public partial class MonitorViewModels : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Models.Monitor> monitores;

        public MonitorViewModels() {

            getMonitoresCommand = new Command(getMonitores);
            getMonitoresCommand.Execute(this);
        
        }

        private ICommand getMonitoresCommand { get; }

        public async void getMonitores()
        {
            monitores = await new Service.MonitorService().getAllMonitorsAsync();
        }
    }
}
