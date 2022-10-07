using Microsoft.Toolkit.Uwp.Notifications;
using Project_Silent_Willow_Main_Application___Desktop.ViewModels;
using System;
using System.Xml;
using System.Xml.Linq;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Project_Silent_Willow_Main_Application___Desktop.Views {
    public sealed partial class MainPage : Page {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage() {
            InitializeComponent();
        }

        // TRY TO USE THE CODE FROM THE SERVICE FILE


        void CONNECT_Click(object sender, RoutedEventArgs e) {  
            TESTBUTTON.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
            // MAKE IT LAUNCH A TOAST IF THE USER DOES NOT HAVE BLUETOOTH TURNED ON
            /* IDEAS
             * 
             * If the user does not have Bluetooth turned on, prompt them to go to settings and turn it on
             * TO CONTINUE WITH THE POINT ABOVE
             * Find out a way to launch the settings app and navigate to the Bluetooth settings page
             * 
             * OR
             * 
             * Figure out a way to turn on Bluetooth directly from the toast (look at docs)
             */

        }

        void DISCONNECT_Click(object sender, RoutedEventArgs e) {
            TESTBUTTON.Foreground = new SolidColorBrush(Windows.UI.Colors.Blue);
            // MAKE IT LAUNCH A TOAST WHICH DISPLAYS THAT THE COMPUTER HAS DISCONNECTED
        }


        void TESTBUTTON_Click(object sender, RoutedEventArgs e) {
            TESTBUTTON.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
            // NO EXTRA FUNCTIONS NEEDED
        }
    }
}
