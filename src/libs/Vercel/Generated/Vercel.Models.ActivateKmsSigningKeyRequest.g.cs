
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ActivateKmsSigningKeyRequest
    {
        /// <summary>
        /// How many hours after activation the previously-active key should stop being used. Defaults to a 1 hour grace period so already-issued tokens keep verifying.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revokePreviousAfterHours")]
        public double? RevokePreviousAfterHours { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateKmsSigningKeyRequest" /> class.
        /// </summary>
        /// <param name="revokePreviousAfterHours">
        /// How many hours after activation the previously-active key should stop being used. Defaults to a 1 hour grace period so already-issued tokens keep verifying.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivateKmsSigningKeyRequest(
            double? revokePreviousAfterHours)
        {
            this.RevokePreviousAfterHours = revokePreviousAfterHours;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateKmsSigningKeyRequest" /> class.
        /// </summary>
        public ActivateKmsSigningKeyRequest()
        {
        }

    }
}