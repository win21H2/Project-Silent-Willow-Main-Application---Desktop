using Project_Silent_Willow_Main_Application___Desktop.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Project_Silent_Willow_Main_Application___Desktop.Views {
    public sealed partial class MainPage : Page {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage() {
            InitializeComponent();
        }

        void BTON(object sender, RoutedEventArgs e) {
            Button button = sender as Button;
            button.Background = new SolidColorBrush(Windows.UI.Colors.Red);
        }
    }
}
