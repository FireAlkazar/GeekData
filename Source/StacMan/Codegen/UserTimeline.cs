// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

using System;

namespace StackExchange.StacMan
{
    /// <summary>
    /// StacMan UserTimeline, corresponding to Stack Exchange API v2's user_timeline type
    /// http://api.stackexchange.com/docs/types/user-timeline
    /// </summary>
    public partial class UserTimeline : StacManType
    {
        /// <summary>
        /// badge_id
        /// </summary>
        [Field("badge_id")]
        public int? BadgeId { get; internal set; }

        /// <summary>
        /// comment_id
        /// </summary>
        [Field("comment_id")]
        public int? CommentId { get; internal set; }

        /// <summary>
        /// creation_date
        /// </summary>
        [Field("creation_date")]
        public DateTime CreationDate { get; internal set; }

        /// <summary>
        /// detail
        /// </summary>
        [Field("detail")]
        public string Detail { get; internal set; }

        /// <summary>
        /// link
        /// </summary>
        [Field("link")]
        public string Link { get; internal set; }

        /// <summary>
        /// post_id
        /// </summary>
        [Field("post_id")]
        public int? PostId { get; internal set; }

        /// <summary>
        /// post_type
        /// </summary>
        [Field("post_type")]
        public Posts.PostType PostType { get; internal set; }

        /// <summary>
        /// suggested_edit_id
        /// </summary>
        [Field("suggested_edit_id")]
        public int? SuggestedEditId { get; internal set; }

        /// <summary>
        /// timeline_type
        /// </summary>
        [Field("timeline_type")]
        public UserTimelines.TimelineType TimelineType { get; internal set; }

        /// <summary>
        /// title
        /// </summary>
        [Field("title")]
        public string Title { get; internal set; }

        /// <summary>
        /// user_id
        /// </summary>
        [Field("user_id")]
        public int UserId { get; internal set; }

    }
}
