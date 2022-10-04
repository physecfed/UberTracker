using System;

using UberTracker.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UberTracker.Views
{
    public sealed partial class DailySummaryPage : Page
    {
        public DailySummaryViewModel ViewModel { get; } = new DailySummaryViewModel();

        public DailySummaryPage()
        {
            InitializeComponent();
        }
    }
}
