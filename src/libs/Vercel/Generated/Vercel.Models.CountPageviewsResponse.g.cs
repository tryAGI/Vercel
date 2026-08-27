
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CountPageviewsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CountPageviewsResponseQuery Query { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CountPageviewsResponseDataVariant1, global::Vercel.CountPageviewsResponseDataVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.CountPageviewsResponseDataVariant1, global::Vercel.CountPageviewsResponseDataVariant2> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountPageviewsResponse" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="query"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CountPageviewsResponse(
            double version,
            global::Vercel.CountPageviewsResponseQuery query,
            global::Vercel.OneOf<global::Vercel.CountPageviewsResponseDataVariant1, global::Vercel.CountPageviewsResponseDataVariant2> data)
        {
            this.Version = version;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountPageviewsResponse" /> class.
        /// </summary>
        public CountPageviewsResponse()
        {
        }

    }
}