
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AddRepositoryPermissionResponse
    {
        /// <summary>
        /// A team's access grant to a Vercel Container Registry repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.VcrRepositoryPermission Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRepositoryPermissionResponse" /> class.
        /// </summary>
        /// <param name="permission">
        /// A team's access grant to a Vercel Container Registry repository.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddRepositoryPermissionResponse(
            global::Vercel.VcrRepositoryPermission permission)
        {
            this.Permission = permission ?? throw new global::System.ArgumentNullException(nameof(permission));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRepositoryPermissionResponse" /> class.
        /// </summary>
        public AddRepositoryPermissionResponse()
        {
        }

    }
}