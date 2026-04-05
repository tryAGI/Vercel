
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamMembershipEntitlement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Entitlement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembershipEntitlement" /> class.
        /// </summary>
        /// <param name="entitlement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMembershipEntitlement(
            string entitlement)
        {
            this.Entitlement = entitlement ?? throw new global::System.ArgumentNullException(nameof(entitlement));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembershipEntitlement" /> class.
        /// </summary>
        public TeamMembershipEntitlement()
        {
        }
    }
}