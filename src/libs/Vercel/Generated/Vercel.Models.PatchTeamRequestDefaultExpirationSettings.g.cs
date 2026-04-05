
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchTeamRequestDefaultExpirationSettings
    {
        /// <summary>
        /// The time period to keep non-production deployments for<br/>
        /// Example: 1y
        /// </summary>
        /// <example>1y</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PatchTeamRequestDefaultExpirationSettingsExpirationJsonConverter))]
        public global::Vercel.PatchTeamRequestDefaultExpirationSettingsExpiration? Expiration { get; set; }

        /// <summary>
        /// The time period to keep production deployments for<br/>
        /// Example: 1y
        /// </summary>
        /// <example>1y</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationProduction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PatchTeamRequestDefaultExpirationSettingsExpirationProductionJsonConverter))]
        public global::Vercel.PatchTeamRequestDefaultExpirationSettingsExpirationProduction? ExpirationProduction { get; set; }

        /// <summary>
        /// The time period to keep canceled deployments for<br/>
        /// Example: 1y
        /// </summary>
        /// <example>1y</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationCanceled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PatchTeamRequestDefaultExpirationSettingsExpirationCanceledJsonConverter))]
        public global::Vercel.PatchTeamRequestDefaultExpirationSettingsExpirationCanceled? ExpirationCanceled { get; set; }

        /// <summary>
        /// The time period to keep errored deployments for<br/>
        /// Example: 1y
        /// </summary>
        /// <example>1y</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationErrored")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PatchTeamRequestDefaultExpirationSettingsExpirationErroredJsonConverter))]
        public global::Vercel.PatchTeamRequestDefaultExpirationSettingsExpirationErrored? ExpirationErrored { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestDefaultExpirationSettings" /> class.
        /// </summary>
        /// <param name="expiration">
        /// The time period to keep non-production deployments for<br/>
        /// Example: 1y
        /// </param>
        /// <param name="expirationProduction">
        /// The time period to keep production deployments for<br/>
        /// Example: 1y
        /// </param>
        /// <param name="expirationCanceled">
        /// The time period to keep canceled deployments for<br/>
        /// Example: 1y
        /// </param>
        /// <param name="expirationErrored">
        /// The time period to keep errored deployments for<br/>
        /// Example: 1y
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamRequestDefaultExpirationSettings(
            global::Vercel.PatchTeamRequestDefaultExpirationSettingsExpiration? expiration,
            global::Vercel.PatchTeamRequestDefaultExpirationSettingsExpirationProduction? expirationProduction,
            global::Vercel.PatchTeamRequestDefaultExpirationSettingsExpirationCanceled? expirationCanceled,
            global::Vercel.PatchTeamRequestDefaultExpirationSettingsExpirationErrored? expirationErrored)
        {
            this.Expiration = expiration;
            this.ExpirationProduction = expirationProduction;
            this.ExpirationCanceled = expirationCanceled;
            this.ExpirationErrored = expirationErrored;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestDefaultExpirationSettings" /> class.
        /// </summary>
        public PatchTeamRequestDefaultExpirationSettings()
        {
        }
    }
}