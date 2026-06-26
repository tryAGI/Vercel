
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CountPageviewsResponseQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("since")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Since { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("until")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Until { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountPageviewsResponseQuery" /> class.
        /// </summary>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <param name="filter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CountPageviewsResponseQuery(
            string since,
            string until,
            string? filter)
        {
            this.Since = since ?? throw new global::System.ArgumentNullException(nameof(since));
            this.Until = until ?? throw new global::System.ArgumentNullException(nameof(until));
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountPageviewsResponseQuery" /> class.
        /// </summary>
        public CountPageviewsResponseQuery()
        {
        }

    }
}