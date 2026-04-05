
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteRoutesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DeletedCount { get; set; }

        /// <summary>
        /// A version of routing rules stored in S3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.DeleteRoutesResponseVersion Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRoutesResponse" /> class.
        /// </summary>
        /// <param name="deletedCount"></param>
        /// <param name="version">
        /// A version of routing rules stored in S3.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteRoutesResponse(
            double deletedCount,
            global::Vercel.DeleteRoutesResponseVersion version)
        {
            this.DeletedCount = deletedCount;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRoutesResponse" /> class.
        /// </summary>
        public DeleteRoutesResponse()
        {
        }
    }
}