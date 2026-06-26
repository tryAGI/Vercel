
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AggregateEventsResponse
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
        public required global::Vercel.AggregateEventsResponseQuery Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.AggregateEventsResponseDataVariant1Item>, global::System.Collections.Generic.IList<global::Vercel.AggregateEventsResponseDataVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.AggregateEventsResponseDataVariant1Item>, global::System.Collections.Generic.IList<global::Vercel.AggregateEventsResponseDataVariant2Item>> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateEventsResponse" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="query"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AggregateEventsResponse(
            double version,
            global::Vercel.AggregateEventsResponseQuery query,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.AggregateEventsResponseDataVariant1Item>, global::System.Collections.Generic.IList<global::Vercel.AggregateEventsResponseDataVariant2Item>> data)
        {
            this.Version = version;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateEventsResponse" /> class.
        /// </summary>
        public AggregateEventsResponse()
        {
        }

    }
}