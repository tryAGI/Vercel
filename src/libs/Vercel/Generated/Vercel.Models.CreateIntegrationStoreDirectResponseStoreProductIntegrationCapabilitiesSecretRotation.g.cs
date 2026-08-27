
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesSecretRotation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDelayHours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxDelayHours { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customRotationWarning")]
        public string? CustomRotationWarning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesSecretRotation" /> class.
        /// </summary>
        /// <param name="maxDelayHours"></param>
        /// <param name="customRotationWarning"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesSecretRotation(
            double maxDelayHours,
            string? customRotationWarning)
        {
            this.MaxDelayHours = maxDelayHours;
            this.CustomRotationWarning = customRotationWarning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesSecretRotation" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesSecretRotation()
        {
        }

    }
}