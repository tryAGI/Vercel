
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreCapabilitiesSecretRotation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDelayHours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxDelayHours { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreCapabilitiesSecretRotation" /> class.
        /// </summary>
        /// <param name="maxDelayHours"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreCapabilitiesSecretRotation(
            double maxDelayHours)
        {
            this.MaxDelayHours = maxDelayHours;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreCapabilitiesSecretRotation" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreCapabilitiesSecretRotation()
        {
        }
    }
}