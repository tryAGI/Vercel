
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessGroup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant6AccessGroup AccessGroup { get; set; }

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
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant6" /> class.
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <param name="teamRoles"></param>
        /// <param name="teamPermissions"></param>
        /// <param name="entitlements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant6(
            global::Vercel.UserEventPayloadVariant6AccessGroup accessGroup,
            global::System.Collections.Generic.IList<string>? teamRoles,
            global::System.Collections.Generic.IList<string>? teamPermissions,
            global::System.Collections.Generic.IList<string>? entitlements)
        {
            this.AccessGroup = accessGroup ?? throw new global::System.ArgumentNullException(nameof(accessGroup));
            this.TeamRoles = teamRoles;
            this.TeamPermissions = teamPermissions;
            this.Entitlements = entitlements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant6" /> class.
        /// </summary>
        public UserEventPayloadVariant6()
        {
        }
    }
}