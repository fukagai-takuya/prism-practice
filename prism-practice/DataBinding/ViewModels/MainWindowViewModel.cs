using Prism.Commands;
using Prism.Mvvm;

namespace DataBinding.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism DataBinding";
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

        public MainWindowViewModel()
        {
            DateTimeUpdateButton = new DelegateCommand(DateTimeUpdateButtonExecute);
        }

        private void DateTimeUpdateButtonExecute()
        {
            DateTimeLabel = System.DateTime.Now.ToString();
        }
    }
}
