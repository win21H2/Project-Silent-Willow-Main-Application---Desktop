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
        
        void CONNECT_Click(object sender, RoutedEventArgs e) {  
            TESTBUTTON.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
            // MAKE IT LAUNCH A TOAST IF THE USER DOES NOT HAVE BLUETOOTH TURNED ON
        }

        void DISCONNECT_Click(object sender, RoutedEventArgs e) {
            TESTBUTTON.Foreground = new SolidColorBrush(Windows.UI.Colors.Blue);
            // MAKE IT LAUNCH A TOAST WHICH DISPLAYS THAT THE COMPUTER HAS DISCONNECTED
        }

        void BTON_Click(object sender, RoutedEventArgs e) {
            TESTBUTTON.Foreground = new SolidColorBrush(Windows.UI.Colors.Yellow);
            // TURN BLUETOOTH ON
        }
        
        void BTOFF_Click(object sender, RoutedEventArgs e) {
            TESTBUTTON.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
            // TURN BLUETOOTH OFF
        }

        void TESTBUTTON_Click(object sender, RoutedEventArgs e) {
            TESTBUTTON.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
            // NO EXTRA FUNCTIONS NEEDED
        }
    }
}
