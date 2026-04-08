
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant185Project
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant185ProjectRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant185ProjectRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitedUserName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvitedUserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitedUserId")]
        public string? InvitedUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant185Project" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="role"></param>
        /// <param name="invitedUserName"></param>
        /// <param name="id"></param>
        /// <param name="invitedUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant185Project(
            string name,
            global::Vercel.UserEventPayloadVariant185ProjectRole role,
            string invitedUserName,
            string? id,
            string? invitedUserId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Role = role;
            this.InvitedUserName = invitedUserName ?? throw new global::System.ArgumentNullException(nameof(invitedUserName));
            this.Id = id;
            this.InvitedUserId = invitedUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant185Project" /> class.
        /// </summary>
        public UserEventPayloadVariant185Project()
        {
        }
    }
}