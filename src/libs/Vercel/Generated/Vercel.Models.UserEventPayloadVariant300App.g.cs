
#nullable enable

namespace Vercel
{
    /// <summary>
    /// optional since entries prior to 2025-10-13 do not contain app information
    /// </summary>
    public sealed partial class UserEventPayloadVariant300App
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// the app's name at the time the event was published (it could have changed since then)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientAuthenticationUsed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant300AppClientAuthenticationUsed ClientAuthenticationUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant300App" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="name">
        /// the app's name at the time the event was published (it could have changed since then)
        /// </param>
        /// <param name="clientAuthenticationUsed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant300App(
            string clientId,
            string name,
            global::Vercel.UserEventPayloadVariant300AppClientAuthenticationUsed clientAuthenticationUsed)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ClientAuthenticationUsed = clientAuthenticationUsed ?? throw new global::System.ArgumentNullException(nameof(clientAuthenticationUsed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant300App" /> class.
        /// </summary>
        public UserEventPayloadVariant300App()
        {
        }
    }
}