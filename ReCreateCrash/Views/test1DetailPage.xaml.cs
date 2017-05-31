using ReCreateCrash.Models;
using ReCreateCrash.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace ReCreateCrash.Views
{
    public sealed partial class test1DetailPage : Page
    {
        public test1DetailViewModel ViewModel { get; } = new test1DetailViewModel();
        public test1DetailPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ViewModel.Item = e.Parameter as SampleModel;
        }
    }
}
