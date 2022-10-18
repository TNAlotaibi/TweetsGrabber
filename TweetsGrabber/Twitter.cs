using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace TweetsGrabber
{
    internal class Twitter
    {
        static HttpWebRequest request;
          
        private static string BearerToken = string.Empty;
        //private static string guestToken = string.Empty;
        
        private static Task SetRequestOptions()
        {  
            request.Host = "na.glbtls.t.co";
            request.Method = "GET";
            request.Accept = "application/json";
            request.Headers.Add("Accept-Language", "en-US;ar-SA");
            request.UserAgent = "TwitterAndroid/9.48.0-release.0 (29480000-r-0) SM-N975F/7.1.2 (samsung;SM-N975F;samsung;SM-N975F;0;;1;2015)";
            request.Headers.Add("Authorization", "Bearer " + BearerToken);
            request.Headers.Add("X-Twitter-Client-Deviceid", "87e38799e4de2562");
            return Task.CompletedTask;
        }
        public static void GetHeaders()
        {
            try
            {
                WebClient webClient = new WebClient();
                string ResponseForGetBearerTokenValue = webClient.DownloadString("https://abs.twimg.com:443/responsive-web/client-web/main.6c1aeb65.js");
                BearerToken = Regex.Match(ResponseForGetBearerTokenValue, "\"Web-12\",a=\"(.*?)\",").Groups[1].Value;
                //string ResponseForGetguestTokenValue = webClient.DownloadString("https://twitter.com:443/");
                //guestToken = Regex.Match(ResponseForGetguestTokenValue, "gt=(.*?);").Groups[1].Value;
            }
            catch 
            {
                System.Windows.Forms.MessageBox.Show("Error in get headers!", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public static IEnumerable<string> TweetsGenerator(string TargetUsername , string Keyword)
        {
            var Endpoint = $"https://na.glbtls.t.co/2/search/adaptive.json?q=from:@{TargetUsername} {Keyword}&spelling_corrections=true&query_source=profile_click&tweet_search_mode=top&earned=true&include_entities=true&include_cards=true&cards_platform=Android-12&include_carousels=true&ext=mediaRestrictions,altText,mediaStats,mediaColor,info360,highlightedLabel,superFollowMetadata,hasNftAvatar,unmentionInfo,collabControl&include_media_features=true&include_blocking=true&include_blocked_by=true&include_ext_trusted_friends_metadata=true&include_ext_media_availability=true&include_quote_count=true&simple_quoted_tweet=true&include_ext_enrichments=true&include_ext_replyvoting_downvote_perspective=true&include_composer_source=true&include_ext_collab_control=true&tweet_mode=extended&include_reply_count=true&include_ext_sensitive_media_warning=true&include_user_entities=true&include_profile_interstitial_type=true&include_ext_professional=true&include_viewer_quick_promote_eligibility=true&include_ext_has_nft_avatar=true";
            request = (HttpWebRequest)WebRequest.Create(Endpoint);
            Task.Run(() => SetRequestOptions()).Wait();
            var Response = string.Empty;
            try
            {
                Response = Regex.Unescape(new StreamReader(request.GetResponse().GetResponseStream()).ReadToEnd());
            }
            catch (WebException ex)
            {
                Response = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
            }
            MatchCollection collection = Regex.Matches(Response, "\"full_text\":\"(.*?)\",");
            foreach (Match match in collection)
            {
                yield return match.Groups[1].Value.ToString();
            }
        }
    }
}
