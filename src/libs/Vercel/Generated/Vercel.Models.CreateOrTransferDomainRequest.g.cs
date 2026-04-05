
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrTransferDomainRequest
    {
        /// <summary>
        /// The domain operation to perform. It can be either `add` or `move-in`.<br/>
        /// Example: add
        /// </summary>
        /// <example>add</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrTransferDomainRequest" /> class.
        /// </summary>
        /// <param name="method">
        /// The domain operation to perform. It can be either `add` or `move-in`.<br/>
        /// Example: add
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrTransferDomainRequest(
            string? method)
        {
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrTransferDomainRequest" /> class.
        /// </summary>
        public CreateOrTransferDomainRequest()
        {
        }
    }
}