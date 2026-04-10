
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant255
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        public string? Origin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamRoles")]
        public global::System.Collections.Generic.IList<string>? TeamRoles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamPermissions")]
        public global::System.Collections.Generic.IList<string>? TeamPermissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlements")]
        public global::System.Collections.Generic.IList<string>? Entitlements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant255" /> class.
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="role"></param>
        /// <param name="origin"></param>
        /// <param name="teamRoles"></param>
        /// <param name="teamPermissions"></param>
        /// <param name="entitlements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant255(
            string uid,
            string? role,
            string? origin,
            global::System.Collections.Generic.IList<string>? teamRoles,
            global::System.Collections.Generic.IList<string>? teamPermissions,
            global::System.Collections.Generic.IList<string>? entitlements)
        {
            this.Role = role;
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Origin = origin;
            this.TeamRoles = teamRoles;
            this.TeamPermissions = teamPermissions;
            this.Entitlements = entitlements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant255" /> class.
        /// </summary>
        public UserEventPayloadVariant255()
        {
        }
    }
}