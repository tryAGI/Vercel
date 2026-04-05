
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Information about the GitHub account for this user.
    /// </summary>
    public sealed partial class GetTeamMembersResponseMemberGithub
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        public string? Login { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamMembersResponseMemberGithub" /> class.
        /// </summary>
        /// <param name="login"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTeamMembersResponseMemberGithub(
            string? login)
        {
            this.Login = login;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamMembersResponseMemberGithub" /> class.
        /// </summary>
        public GetTeamMembersResponseMemberGithub()
        {
        }
    }
}