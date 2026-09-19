
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetBypassIpResponsePagination
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("OwnerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBypassIpResponsePagination" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ownerId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBypassIpResponsePagination(
            string id,
            string ownerId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBypassIpResponsePagination" /> class.
        /// </summary>
        public GetBypassIpResponsePagination()
        {
        }

    }
}