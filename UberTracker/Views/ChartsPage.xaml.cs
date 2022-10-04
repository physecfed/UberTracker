using System;

using UberTracker.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UberTracker.Views
{
    public sealed partial class ChartsPage : Page
    {
        public ChartsViewModel ViewModel { get; } = new ChartsViewModel();

        public ChartsPage()
        {
            InitializeComponent();
        }
    }
}
