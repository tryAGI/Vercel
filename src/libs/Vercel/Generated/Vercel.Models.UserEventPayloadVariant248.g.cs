
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant248
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directoryType")]
        public string? DirectoryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoType")]
        public string? SsoType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitedUser")]
        public global::Vercel.UserEventPayloadVariant248InvitedUser? InvitedUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitedEmail")]
        public string? InvitedEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitationRole")]
        public string? InvitationRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlements")]
        public global::System.Collections.Generic.IList<string>? Entitlements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitedUid")]
        public string? InvitedUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant248" /> class.
        /// </summary>
        /// <param name="directoryType"></param>
        /// <param name="ssoType"></param>
        /// <param name="invitedUser"></param>
        /// <param name="invitedEmail"></param>
        /// <param name="invitationRole"></param>
        /// <param name="entitlements"></param>
        /// <param name="invitedUid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant248(
            string? directoryType,
            string? ssoType,
            global::Vercel.UserEventPayloadVariant248InvitedUser? invitedUser,
            string? invitedEmail,
            string? invitationRole,
            global::System.Collections.Generic.IList<string>? entitlements,
            string? invitedUid)
        {
            this.DirectoryType = directoryType;
            this.SsoType = ssoType;
            this.InvitedUser = invitedUser;
            this.InvitedEmail = invitedEmail;
            this.InvitationRole = invitationRole;
            this.Entitlements = entitlements;
            this.InvitedUid = invitedUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant248" /> class.
        /// </summary>
        public UserEventPayloadVariant248()
        {
        }
    }
}