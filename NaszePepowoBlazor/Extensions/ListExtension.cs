using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaszePepowoBlazor.Extensions
{
    public static class ListExtension
    {
        public static bool IsNullOrEmpty<T>(this List<T> list) => list?.Any() != true;
    }
}
