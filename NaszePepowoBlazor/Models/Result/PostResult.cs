using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace NaszePepowoBlazor.Models.Result
{
    public class PostResult
    {
        /// <summary>
        /// The kind of this entity. Always blogger#post.
        /// </summary>
        //public string kind { get; set; }

        /// <summary>
        /// The ID of this post.
        /// </summary>
        //public string id { get; set; }

        /// <summary>
        /// Data about the blog containing this post.
        /// </summary>
        //public BlogResult blog { get; set; }

        /// <summary>
        /// date-time when this post was published.
        /// </summary>
        public DateTime published { get; set; }

        /// <summary>
        /// date-time when this post was last updated.
        /// </summary>
        //public DateTime updated { get; set; }

        /// <summary>
        /// The URL where this post is displayed.
        /// </summary>
        //public string url { get; set; }

        /// <summary>
        /// The Blogger API URL to fetch this resource from.
        /// </summary>
        //public string selfLink { get; set; }

        /// <summary>
        /// The title of the post.
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// The content of the post. Can contain HTML markup.
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// The author of this post.
        /// </summary>
        public AuthorResult author { get; set; }

        /// <summary>
        /// The container for this post's comments.
        /// </summary>
        //public RepliesResult replies { get; set; }

        /// <summary>
        /// The list of labels this post was tagged with.
        /// </summary>
        public List<string> labels { get; set; }

        /// <summary>
        /// The JSON metadata for the post.
        /// </summary>
        //public string customMetaData { get; set; }

        /// <summary>
        /// The location, if this post is geotagged.
        /// </summary>
        //public LocationResult location { get; set; }

        /// <summary>
        /// The title link URL, similar to atom's related link.
        /// </summary>
        //public string titleLink { get; set; }

        /// <summary>
        /// Display image for the Post.
        /// </summary>
        //public ImageResult[] images { get; set; }

        /// <summary>
        /// Status of the post. Only set for admin-level requests
        /// </summary>
        //public string status { get; set; }
    }
}
