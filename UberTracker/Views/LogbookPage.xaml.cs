using System;

using UberTracker.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UberTracker.Views
{
    public sealed partial class LogbookPage : Page
    {
        public LogbookViewModel ViewModel { get; } = new LogbookViewModel();

        public LogbookPage()
        {
            InitializeComponent();
        }
    }
}
