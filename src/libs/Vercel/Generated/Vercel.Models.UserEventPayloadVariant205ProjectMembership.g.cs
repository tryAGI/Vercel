
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant205ProjectMembership
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant205ProjectMembershipRoleJsonConverter))]
        public global::Vercel.UserEventPayloadVariant205ProjectMembershipRole? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousRole")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant205ProjectMembershipPreviousRoleJsonConverter))]
        public global::Vercel.UserEventPayloadVariant205ProjectMembershipPreviousRole? PreviousRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant205ProjectMembership" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="uid"></param>
        /// <param name="createdAt"></param>
        /// <param name="username"></param>
        /// <param name="previousRole"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant205ProjectMembership(
            global::Vercel.UserEventPayloadVariant205ProjectMembershipRole? role,
            string? uid,
            double? createdAt,
            string? username,
            global::Vercel.UserEventPayloadVariant205ProjectMembershipPreviousRole? previousRole)
        {
            this.Role = role;
            this.Uid = uid;
            this.CreatedAt = createdAt;
            this.Username = username;
            this.PreviousRole = previousRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant205ProjectMembership" /> class.
        /// </summary>
        public UserEventPayloadVariant205ProjectMembership()
        {
        }
    }
}