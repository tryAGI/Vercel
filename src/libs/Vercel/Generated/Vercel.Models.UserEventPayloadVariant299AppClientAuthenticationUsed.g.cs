
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant299AppClientAuthenticationUsed
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant299AppClientAuthenticationUsedMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant299AppClientAuthenticationUsedMethod Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretId")]
        public string? SecretId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant299AppClientAuthenticationUsed" /> class.
        /// </summary>
        /// <param name="method"></param>
        /// <param name="secretId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant299AppClientAuthenticationUsed(
            global::Vercel.UserEventPayloadVariant299AppClientAuthenticationUsedMethod method,
            string? secretId)
        {
            this.Method = method;
            this.SecretId = secretId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant299AppClientAuthenticationUsed" /> class.
        /// </summary>
        public UserEventPayloadVariant299AppClientAuthenticationUsed()
        {
        }
    }
}