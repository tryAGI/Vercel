
#nullable enable

namespace Vercel
{
    /// <summary>
    /// NSNB configuration for the team.
    /// </summary>
    public sealed partial class PatchTeamRequestNsnbConfig
    {
        /// <summary>
        /// The NSNB preference for the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PatchTeamRequestNsnbConfigPreferenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PatchTeamRequestNsnbConfigPreference Preference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestNsnbConfig" /> class.
        /// </summary>
        /// <param name="preference">
        /// The NSNB preference for the team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamRequestNsnbConfig(
            global::Vercel.PatchTeamRequestNsnbConfigPreference preference)
        {
            this.Preference = preference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestNsnbConfig" /> class.
        /// </summary>
        public PatchTeamRequestNsnbConfig()
        {
        }
    }
}