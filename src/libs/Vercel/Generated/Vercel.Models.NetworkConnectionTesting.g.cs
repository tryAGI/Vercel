
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether both dedicated connection test sources are provisioned and ready. Feature flag access and management permission are checked on submission.
    /// </summary>
    public sealed partial class NetworkConnectionTesting
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Available { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkConnectionTesting" /> class.
        /// </summary>
        /// <param name="available"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkConnectionTesting(
            bool available)
        {
            this.Available = available;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkConnectionTesting" /> class.
        /// </summary>
        public NetworkConnectionTesting()
        {
        }

    }
}