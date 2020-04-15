using System.Collections.Generic;

namespace NaszePepowoBlazor.Models.Result
{
    public class PostListResult
    {
        /// <summary>
        /// The kind of this entity. Always blogger#postList.
        /// </summary>
        public string kind { get; set; }

        /// <summary>
        /// Pagination token to fetch the next page, if one exists.
        /// </summary>
        public string nextPageToken { get; set; }

        /// <summary>
        /// The list of posts for this blog.
        /// </summary>
        public List<PostResult> items { get; set; }
    }
}
