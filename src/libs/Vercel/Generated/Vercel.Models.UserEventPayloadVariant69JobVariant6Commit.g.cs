
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant69JobVariant6Commit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorAvatar")]
        public string? AuthorAvatar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorEmail")]
        public string? AuthorEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorId")]
        public double? AuthorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorLogin")]
        public string? AuthorLogin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorName")]
        public string? AuthorName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant69JobVariant6Commit" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="authorAvatar"></param>
        /// <param name="authorEmail"></param>
        /// <param name="authorId"></param>
        /// <param name="authorLogin"></param>
        /// <param name="authorName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant69JobVariant6Commit(
            string id,
            string? authorAvatar,
            string? authorEmail,
            double? authorId,
            string? authorLogin,
            string? authorName)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AuthorAvatar = authorAvatar;
            this.AuthorEmail = authorEmail;
            this.AuthorId = authorId;
            this.AuthorLogin = authorLogin;
            this.AuthorName = authorName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant69JobVariant6Commit" /> class.
        /// </summary>
        public UserEventPayloadVariant69JobVariant6Commit()
        {
        }
    }
}