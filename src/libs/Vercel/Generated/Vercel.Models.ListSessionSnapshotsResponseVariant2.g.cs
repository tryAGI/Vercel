
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListSessionSnapshotsResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.Snapshot> Snapshots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListSessionSnapshotsResponseVariant2Pagination Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSessionSnapshotsResponseVariant2" /> class.
        /// </summary>
        /// <param name="snapshots"></param>
        /// <param name="pagination"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSessionSnapshotsResponseVariant2(
            global::System.Collections.Generic.IList<global::Vercel.Snapshot> snapshots,
            global::Vercel.ListSessionSnapshotsResponseVariant2Pagination pagination)
        {
            this.Snapshots = snapshots ?? throw new global::System.ArgumentNullException(nameof(snapshots));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSessionSnapshotsResponseVariant2" /> class.
        /// </summary>
        public ListSessionSnapshotsResponseVariant2()
        {
        }
    }
}