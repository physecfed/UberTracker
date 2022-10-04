using System;

using UberTracker.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UberTracker.Views
{
    public sealed partial class MileagePage : Page
    {
        public MileageViewModel ViewModel { get; } = new MileageViewModel();

        public MileagePage()
        {
            InitializeComponent();
        }
    }
}
