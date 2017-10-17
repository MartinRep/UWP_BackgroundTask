using System;
using Windows.ApplicationModel.Background;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BackgroundTaskDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// <summary> 
    /// An empty page that can be used on its own or navigated to within a Frame. 
    /// </summary>

    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            var access = await BackgroundExecutionManager.RequestAccessAsync();

            switch (access)
            {
                case BackgroundAccessStatus.Unspecified:
                    break;
                case BackgroundAccessStatus.AllowedMayUseActiveRealTimeConnectivity:
                    break;
                case BackgroundAccessStatus.AllowedWithAlwaysOnRealTimeConnectivity:
                    break;
                case BackgroundAccessStatus.Denied:
                    break;
                default:
                    break;
            }

            var task = new BackgroundTaskBuilder
            {
                Name = "My Task",
                TaskEntryPoint = typeof(BackgroundComponent.Class1).ToString()
            };

            var trigger = new ApplicationTrigger();
            task.SetTrigger(trigger);

            var condition = new SystemCondition(SystemConditionType.InternetAvailable);
            task.Register();

            await trigger.RequestAsync();
        }
    }

}
