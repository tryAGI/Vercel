
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Managed-client metadata exposed without leaking the manager client or installation identifiers.
    /// </summary>
    public sealed partial class CreateConnectorResponseManaged
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync")]
        public bool? Sync { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseManaged" /> class.
        /// </summary>
        /// <param name="sync"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorResponseManaged(
            bool? sync)
        {
            this.Sync = sync;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseManaged" /> class.
        /// </summary>
        public CreateConnectorResponseManaged()
        {
        }

    }
}