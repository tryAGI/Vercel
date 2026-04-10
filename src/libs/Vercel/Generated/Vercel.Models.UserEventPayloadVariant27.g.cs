
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant27
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
        [global::System.Text.Json.Serialization.JsonPropertyName("installationId")]
        public string? InstallationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before")]
        public global::Vercel.UserEventPayloadVariant27Before? Before { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after")]
        public global::Vercel.UserEventPayloadVariant27After? After { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant27" /> class.
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="appId"></param>
        /// <param name="installationId"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant27(
            string appName,
            string? appId,
            string? installationId,
            global::Vercel.UserEventPayloadVariant27Before? before,
            global::Vercel.UserEventPayloadVariant27After? after)
        {
            this.AppName = appName ?? throw new global::System.ArgumentNullException(nameof(appName));
            this.AppId = appId;
            this.InstallationId = installationId;
            this.Before = before;
            this.After = after;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant27" /> class.
        /// </summary>
        public UserEventPayloadVariant27()
        {
        }
    }
}