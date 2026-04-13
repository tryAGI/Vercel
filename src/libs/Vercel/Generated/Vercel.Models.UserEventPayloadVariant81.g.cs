
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant81
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant81" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="teamId"></param>
        /// <param name="ownerName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant81(
            string name,
            string userId,
            string teamId,
            string ownerName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.OwnerName = ownerName ?? throw new global::System.ArgumentNullException(nameof(ownerName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant81" /> class.
        /// </summary>
        public UserEventPayloadVariant81()
        {
        }
    }
}