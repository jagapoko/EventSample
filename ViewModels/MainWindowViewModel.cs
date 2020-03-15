using Prism.Mvvm;
using Prism.Regions;

namespace EventSample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager rm)
        {
            rm.RegisterViewWithRegion("CodeBehind", typeof(Views.CodeBehind));
            rm.RegisterViewWithRegion("Prism", typeof(Views.Prism));
            rm.RegisterViewWithRegion("ReactiveProperty", typeof(Views.ReactiveProperty));
        }
    }
}
