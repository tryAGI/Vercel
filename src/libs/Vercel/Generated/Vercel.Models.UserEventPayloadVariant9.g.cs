
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessGroup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant9AccessGroup AccessGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousName")]
        public string? PreviousName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamRoles")]
        public global::System.Collections.Generic.IList<string>? TeamRoles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousTeamRoles")]
        public global::System.Collections.Generic.IList<string>? PreviousTeamRoles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamPermissions")]
        public global::System.Collections.Generic.IList<string>? TeamPermissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousTeamPermissions")]
        public global::System.Collections.Generic.IList<string>? PreviousTeamPermissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlementsAdded")]
        public global::System.Collections.Generic.IList<string>? EntitlementsAdded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlementsRemoved")]
        public global::System.Collections.Generic.IList<string>? EntitlementsRemoved { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant9" /> class.
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <param name="name"></param>
        /// <param name="previousName"></param>
        /// <param name="teamRoles"></param>
        /// <param name="previousTeamRoles"></param>
        /// <param name="teamPermissions"></param>
        /// <param name="previousTeamPermissions"></param>
        /// <param name="entitlementsAdded"></param>
        /// <param name="entitlementsRemoved"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant9(
            global::Vercel.UserEventPayloadVariant9AccessGroup accessGroup,
            string? name,
            string? previousName,
            global::System.Collections.Generic.IList<string>? teamRoles,
            global::System.Collections.Generic.IList<string>? previousTeamRoles,
            global::System.Collections.Generic.IList<string>? teamPermissions,
            global::System.Collections.Generic.IList<string>? previousTeamPermissions,
            global::System.Collections.Generic.IList<string>? entitlementsAdded,
            global::System.Collections.Generic.IList<string>? entitlementsRemoved)
        {
            this.AccessGroup = accessGroup ?? throw new global::System.ArgumentNullException(nameof(accessGroup));
            this.Name = name;
            this.PreviousName = previousName;
            this.TeamRoles = teamRoles;
            this.PreviousTeamRoles = previousTeamRoles;
            this.TeamPermissions = teamPermissions;
            this.PreviousTeamPermissions = previousTeamPermissions;
            this.EntitlementsAdded = entitlementsAdded;
            this.EntitlementsRemoved = entitlementsRemoved;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant9" /> class.
        /// </summary>
        public UserEventPayloadVariant9()
        {
        }
    }
}