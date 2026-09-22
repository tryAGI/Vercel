
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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared990c7cda5d679d8c, global::Vercel.CountPageviewsResponseData>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared990c7cda5d679d8c, global::Vercel.CountPageviewsResponseData> Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CountPageviewsResponseQuery Query { get; set; }

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
        /// Initializes a new instance of the <see cref="CountPageviewsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="query"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CountPageviewsResponse(
            global::Vercel.OneOf<global::Vercel.AutoSDKShared990c7cda5d679d8c, global::Vercel.CountPageviewsResponseData> data,
            global::Vercel.CountPageviewsResponseQuery query,
            double version)
        {
            this.Data = data;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountPageviewsResponse" /> class.
        /// </summary>
        public CountPageviewsResponse()
        {
        }

    }
}