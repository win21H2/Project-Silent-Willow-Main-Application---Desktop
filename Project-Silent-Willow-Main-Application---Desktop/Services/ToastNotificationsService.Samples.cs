using Microsoft.Toolkit.Uwp.Notifications;
using Windows.UI.Notifications;

namespace Project_Silent_Willow_Main_Application___Desktop.Services {
    internal partial class ToastNotificationsService {
        public void ShowToastNotificationSample() {
            // Create the toast content
            var content = new ToastContent() {
                // More about the Launch property at https://docs.microsoft.com/dotnet/api/microsoft.toolkit.uwp.notifications.toastcontent
                Launch = "ToastContentActivationParams",

                Visual = new ToastVisual() {
                    BindingGeneric = new ToastBindingGeneric() {
                        Children = {
                            new AdaptiveText() {
                                Text = "Sample Toast Notification"
                            },

                            new AdaptiveText() {
                                 Text = @"Opened Project Silent Willow---Desktop"
                            }
                        }
                    }
                },

                Actions = new ToastActionsCustom() {
                    Buttons = {
                        // More about Toast Buttons at https://docs.microsoft.com/dotnet/api/microsoft.toolkit.uwp.notifications.toastbutton
                        new ToastButton("OK", "ToastButtonActivationArguments") {
                            ActivationType = ToastActivationType.Foreground
                        }
                    }
                }
            };

            // Add the content to the toast
            var toast = new ToastNotification(content.GetXml()) {
                // TODO: Set a unique identifier for this notification within the notification group. (optional)
                // More details at https://docs.microsoft.com/uwp/api/windows.ui.notifications.toastnotification.tag
                Tag = "ToastTag"
            };
        }
    }
}
