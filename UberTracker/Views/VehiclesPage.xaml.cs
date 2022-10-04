using System;

using UberTracker.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UberTracker.Views
{
    public sealed partial class VehiclesPage : Page
    {
        public VehiclesViewModel ViewModel { get; } = new VehiclesViewModel();

        public VehiclesPage()
        {
            InitializeComponent();
        }
    }
}
