
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant28
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appId")]
        public string? AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretLastFourChars")]
        public string? SecretLastFourChars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant28" /> class.
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="appId"></param>
        /// <param name="secretLastFourChars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant28(
            string appName,
            string? appId,
            string? secretLastFourChars)
        {
            this.AppName = appName ?? throw new global::System.ArgumentNullException(nameof(appName));
            this.AppId = appId;
            this.SecretLastFourChars = secretLastFourChars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant28" /> class.
        /// </summary>
        public UserEventPayloadVariant28()
        {
        }
    }
}