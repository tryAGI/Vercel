
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
        [global::System.Text.Json.Serialization.JsonPropertyName("nextScopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant27NextScope> NextScopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPermissions")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant27NextPermission>? NextPermissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant27" /> class.
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="nextScopes"></param>
        /// <param name="appId"></param>
        /// <param name="nextPermissions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant27(
            string appName,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant27NextScope> nextScopes,
            string? appId,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant27NextPermission>? nextPermissions)
        {
            this.AppName = appName ?? throw new global::System.ArgumentNullException(nameof(appName));
            this.AppId = appId;
            this.NextScopes = nextScopes ?? throw new global::System.ArgumentNullException(nameof(nextScopes));
            this.NextPermissions = nextPermissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant27" /> class.
        /// </summary>
        public UserEventPayloadVariant27()
        {
        }
    }
}