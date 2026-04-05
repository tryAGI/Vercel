
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
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::Vercel.UserEventPayloadVariant27Resources? Resources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant27Permission>? Permissions { get; set; }

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
        /// <param name="resources"></param>
        /// <param name="permissions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant27(
            string appName,
            string? appId,
            global::Vercel.UserEventPayloadVariant27Resources? resources,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant27Permission>? permissions)
        {
            this.AppName = appName ?? throw new global::System.ArgumentNullException(nameof(appName));
            this.AppId = appId;
            this.Resources = resources;
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant27" /> class.
        /// </summary>
        public UserEventPayloadVariant27()
        {
        }
    }
}