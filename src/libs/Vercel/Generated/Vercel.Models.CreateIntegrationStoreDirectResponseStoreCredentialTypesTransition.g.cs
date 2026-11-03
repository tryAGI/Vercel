
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The latest requested change of `credentialTypes`, and when the provider completed it.
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreCredentialTypesTransition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public double? CompletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RequestedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreCredentialTypesTransitionToItem> To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreCredentialTypesTransition" /> class.
        /// </summary>
        /// <param name="requestedAt"></param>
        /// <param name="to"></param>
        /// <param name="completedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreCredentialTypesTransition(
            double requestedAt,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreCredentialTypesTransitionToItem> to,
            double? completedAt)
        {
            this.CompletedAt = completedAt;
            this.RequestedAt = requestedAt;
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreCredentialTypesTransition" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreCredentialTypesTransition()
        {
        }

    }
}