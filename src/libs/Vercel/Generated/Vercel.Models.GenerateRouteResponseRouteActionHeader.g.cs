
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateRouteResponseRouteActionHeader
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GenerateRouteResponseRouteActionHeaderOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GenerateRouteResponseRouteActionHeaderOp Op { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteResponseRouteActionHeader" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="op"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateRouteResponseRouteActionHeader(
            string key,
            global::Vercel.GenerateRouteResponseRouteActionHeaderOp op,
            string? value)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value;
            this.Op = op;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteResponseRouteActionHeader" /> class.
        /// </summary>
        public GenerateRouteResponseRouteActionHeader()
        {
        }
    }
}