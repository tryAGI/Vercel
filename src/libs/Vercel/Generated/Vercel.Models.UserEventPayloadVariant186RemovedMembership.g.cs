
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant186RemovedMembership
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant186RemovedMembershipRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant186RemovedMembershipRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant186RemovedMembership" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="uid"></param>
        /// <param name="createdAt"></param>
        /// <param name="username"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant186RemovedMembership(
            global::Vercel.UserEventPayloadVariant186RemovedMembershipRole role,
            string uid,
            double createdAt,
            string? username)
        {
            this.Role = role;
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.CreatedAt = createdAt;
            this.Username = username;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant186RemovedMembership" /> class.
        /// </summary>
        public UserEventPayloadVariant186RemovedMembership()
        {
        }
    }
}