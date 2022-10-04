using System;

using UberTracker.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UberTracker.Views
{
    public sealed partial class MiscellaneousPage : Page
    {
        public MiscellaneousViewModel ViewModel { get; } = new MiscellaneousViewModel();

        public MiscellaneousPage()
        {
            InitializeComponent();
        }
    }
}
