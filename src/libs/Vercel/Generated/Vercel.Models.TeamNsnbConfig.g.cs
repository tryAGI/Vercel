
#nullable enable

namespace Vercel
{
    /// <summary>
    /// NSNB configuration for the team.
    /// </summary>
    public sealed partial class TeamNsnbConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.TeamNsnbConfigPreferenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.TeamNsnbConfigPreference Preference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamNsnbConfig" /> class.
        /// </summary>
        /// <param name="preference"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamNsnbConfig(
            global::Vercel.TeamNsnbConfigPreference preference)
        {
            this.Preference = preference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamNsnbConfig" /> class.
        /// </summary>
        public TeamNsnbConfig()
        {
        }
    }
}