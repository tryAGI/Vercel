
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Encrypted Iroh endpoint data for internal consumers.
    /// </summary>
    public sealed partial class GetProjectBoxesResponseDaemonReplicasItemIroh
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKeyCiphertext")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicKeyCiphertext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonReplicasItemIroh" /> class.
        /// </summary>
        /// <param name="publicKeyCiphertext"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectBoxesResponseDaemonReplicasItemIroh(
            string publicKeyCiphertext)
        {
            this.PublicKeyCiphertext = publicKeyCiphertext ?? throw new global::System.ArgumentNullException(nameof(publicKeyCiphertext));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonReplicasItemIroh" /> class.
        /// </summary>
        public GetProjectBoxesResponseDaemonReplicasItemIroh()
        {
        }

    }
}