
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AggregatePageviewsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared2c7fdfa9ff104258JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared2c7fdfa9ff104258 Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AggregatePageviewsResponseQuery Query { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatePageviewsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="query"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AggregatePageviewsResponse(
            global::Vercel.AutoSDKShared2c7fdfa9ff104258 data,
            global::Vercel.AggregatePageviewsResponseQuery query,
            double version)
        {
            this.Data = data;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatePageviewsResponse" /> class.
        /// </summary>
        public AggregatePageviewsResponse()
        {
        }

    }
}