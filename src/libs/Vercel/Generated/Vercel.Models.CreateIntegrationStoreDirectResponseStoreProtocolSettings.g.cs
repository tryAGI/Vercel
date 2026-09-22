
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreProtocolSettings
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthentication? Authentication { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentation")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProtocolSettingsExperimentation? Experimentation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProtocolSettings" /> class.
        /// </summary>
        /// <param name="authentication"></param>
        /// <param name="experimentation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreProtocolSettings(
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthentication? authentication,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProtocolSettingsExperimentation? experimentation)
        {
            this.Authentication = authentication;
            this.Experimentation = experimentation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProtocolSettings" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProtocolSettings()
        {
        }

    }
}