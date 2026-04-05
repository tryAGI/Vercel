
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Resource configuration for the team.
    /// </summary>
    public sealed partial class PatchTeamRequestResourceConfig
    {
        /// <summary>
        /// Build machine configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachine")]
        public global::Vercel.PatchTeamRequestResourceConfigBuildMachine? BuildMachine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestResourceConfig" /> class.
        /// </summary>
        /// <param name="buildMachine">
        /// Build machine configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamRequestResourceConfig(
            global::Vercel.PatchTeamRequestResourceConfigBuildMachine? buildMachine)
        {
            this.BuildMachine = buildMachine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestResourceConfig" /> class.
        /// </summary>
        public PatchTeamRequestResourceConfig()
        {
        }
    }
}