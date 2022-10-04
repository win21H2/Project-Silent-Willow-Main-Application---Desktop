using System;

using Project_Silent_Willow_Main_Application___Desktop.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Project_Silent_Willow_Main_Application___Desktop.Views
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
