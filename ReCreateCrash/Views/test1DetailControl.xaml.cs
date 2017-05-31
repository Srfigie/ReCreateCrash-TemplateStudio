using ReCreateCrash.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ReCreateCrash.Views
{
    public sealed partial class test1DetailControl : UserControl
    {
        public SampleModel MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleModel; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem",typeof(SampleModel),typeof(test1DetailControl),new PropertyMetadata(null));

        public test1DetailControl()
        {
            InitializeComponent();
        }
    }
}
