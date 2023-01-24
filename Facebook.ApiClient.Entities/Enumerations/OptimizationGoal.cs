using Facebook.ApiClient.Entities.Api;

namespace Facebook.ApiClient.Entities.Enumerations
{

    /// <summary>
    /// Which optimization goal this ad set is using
    /// </summary>
    public enum OptimizationGoal
    {
        /// <summary>
        /// Only available in read mode for campaigns created pre v2.4
        /// </summary>
        NONE,

        /// <summary>
        /// APP_DOWNLOADS
        /// </summary>
        APP_DOWNLOADS,

        /// <summary>
        /// Optimize for people more likely to install your app.
        /// </summary>
        APP_INSTALLS,

        /// <summary>
        /// Optimizes for people more likely to install your app and make a conversion on your site.
        /// </summary>
        APP_INSTALLS_AND_OFFSITE_CONVERSIONS,

        /// <summary>
        /// Optimize for people more likely to remember seeing your ads.
        /// </summary>
        AD_RECALL_LIFT,

        /// <summary>
        /// Optimize to reach the most number of users who are likely to spend at least a minimum amount of time on the image or video
        /// </summary>
        BRAND_AWARENESS,

        /// <summary>
        ///  Optimize for people more likely to click anywhere in the ad.
        /// </summary>
        CLICKS,

        /// <summary>
        ///  Directs ads to people more likely to have a conversation with the business.
        /// </summary>
        CONVERSATIONS,

        /// <summary>
        ///  Optimize for retention, which reaches people who are most likely to return to the app and open it again during a given time frame after installing. 
        ///  You can choose either two days, meaning the app is likely to be reopened between 24 and 48 hours after installation; or seven days, meaning the app 
        ///  is likely to be reopened between 144 and 168 hours after installation.
        /// </summary>
        DERIVED_EVENTS,

        /// <summary>
        /// Optimize for people more likely to take a particular action in your app 
        /// </summary>
        ENGAGED_USERS,

        /// <summary>
        /// FBX only 
        /// </summary>
        EXTERNAL,

        /// <summary>
        /// Optimize for people more likely to attend your event 
        /// </summary>
        EVENT_RESPONSES,

        /// <summary>
        ///  Show the ads as many times as possible 
        /// </summary>
        IMPRESSIONS,

        /// <summary>
        /// Optimize for people who are most likely to click on and load your chosen landing page.
        /// </summary>
        LANDING_PAGE_VIEWS,

        /// <summary>
        /// IN_APP_VALUE
        /// </summary>
        IN_APP_VALUE,

        /// <summary>
        /// Optimize for people more likely to fill out a lead generation form.
        /// </summary>
        LEAD_GENERATION,

        /// <summary>
        /// Optimize for people more likely to click in the link of the ad. 
        /// </summary>
        LINK_CLICKS,

        /// <summary>
        /// MESSAGING_PURCHASE_CONVERSION 
        /// </summary>
        MESSAGING_PURCHASE_CONVERSION,

        /// <summary>
        /// MESSAGING_APPOINTMENT_CONVERSION 
        /// </summary>
        MESSAGING_APPOINTMENT_CONVERSION,

        /// <summary>
        /// Optimize for people more likely to claim the offer.
        /// </summary>
        OFFER_CLAIMS,

        /// <summary>
        /// Optimize for people more likely to make a conversion in the site 
        /// </summary>
        OFFSITE_CONVERSIONS,

        /// <summary>
        /// Optimize for people more likely to engage with your page
        /// </summary>
        PAGE_ENGAGEMENT,

        /// <summary>
        /// Optimize for people more likely to like your page. 
        /// </summary>
        PAGE_LIKES,

        /// <summary>
        /// Optimize for people more likely to engage with your post.
        /// </summary>
        POST_ENGAGEMENT,

        /// <summary>
        /// Optimize for people who are likely to call the advertiser.
        /// </summary>
        QUALITY_CALL,

        /// <summary>
        /// Optimize for people who are likely to have a deeper conversation with advertisers after lead submission.
        /// </summary>
        QUALITY_LEAD,

        /// <summary>
        /// Optimize to reach the most unique users of each day or interval specified in <see cref="AdSet.FrequencyControlSpec"/>
        /// </summary>
        REACH,

        /// <summary>
        /// Increase the number of impressions with social context.
        /// <para>I.e. with the names of one or more of the user's friends attached to the ad who have already liked the page or installed the app.</para>
        /// </summary>
        SOCIAL_IMPRESSIONS,

        /// <summary>
        /// Optimize delivery of your ads to people who are more likely to play your ad to completion, or play it for at least 15 seconds.
        /// </summary>
        THRUPLAY,

        /// <summary>
        /// Optimize for maximum total purchase value within the specified attribution window.
        /// </summary>
        VALUE,

        /// <summary>
        /// Optimize for people more likely to watch videos
        /// </summary>
        VIDEO_VIEWS,

        /// <summary>
        /// Optimize for visits to the advertiser's Instagram profile.
        /// </summary>
        VISIT_INSTAGRAM_PROFILE,

    }
}
