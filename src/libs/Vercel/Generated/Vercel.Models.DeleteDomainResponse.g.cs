
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteDomainResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDomainResponse" /> class.
        /// </summary>
        /// <param name="uid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteDomainResponse(
            string uid)
        {
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDomainResponse" /> class.
        /// </summary>
        public DeleteDomainResponse()
        {
        }
    }
}