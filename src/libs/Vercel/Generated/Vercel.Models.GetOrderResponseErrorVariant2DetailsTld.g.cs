
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrderResponseErrorVariant2DetailsTld
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tldName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TldName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endsAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndsAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseErrorVariant2DetailsTld" /> class.
        /// </summary>
        /// <param name="tldName"></param>
        /// <param name="endsAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrderResponseErrorVariant2DetailsTld(
            string tldName,
            string endsAt)
        {
            this.TldName = tldName ?? throw new global::System.ArgumentNullException(nameof(tldName));
            this.EndsAt = endsAt ?? throw new global::System.ArgumentNullException(nameof(endsAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseErrorVariant2DetailsTld" /> class.
        /// </summary>
        public GetOrderResponseErrorVariant2DetailsTld()
        {
        }
    }
}