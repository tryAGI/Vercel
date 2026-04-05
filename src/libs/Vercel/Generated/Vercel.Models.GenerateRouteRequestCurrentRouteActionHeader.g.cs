
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateRouteRequestCurrentRouteActionHeader
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        public string? Op { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteRequestCurrentRouteActionHeader" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="op"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateRouteRequestCurrentRouteActionHeader(
            string? key,
            string? value,
            string? op)
        {
            this.Key = key;
            this.Value = value;
            this.Op = op;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteRequestCurrentRouteActionHeader" /> class.
        /// </summary>
        public GenerateRouteRequestCurrentRouteActionHeader()
        {
        }
    }
}