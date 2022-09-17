using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using NavigateToViewWithParameters.Views;

namespace NavigateToViewWithParameters.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        private string _title = "Prism NavigateToViewWithParameters";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _dateTimeText = System.DateTime.Now.ToString();
        public string DateTimeText
        {
            get { return _dateTimeText; }
            set { SetProperty(ref _dateTimeText, value); }
        }

        public DelegateCommand DateTimeUpdateButton { get; }
        public DelegateCommand ShowHugeLabelButton { get; }
        public DelegateCommand ShowViewWithParametersButton { get; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            DateTimeUpdateButton = new DelegateCommand(DateTimeUpdateButtonExecute);
            ShowHugeLabelButton = new DelegateCommand(ShowHugeLabelButtonExecute);
            ShowViewWithParametersButton = new DelegateCommand(ShowViewWithParametersButtonExecute);
            _regionManager = regionManager;
        }

        private void DateTimeUpdateButtonExecute()
        {
            DateTimeText = System.DateTime.Now.ToString();
        }

        private void ShowHugeLabelButtonExecute()
        {
            _regionManager.RequestNavigate("ContentRegion", nameof(HugeLabelView));
        }

        private void ShowViewWithParametersButtonExecute()
        {
            var parameters = new NavigationParameters();
            parameters.Add(nameof(ViewWithParametersViewModel.ParameterText), DateTimeText);
            _regionManager.RequestNavigate("ContentRegion", nameof(ViewWithParametersView), parameters);
        }
    }
}
