using System;

using UberTracker.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UberTracker.Views
{
    public sealed partial class StatisticsPage : Page
    {
        public StatisticsViewModel ViewModel { get; } = new StatisticsViewModel();

        public StatisticsPage()
        {
            InitializeComponent();
        }
    }
}
