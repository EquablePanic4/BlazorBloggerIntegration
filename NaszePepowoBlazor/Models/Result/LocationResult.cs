namespace NaszePepowoBlazor.Models.Result
{
    public class LocationResult
    {
        /// <summary>
        /// Location name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Location's latitude.
        /// </summary>
        public double? lat { get; set; }

        /// <summary>
        /// Location's longitude.
        /// </summary>
        public double? lng { get; set; }

        /// <summary>
        /// Location's viewport span. Can be used when rendering a map preview.
        /// </summary>
        public string span { get; set; }
    }
}
