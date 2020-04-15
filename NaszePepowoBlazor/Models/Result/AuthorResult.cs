namespace NaszePepowoBlazor.Models.Result
{
    public class AuthorResult
    {
        /// <summary>
        /// The ID of the post creator.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The post creator's display name.
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        /// The URL of the post creator's profile page.
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// The post creator's avatar.
        /// </summary>
        public ImageResult image { get; set; }
    }
}
