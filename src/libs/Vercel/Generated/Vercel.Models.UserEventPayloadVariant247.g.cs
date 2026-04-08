
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant247
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DeletedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inviteIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> InviteIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant247" /> class.
        /// </summary>
        /// <param name="deletedCount"></param>
        /// <param name="inviteIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant247(
            double deletedCount,
            global::System.Collections.Generic.IList<string> inviteIds)
        {
            this.DeletedCount = deletedCount;
            this.InviteIds = inviteIds ?? throw new global::System.ArgumentNullException(nameof(inviteIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant247" /> class.
        /// </summary>
        public UserEventPayloadVariant247()
        {
        }
    }
}