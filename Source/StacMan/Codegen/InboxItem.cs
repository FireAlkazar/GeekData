// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

using System;

namespace StackExchange.StacMan
{
    /// <summary>
    /// StacMan InboxItem, corresponding to Stack Exchange API v2's inbox_item type
    /// http://api.stackexchange.com/docs/types/inbox-item
    /// </summary>
    public partial class InboxItem : StacManType
    {
        /// <summary>
        /// answer_id
        /// </summary>
        [Field("answer_id")]
        public int? AnswerId { get; internal set; }

        /// <summary>
        /// body
        /// </summary>
        [Field("body")]
        public string Body { get; internal set; }

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
        /// is_unread
        /// </summary>
        [Field("is_unread")]
        public bool IsUnread { get; internal set; }

        /// <summary>
        /// item_type
        /// </summary>
        [Field("item_type")]
        public InboxItems.ItemType ItemType { get; internal set; }

        /// <summary>
        /// link
        /// </summary>
        [Field("link")]
        public string Link { get; internal set; }

        /// <summary>
        /// question_id
        /// </summary>
        [Field("question_id")]
        public int? QuestionId { get; internal set; }

        /// <summary>
        /// site
        /// </summary>
        [Field("site")]
        public Site Site { get; internal set; }

        /// <summary>
        /// title
        /// </summary>
        [Field("title")]
        public string Title { get; internal set; }

    }
}