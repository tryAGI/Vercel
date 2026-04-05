
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant47
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Src { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dst")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dst { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant47" /> class.
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant47(
            string src,
            string dst)
        {
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Dst = dst ?? throw new global::System.ArgumentNullException(nameof(dst));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant47" /> class.
        /// </summary>
        public UserEventPayloadVariant47()
        {
        }
    }
}