
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTeamMemberRequestJoinedFrom
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoUserId")]
        public object? SsoUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTeamMemberRequestJoinedFrom" /> class.
        /// </summary>
        /// <param name="ssoUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTeamMemberRequestJoinedFrom(
            object? ssoUserId)
        {
            this.SsoUserId = ssoUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTeamMemberRequestJoinedFrom" /> class.
        /// </summary>
        public UpdateTeamMemberRequestJoinedFrom()
        {
        }
    }
}