
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant265
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directoryType")]
        public string? DirectoryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedUser")]
        public global::Vercel.UserEventPayloadVariant265UpdatedUser? UpdatedUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousRole")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviousRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedUid")]
        public string? UpdatedUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        public string? Origin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant265" /> class.
        /// </summary>
        /// <param name="previousRole"></param>
        /// <param name="directoryType"></param>
        /// <param name="updatedUser"></param>
        /// <param name="role"></param>
        /// <param name="updatedUid"></param>
        /// <param name="origin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant265(
            string previousRole,
            string? directoryType,
            global::Vercel.UserEventPayloadVariant265UpdatedUser? updatedUser,
            string? role,
            string? updatedUid,
            string? origin)
        {
            this.DirectoryType = directoryType;
            this.UpdatedUser = updatedUser;
            this.Role = role;
            this.PreviousRole = previousRole ?? throw new global::System.ArgumentNullException(nameof(previousRole));
            this.UpdatedUid = updatedUid;
            this.Origin = origin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant265" /> class.
        /// </summary>
        public UserEventPayloadVariant265()
        {
        }
    }
}