using Microsoft.Toolkit.Uwp.Notifications;
using Project_Silent_Willow_Main_Application___Desktop.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Project_Silent_Willow_Main_Application___Desktop.Views {
    public sealed partial class MainPage : Page {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage() { 
            InitializeComponent();
        }

        /*
         * TODO
         *  - Work on checking if the device hsa Bluetooth enabled
         *  - Try to open the settings page from a toast notif
         *  - Work on changing the state of the toggle buttons when another one is pressed
         *  - Work on listing BT devices
         */

        void CONNECT_Click(object sender, RoutedEventArgs e) {  


            /*
            new ToastContentBuilder()
                .SetToastScenario(ToastScenario.Reminder)
                .AddArgument("action", "viewEvent")
                .AddArgument("eventId", 1983)
                .AddText("ERROR_BLUETOOTH_NOT_ENABLED")

                .AddButton(new ToastButton()
                    .SetContent("Settings")
                    .AddArgument("action", "viewDetails"))

                .Show();*/
        }

        void DISCONNECT_Click(object sender, RoutedEventArgs e) {
            new ToastContentBuilder()
               .SetToastScenario(ToastScenario.Reminder)
               .AddArgument("action", "viewEvent")
               .AddArgument("eventId", 1983)
               .AddText("PROJECT_SILENT_WILLOW_STATE_DISCONNECTED")

               .AddButton(new ToastButton()
                   .SetContent("Ok"))

               .Show();
        }
    }
}
