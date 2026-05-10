
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Keep-last snapshot configuration.
    /// </summary>
    public sealed partial class NamedSandboxKeepLastSnapshots
    {
        /// <summary>
        /// Number of most recent snapshots to keep.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Expiration time in milliseconds for kept snapshots.<br/>
        /// Example: 604800000
        /// </summary>
        /// <example>604800000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        public double? Expiration { get; set; }

        /// <summary>
        /// Whether to immediately delete evicted snapshots.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteEvicted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DeleteEvicted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedSandboxKeepLastSnapshots" /> class.
        /// </summary>
        /// <param name="count">
        /// Number of most recent snapshots to keep.<br/>
        /// Example: 5
        /// </param>
        /// <param name="deleteEvicted">
        /// Whether to immediately delete evicted snapshots.<br/>
        /// Example: true
        /// </param>
        /// <param name="expiration">
        /// Expiration time in milliseconds for kept snapshots.<br/>
        /// Example: 604800000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamedSandboxKeepLastSnapshots(
            double count,
            bool deleteEvicted,
            double? expiration)
        {
            this.Count = count;
            this.Expiration = expiration;
            this.DeleteEvicted = deleteEvicted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedSandboxKeepLastSnapshots" /> class.
        /// </summary>
        public NamedSandboxKeepLastSnapshots()
        {
        }

    }
}