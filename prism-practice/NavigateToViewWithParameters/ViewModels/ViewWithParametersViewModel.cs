using Prism.Mvvm;
using Prism.Regions;

namespace NavigateToViewWithParameters.ViewModels
{
    public class ViewWithParametersViewModel : BindableBase, INavigationAware
    {
        public ViewWithParametersViewModel()
        {

        }

        private string _parameterText = string.Empty;
        public string ParameterText
        {
            get { return _parameterText; }
            set { SetProperty(ref _parameterText, value); }
        }


        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            ParameterText = navigationContext.Parameters.GetValue<string>(nameof(ParameterText));
        }
    }
}
