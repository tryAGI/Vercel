
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant129
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cause")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cause { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockReason")]
        public string? BlockReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("siftRoute")]
        public global::Vercel.UserEventPayloadVariant129SiftRoute? SiftRoute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant129" /> class.
        /// </summary>
        /// <param name="ownerId"></param>
        /// <param name="source"></param>
        /// <param name="cause"></param>
        /// <param name="blockReason"></param>
        /// <param name="siftRoute"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant129(
            string ownerId,
            string source,
            string cause,
            string? blockReason,
            global::Vercel.UserEventPayloadVariant129SiftRoute? siftRoute)
        {
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Cause = cause ?? throw new global::System.ArgumentNullException(nameof(cause));
            this.BlockReason = blockReason;
            this.SiftRoute = siftRoute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant129" /> class.
        /// </summary>
        public UserEventPayloadVariant129()
        {
        }
    }
}