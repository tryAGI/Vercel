
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestAccessToTeamResponseBitbucket
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
        /// Initializes a new instance of the <see cref="RequestAccessToTeamResponseBitbucket" /> class.
        /// </summary>
        /// <param name="login"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAccessToTeamResponseBitbucket(
            string? login)
        {
            this.Login = login;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAccessToTeamResponseBitbucket" /> class.
        /// </summary>
        public RequestAccessToTeamResponseBitbucket()
        {
        }
    }
}