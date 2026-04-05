
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectTransferRequestRequest
    {
        /// <summary>
        /// The URL to send a webhook to when the transfer is accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callbackUrl")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// The secret to use to sign the webhook payload with HMAC-SHA256.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callbackSecret")]
        public string? CallbackSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectTransferRequestRequest" /> class.
        /// </summary>
        /// <param name="callbackUrl">
        /// The URL to send a webhook to when the transfer is accepted.
        /// </param>
        /// <param name="callbackSecret">
        /// The secret to use to sign the webhook payload with HMAC-SHA256.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectTransferRequestRequest(
            string? callbackUrl,
            string? callbackSecret)
        {
            this.CallbackUrl = callbackUrl;
            this.CallbackSecret = callbackSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectTransferRequestRequest" /> class.
        /// </summary>
        public CreateProjectTransferRequestRequest()
        {
        }
    }
}