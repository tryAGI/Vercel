
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JoinTeamRequest
    {
        /// <summary>
        /// The invite code to join the team.<br/>
        /// Example: fisdh38aejkeivn34nslfore9vjtn4ls
        /// </summary>
        /// <example>fisdh38aejkeivn34nslfore9vjtn4ls</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inviteCode")]
        public string? InviteCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinTeamRequest" /> class.
        /// </summary>
        /// <param name="inviteCode">
        /// The invite code to join the team.<br/>
        /// Example: fisdh38aejkeivn34nslfore9vjtn4ls
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JoinTeamRequest(
            string? inviteCode)
        {
            this.InviteCode = inviteCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinTeamRequest" /> class.
        /// </summary>
        public JoinTeamRequest()
        {
        }
    }
}