using System;

using UberTracker.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UberTracker.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
