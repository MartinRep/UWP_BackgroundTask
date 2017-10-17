using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;

namespace BackgroundComponent
{
    public sealed class Class1 : IBackgroundTask
    {
        public async void Run(IBackgroundTaskInstance taskInstance)
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

            }
        }
}
