
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestDeleteResponse
    {
        /// <summary>
        /// Unique identifier of the User who has initiated deletion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Email address of the User who has initiated deletion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// User deletion progress status.<br/>
        /// Example: Verification email sent
        /// </summary>
        /// <example>Verification email sent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestDeleteResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the User who has initiated deletion.
        /// </param>
        /// <param name="email">
        /// Email address of the User who has initiated deletion.
        /// </param>
        /// <param name="message">
        /// User deletion progress status.<br/>
        /// Example: Verification email sent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestDeleteResponse(
            string id,
            string email,
            string message)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestDeleteResponse" /> class.
        /// </summary>
        public RequestDeleteResponse()
        {
        }
    }
}