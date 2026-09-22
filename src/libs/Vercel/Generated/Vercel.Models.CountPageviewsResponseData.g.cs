
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CountPageviewsResponseData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageviews")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Pageviews { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visitors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Visitors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountPageviewsResponseData" /> class.
        /// </summary>
        /// <param name="pageviews"></param>
        /// <param name="visitors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CountPageviewsResponseData(
            double pageviews,
            double visitors)
        {
            this.Pageviews = pageviews;
            this.Visitors = visitors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountPageviewsResponseData" /> class.
        /// </summary>
        public CountPageviewsResponseData()
        {
        }

    }
}