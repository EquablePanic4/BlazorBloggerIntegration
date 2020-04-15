namespace NaszePepowoBlazor.Models.Result
{
    public class RepliesResult
    {
        /// <summary>
        /// The total number of comments on this post.
        /// </summary>
        public long? totalItems { get; set; }

        /// <summary>
        /// The Blogger API URL of to retrieve the comments for this post.
        /// </summary>
        public string selfLink { get; set; }

        /// <summary>
        /// The list of comments for this post.
        /// </summary>
        public string[] items { get; set; }
    }
}
