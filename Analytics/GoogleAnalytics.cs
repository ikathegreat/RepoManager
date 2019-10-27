using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace RepoManager.Analytics
{
    //https://developers.google.com/analytics/devguides/collection/protocol/v1/devguide#event
    //https://developers.google.com/analytics/devguides/collection/analyticsjs/command-queue-reference

    public static class GoogleAnalytics
    {

        /// <summary>
        /// Perform a Google Analytics Event call to track a specific user event. Label and
        /// value are optional.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="action"></param>
        /// <param name="label"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="Exception"></exception>
        public static void Event(string category, string action, string label = "",
            int? value = null)
        {

            if (string.IsNullOrEmpty(category))
                throw new ArgumentNullException(nameof(category));
            if (string.IsNullOrEmpty(action))
                throw new ArgumentNullException(nameof(action));

            var request = (HttpWebRequest)WebRequest.Create("http://www.google-analytics.com/collect");
            request.Method = "POST";
            request.KeepAlive = false;


            //Parameters
            //https://developers.google.com/analytics/devguides/collection/protocol/v1/parameters

            
            var postData = new Dictionary<string, string>
            {
                {"an", Track.ApplicationName.Replace(" ","%20")},
                {"v", "1"}, //Google API Version
                {"tid", Track.TrackingID},
                {"cid", Track.ClientID},
                {"ul", Track.UserLanguage},
                {"av", Track.ApplicationVersion},
                {"t", "event"},
                {"ec", category},
                {"ea", action} //Event Action
            };

            if (!string.IsNullOrEmpty(Track.CustomDimension1))
            {
                postData.Add("ecd1l", Track.CustomDimension1);
            }

            if (!string.IsNullOrEmpty(label))
            {
                postData.Add("el", label);
            }

            if (value.HasValue)
            {
                postData.Add("ev", value.ToString());
            }

            var postDataString = postData.Aggregate("", (data, next) => $"{data}&{next.Key}={HttpUtility.UrlEncode(next.Value)}").TrimEnd('&');

            request.ContentLength = Encoding.UTF8.GetByteCount(postDataString);

            HttpWebResponse webResponse = null;
            try
            {
                using (var writer = new StreamWriter(request.GetRequestStream()))
                {
                    writer.Write(postDataString);
                }

                webResponse = (HttpWebResponse)request.GetResponse();
                if (webResponse.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception((int)webResponse.StatusCode + ": Google Analytics tracking did not return OK 200");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception in Google Analytics Event: {ex.Message}");
            }
            finally
            {
                webResponse?.Close();
            }
        }
    }
}
