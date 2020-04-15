using NaszePepowoBlazor.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaszePepowoBlazor.Shared
{
    public static class Posts
    {
        static Posts()
        {
            PostResults = new List<PostResult>();
        }

        public static List<PostResult> PostResults;
    }
}
