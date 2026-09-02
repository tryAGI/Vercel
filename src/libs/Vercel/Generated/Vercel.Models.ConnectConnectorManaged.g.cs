
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Managed connector metadata exposed without leaking the manager connector or installation identifiers.
    /// </summary>
    public sealed partial class ConnectConnectorManaged
    {
        /// <summary>
        /// Whether Vercel synchronizes provider-side configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync")]
        public bool? Sync { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorManaged" /> class.
        /// </summary>
        /// <param name="sync">
        /// Whether Vercel synchronizes provider-side configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorManaged(
            bool? sync)
        {
            this.Sync = sync;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorManaged" /> class.
        /// </summary>
        public ConnectConnectorManaged()
        {
        }

    }
}