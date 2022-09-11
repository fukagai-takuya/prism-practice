using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using UserControlView.Views;

namespace UserControlView.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        private string _title = "Prism UserControlView";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _dateTimeLabel = System.DateTime.Now.ToString();
        public string DateTimeLabel
        {
            get { return _dateTimeLabel; }
            set { SetProperty(ref _dateTimeLabel, value); }
        }

        public DelegateCommand DateTimeUpdateButton { get; }
        public DelegateCommand ShowHugeLabelButton { get; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            DateTimeUpdateButton = new DelegateCommand(DateTimeUpdateButtonExecute);
            ShowHugeLabelButton = new DelegateCommand(ShowHugeLabelButtonExecute);
            _regionManager = regionManager;
        }

        private void DateTimeUpdateButtonExecute()
        {
            DateTimeLabel = System.DateTime.Now.ToString();
        }

        private void ShowHugeLabelButtonExecute()
        {
            _regionManager.RequestNavigate("ContentRegion", nameof(HugeLabelView));
        }
    }
}
