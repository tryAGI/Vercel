
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchTeamRequestSaml
    {
        /// <summary>
        /// Require that members of the team use SAML Single Sign-On.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforced")]
        public bool? Enforced { get; set; }

        /// <summary>
        /// Directory groups to role or access group mappings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public object? Roles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestSaml" /> class.
        /// </summary>
        /// <param name="enforced">
        /// Require that members of the team use SAML Single Sign-On.<br/>
        /// Example: true
        /// </param>
        /// <param name="roles">
        /// Directory groups to role or access group mappings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamRequestSaml(
            bool? enforced,
            object? roles)
        {
            this.Enforced = enforced;
            this.Roles = roles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestSaml" /> class.
        /// </summary>
        public PatchTeamRequestSaml()
        {
        }
    }
}