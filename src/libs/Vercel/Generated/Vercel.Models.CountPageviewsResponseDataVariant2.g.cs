
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CountPageviewsResponseDataVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visitors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Visitors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageviews")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Pageviews { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountPageviewsResponseDataVariant2" /> class.
        /// </summary>
        /// <param name="visitors"></param>
        /// <param name="pageviews"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CountPageviewsResponseDataVariant2(
            double visitors,
            double pageviews)
        {
            this.Visitors = visitors;
            this.Pageviews = pageviews;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountPageviewsResponseDataVariant2" /> class.
        /// </summary>
        public CountPageviewsResponseDataVariant2()
        {
        }

    }
}