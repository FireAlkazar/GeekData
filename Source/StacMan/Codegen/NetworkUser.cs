// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

using System;

namespace StackExchange.StacMan
{
    /// <summary>
    /// StacMan NetworkUser, corresponding to Stack Exchange API v2's network_user type
    /// http://api.stackexchange.com/docs/types/network-user
    /// </summary>
    public partial class NetworkUser : StacManType
    {
        /// <summary>
        /// account_id
        /// </summary>
        [Field("account_id")]
        public int AccountId { get; internal set; }

        /// <summary>
        /// answer_count
        /// </summary>
        [Field("answer_count")]
        public int AnswerCount { get; internal set; }

        /// <summary>
        /// badge_counts
        /// </summary>
        [Field("badge_counts")]
        public BadgeCount BadgeCounts { get; internal set; }

        /// <summary>
        /// creation_date
        /// </summary>
        [Field("creation_date")]
        public DateTime CreationDate { get; internal set; }

        /// <summary>
        /// last_access_date
        /// </summary>
        [Field("last_access_date")]
        public DateTime LastAccessDate { get; internal set; }

        /// <summary>
        /// question_count
        /// </summary>
        [Field("question_count")]
        public int QuestionCount { get; internal set; }

        /// <summary>
        /// reputation
        /// </summary>
        [Field("reputation")]
        public int Reputation { get; internal set; }

        /// <summary>
        /// site_name
        /// </summary>
        [Field("site_name")]
        public string SiteName { get; internal set; }

        /// <summary>
        /// site_url
        /// </summary>
        [Field("site_url")]
        public string SiteUrl { get; internal set; }

        /// <summary>
        /// user_id
        /// </summary>
        [Field("user_id")]
        public int UserId { get; internal set; }

        /// <summary>
        /// user_type
        /// </summary>
        [Field("user_type")]
        public Users.UserType UserType { get; internal set; }

    }
}
