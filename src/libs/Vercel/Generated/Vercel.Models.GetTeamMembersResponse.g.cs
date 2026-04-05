
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTeamMembersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetTeamMembersResponseMember> Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailInviteCodes")]
        public global::System.Collections.Generic.IList<global::Vercel.GetTeamMembersResponseEmailInviteCode>? EmailInviteCodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetTeamMembersResponsePagination Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamMembersResponse" /> class.
        /// </summary>
        /// <param name="members"></param>
        /// <param name="pagination"></param>
        /// <param name="emailInviteCodes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTeamMembersResponse(
            global::System.Collections.Generic.IList<global::Vercel.GetTeamMembersResponseMember> members,
            global::Vercel.GetTeamMembersResponsePagination pagination,
            global::System.Collections.Generic.IList<global::Vercel.GetTeamMembersResponseEmailInviteCode>? emailInviteCodes)
        {
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
            this.EmailInviteCodes = emailInviteCodes;
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamMembersResponse" /> class.
        /// </summary>
        public GetTeamMembersResponse()
        {
        }
    }
}