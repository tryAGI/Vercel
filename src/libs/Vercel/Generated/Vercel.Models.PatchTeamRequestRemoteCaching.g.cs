
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether or not remote caching is enabled for the team
    /// </summary>
    public sealed partial class PatchTeamRequestRemoteCaching
    {
        /// <summary>
        /// Enable or disable remote caching for the team.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestRemoteCaching" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Enable or disable remote caching for the team.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamRequestRemoteCaching(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestRemoteCaching" /> class.
        /// </summary>
        public PatchTeamRequestRemoteCaching()
        {
        }
    }
}