
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A paginated list of Vercel Container Registry repository permissions.
    /// </summary>
    public sealed partial class VcrRepositoryPermissionList
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.VcrRepositoryPermission> Permissions { get; set; }

        /// <summary>
        /// Cursor to fetch the next page of results, when more are available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrRepositoryPermissionList" /> class.
        /// </summary>
        /// <param name="permissions"></param>
        /// <param name="nextCursor">
        /// Cursor to fetch the next page of results, when more are available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VcrRepositoryPermissionList(
            global::System.Collections.Generic.IList<global::Vercel.VcrRepositoryPermission> permissions,
            string? nextCursor)
        {
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrRepositoryPermissionList" /> class.
        /// </summary>
        public VcrRepositoryPermissionList()
        {
        }

    }
}