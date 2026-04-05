
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Successful response.
    /// </summary>
    public sealed partial class GetAuthUserResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AuthUser, global::Vercel.AuthUserLimited>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AuthUser, global::Vercel.AuthUserLimited> User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthUserResponse" /> class.
        /// </summary>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAuthUserResponse(
            global::Vercel.OneOf<global::Vercel.AuthUser, global::Vercel.AuthUserLimited> user)
        {
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthUserResponse" /> class.
        /// </summary>
        public GetAuthUserResponse()
        {
        }
    }
}