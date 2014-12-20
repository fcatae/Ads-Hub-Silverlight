using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using AppAdsHubSilverlight.Resources;
using System.Diagnostics;

namespace AppAdsHubSilverlight
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            soma1.StartAds();
            
            inmob1.LoadNewAd();
            // inmob: set up the test device
            // InMobi.WP.AdSDK.SDKUtility.LogLevel = InMobi.WP.AdSDK.LogLevels.IMLogLevelDebug;
        }

        private void AdControl_ErrorOccurred(object sender, Microsoft.Advertising.AdErrorEventArgs e)
        {
            Debug.WriteLine(e.Error);
        }

        private void AdMediatorCtrl1_AdMediatorError(object sender, Microsoft.AdMediator.Core.Events.AdMediatorFailedEventArgs e)
        {
            Debug.WriteLine(e.Error);
        }

        private void AdMediatorCtrl1_AdSdkError(object sender, Microsoft.AdMediator.Core.Events.AdFailedEventArgs e)
        {
            Debug.WriteLine(e.Error);
        }

        private void inmob1_OnAdRequestFailed(object sender, InMobi.WP.AdSDK.IMAdViewErrorEventArgs e)
        {
            Debug.WriteLine(e.ErrorDescription);
        }

    }
}