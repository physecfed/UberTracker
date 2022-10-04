using System;

using UberTracker.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UberTracker.Views
{
    public sealed partial class ReportsPage : Page
    {
        public ReportsViewModel ViewModel { get; } = new ReportsViewModel();

        public ReportsPage()
        {
            InitializeComponent();
        }
    }
}
