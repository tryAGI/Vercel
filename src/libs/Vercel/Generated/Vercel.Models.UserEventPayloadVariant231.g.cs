
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant231
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoProtection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UserEventPayloadVariant231SsoProtectionEnum, global::Vercel.UserEventPayloadVariant231SsoProtectionEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant231SsoProtectionEnum, global::Vercel.UserEventPayloadVariant231SsoProtectionEnum2?>? SsoProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldSsoProtection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UserEventPayloadVariant231OldSsoProtectionEnum, global::Vercel.UserEventPayloadVariant231OldSsoProtectionEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant231OldSsoProtectionEnum, global::Vercel.UserEventPayloadVariant231OldSsoProtectionEnum2?>? OldSsoProtection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant231" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="ssoProtection"></param>
        /// <param name="oldSsoProtection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant231(
            string? projectId,
            string? projectName,
            global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant231SsoProtectionEnum, global::Vercel.UserEventPayloadVariant231SsoProtectionEnum2?>? ssoProtection,
            global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant231OldSsoProtectionEnum, global::Vercel.UserEventPayloadVariant231OldSsoProtectionEnum2?>? oldSsoProtection)
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.SsoProtection = ssoProtection;
            this.OldSsoProtection = oldSsoProtection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant231" /> class.
        /// </summary>
        public UserEventPayloadVariant231()
        {
        }
    }
}