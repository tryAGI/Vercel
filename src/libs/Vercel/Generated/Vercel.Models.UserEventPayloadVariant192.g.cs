
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant192
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
        [global::System.Text.Json.Serialization.JsonPropertyName("passwordProtection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UserEventPayloadVariant192PasswordProtectionEnum, global::Vercel.UserEventPayloadVariant192PasswordProtectionEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant192PasswordProtectionEnum, global::Vercel.UserEventPayloadVariant192PasswordProtectionEnum2?>? PasswordProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldPasswordProtection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UserEventPayloadVariant192OldPasswordProtectionEnum, global::Vercel.UserEventPayloadVariant192OldPasswordProtectionEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant192OldPasswordProtectionEnum, global::Vercel.UserEventPayloadVariant192OldPasswordProtectionEnum2?>? OldPasswordProtection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant192" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="passwordProtection"></param>
        /// <param name="oldPasswordProtection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant192(
            string? projectId,
            string? projectName,
            global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant192PasswordProtectionEnum, global::Vercel.UserEventPayloadVariant192PasswordProtectionEnum2?>? passwordProtection,
            global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant192OldPasswordProtectionEnum, global::Vercel.UserEventPayloadVariant192OldPasswordProtectionEnum2?>? oldPasswordProtection)
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.PasswordProtection = passwordProtection;
            this.OldPasswordProtection = oldPasswordProtection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant192" /> class.
        /// </summary>
        public UserEventPayloadVariant192()
        {
        }
    }
}