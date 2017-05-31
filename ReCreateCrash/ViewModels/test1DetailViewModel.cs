using System;
using System.Windows.Input;

using ReCreateCrash.Helpers;
using ReCreateCrash.Models;
using ReCreateCrash.Services;

using Windows.UI.Xaml;

namespace ReCreateCrash.ViewModels
{
    public class test1DetailViewModel : Observable
    {
        const string NarrowStateName = "NarrowState";
        const string WideStateName = "WideState";

        public ICommand StateChangedCommand { get; private set; }

        private SampleModel _item;
        public SampleModel Item
        {
            get { return _item; }
            set { Set(ref _item, value); }
        }

        public test1DetailViewModel()
        {
            StateChangedCommand = new RelayCommand<VisualStateChangedEventArgs>(OnStateChanged);
        }
        
        private void OnStateChanged(VisualStateChangedEventArgs args)
        {
            if (args.OldState.Name == NarrowStateName && args.NewState.Name == WideStateName)
            {
                NavigationService.GoBack();
            }
        }
    }
}
