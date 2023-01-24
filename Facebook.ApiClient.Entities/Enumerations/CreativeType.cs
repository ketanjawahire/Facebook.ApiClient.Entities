namespace Facebook.ApiClient.Entities.Enumerations
{
    /// <summary>
    /// The type of object that is being advertised. 
    /// </summary>
    public enum CreativeType
    {
        /// <summary>
        /// app on Facebook
        /// </summary>
        APPLICATION,

        /// <summary>
        /// Domain
        /// </summary>
        DOMAIN,

        /// <summary>
        /// Event
        /// </summary>
        EVENT,

        /// <summary>
        /// when an invalid object_id was specified such as a deleted object or if you do not have permission to see the object. In very few cases, this field may be empty if Facebook is unable to identify the type of advertised object
        /// </summary>
        INVALID,

        /// <summary>
        /// Offer
        /// </summary>
        OFFER,

        /// <summary>
        /// Page
        /// </summary>
        PAGE,

        /// <summary>
        /// Photo
        /// </summary>
        PHOTO,

        /// <summary>
        /// Post deleted
        /// </summary>
        POST_DELETED,

        /// <summary>
        /// Privacy check fail
        /// </summary>
        PRIVACY_CHECK_FAIL,

        /// <summary>
        /// Share from a page
        /// </summary>
        SHARE,

        /// <summary>
        /// status of a page
        /// </summary>
        STATUS,

        /// <summary>
        ///  refers to an iTunes or Google Play store destination
        /// </summary>
        STORE_ITEM,

        /// <summary>
        /// VIdeo
        /// </summary>
        VIDEO

    }
}
