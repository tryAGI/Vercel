
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Build machine configuration.
    /// </summary>
    public sealed partial class PatchTeamRequestResourceConfigBuildMachine
    {
        /// <summary>
        /// Default build machine type for new builds: standard, enhanced, turbo, or elastic.<br/>
        /// Example: standard
        /// </summary>
        /// <example>standard</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PatchTeamRequestResourceConfigBuildMachineDefaultJsonConverter))]
        public global::Vercel.PatchTeamRequestResourceConfigBuildMachineDefault? Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestResourceConfigBuildMachine" /> class.
        /// </summary>
        /// <param name="default">
        /// Default build machine type for new builds: standard, enhanced, turbo, or elastic.<br/>
        /// Example: standard
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamRequestResourceConfigBuildMachine(
            global::Vercel.PatchTeamRequestResourceConfigBuildMachineDefault? @default)
        {
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestResourceConfigBuildMachine" /> class.
        /// </summary>
        public PatchTeamRequestResourceConfigBuildMachine()
        {
        }
    }
}