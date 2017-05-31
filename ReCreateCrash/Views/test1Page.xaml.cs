using ReCreateCrash.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ReCreateCrash.Views
{
    public sealed partial class test1Page : Page
    {
        public test1ViewModel ViewModel { get; } = new test1ViewModel();
        public test1Page()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(WindowStates.CurrentState);
        }
    }
}
