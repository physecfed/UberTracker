using System;

using UberTracker.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UberTracker.Views
{
    public sealed partial class WeeklySummaryPage : Page
    {
        public WeeklySummaryViewModel ViewModel { get; } = new WeeklySummaryViewModel();

        public WeeklySummaryPage()
        {
            InitializeComponent();
        }
    }
}
