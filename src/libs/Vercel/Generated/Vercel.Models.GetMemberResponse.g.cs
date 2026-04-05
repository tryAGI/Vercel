
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMemberResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// "The `ADMIN` role, by default, is provided to users capable of installing integrations, while the `USER` role can be granted to Vercel users with the Vercel `Billing` or Vercel `Viewer` role, which are considered to be Read-Only roles."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetMemberResponseRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetMemberResponseRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("globalUserId")]
        public string? GlobalUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userEmail")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMemberResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="role">
        /// "The `ADMIN` role, by default, is provided to users capable of installing integrations, while the `USER` role can be granted to Vercel users with the Vercel `Billing` or Vercel `Viewer` role, which are considered to be Read-Only roles."
        /// </param>
        /// <param name="globalUserId"></param>
        /// <param name="userEmail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMemberResponse(
            string id,
            global::Vercel.GetMemberResponseRole role,
            string? globalUserId,
            string? userEmail)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Role = role;
            this.GlobalUserId = globalUserId;
            this.UserEmail = userEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMemberResponse" /> class.
        /// </summary>
        public GetMemberResponse()
        {
        }
    }
}