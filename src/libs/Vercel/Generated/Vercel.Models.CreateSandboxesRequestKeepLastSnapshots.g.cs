
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Protect the N most recent snapshots with different expiration/deletion behavior.
    /// </summary>
    public sealed partial class CreateSandboxesRequestKeepLastSnapshots
    {
        /// <summary>
        /// Number of most recent snapshots to keep.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Expiration time in milliseconds for kept snapshots. Falls back to snapshotExpiration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>))]
        public global::Vercel.OneOf<object, int?>? Expiration { get; set; }

        /// <summary>
        /// Whether to immediately delete evicted snapshots. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteEvicted")]
        public bool? DeleteEvicted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesRequestKeepLastSnapshots" /> class.
        /// </summary>
        /// <param name="count">
        /// Number of most recent snapshots to keep.
        /// </param>
        /// <param name="expiration">
        /// Expiration time in milliseconds for kept snapshots. Falls back to snapshotExpiration.
        /// </param>
        /// <param name="deleteEvicted">
        /// Whether to immediately delete evicted snapshots. Defaults to true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxesRequestKeepLastSnapshots(
            int count,
            global::Vercel.OneOf<object, int?>? expiration,
            bool? deleteEvicted)
        {
            this.Count = count;
            this.Expiration = expiration;
            this.DeleteEvicted = deleteEvicted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesRequestKeepLastSnapshots" /> class.
        /// </summary>
        public CreateSandboxesRequestKeepLastSnapshots()
        {
        }

    }
}