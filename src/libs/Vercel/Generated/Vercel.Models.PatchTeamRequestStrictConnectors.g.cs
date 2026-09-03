
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When enabled, creating and managing connectors requires Owner role.
    /// </summary>
    public sealed partial class PatchTeamRequestStrictConnectors
    {
        /// <summary>
        /// Enable or disable requiring Owner role to manage connectors.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestStrictConnectors" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Enable or disable requiring Owner role to manage connectors.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamRequestStrictConnectors(
            bool enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestStrictConnectors" /> class.
        /// </summary>
        public PatchTeamRequestStrictConnectors()
        {
        }

    }
}