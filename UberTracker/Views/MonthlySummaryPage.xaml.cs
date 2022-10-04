using System;

using UberTracker.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UberTracker.Views
{
    public sealed partial class MonthlySummaryPage : Page
    {
        public MonthlySummaryViewModel ViewModel { get; } = new MonthlySummaryViewModel();

        public MonthlySummaryPage()
        {
            InitializeComponent();
        }
    }
}
