
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant161Next
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cookieName")]
        public string? CookieName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Issuer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant161Next" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="deploymentType"></param>
        /// <param name="issuer"></param>
        /// <param name="cookieName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant161Next(
            string clientId,
            string deploymentType,
            string issuer,
            string? cookieName)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.CookieName = cookieName;
            this.DeploymentType = deploymentType ?? throw new global::System.ArgumentNullException(nameof(deploymentType));
            this.Issuer = issuer ?? throw new global::System.ArgumentNullException(nameof(issuer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant161Next" /> class.
        /// </summary>
        public UserEventPayloadVariant161Next()
        {
        }
    }
}