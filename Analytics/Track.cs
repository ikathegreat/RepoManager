using System;
using System.Diagnostics;
using System.Reflection;

namespace RepoManager.Analytics
{
    /// <summary>
    /// Wrapper for tracking analytics tools
    /// </summary>
    public static class Track
    {
        public static bool DoTracking { get; set; } = true;
        public static AnalyticsProviderEnum AnalyticsProvider { get; set; } = AnalyticsProviderEnum.GoogleAnalytics;
        public static string TrackingID { get; set; } = "UA-XXXXXXXX-X";
        public static string ClientID { get; set; } = "";
        public static string ApplicationName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;
        public static string ApplicationVersion { get; set; } = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
        public static string UserLanguage { get; set; } = new Microsoft.VisualBasic.Devices.ComputerInfo().InstalledUICulture.ToString();
        public static string CustomDimension1 { get; set; } = "";

        /// <summary>
        /// Call Register with a unique Client ID value to avoid generating a new fingerprint
        /// string (which is a slow operation. Host application may choose to store the Client ID
        /// after Register to recall for a future instance/session.
        /// </summary>
        /// <param name="clientID"></param>
        public static void Register(string clientID = "")
        {
            ClientID = string.IsNullOrEmpty(clientID) ? Fingerprint.Value : clientID;

        }


        public static void DoTrackEvent(string category, string action, string label = "",
            int? value = null)
        {

            if (!DoTracking)
                return;

            if (string.IsNullOrEmpty(ClientID))
                return;

            switch (AnalyticsProvider)
            {

                case AnalyticsProviderEnum.GoogleAnalytics:
                    GoogleAnalytics.Event(category, action, label, value);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    public enum AnalyticsProviderEnum
    {
        GoogleAnalytics
    }

}
