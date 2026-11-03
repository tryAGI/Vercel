
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Description of why a project was rolled back, and by whom. Note that lastAliasRequest contains the from/to details of the rollback.
    /// </summary>
    public sealed partial class AutoSDKShared15ac57d28c37cbda
    {
        /// <summary>
        /// Timestamp of when the rollback was requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// User-supplied explanation of why they rolled back the project. Limited to 250 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("principal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared2899f8f1b76807edJsonConverter))]
        public global::Vercel.AutoSDKShared2899f8f1b76807ed? Principal { get; set; }

        /// <summary>
        /// The ID of the user who rolled back the project, when the principal was a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// The username of the user who rolled back the project, when the principal was a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared15ac57d28c37cbda" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Timestamp of when the rollback was requested.
        /// </param>
        /// <param name="description">
        /// User-supplied explanation of why they rolled back the project. Limited to 250 characters.
        /// </param>
        /// <param name="principal"></param>
        /// <param name="userId">
        /// The ID of the user who rolled back the project, when the principal was a user.
        /// </param>
        /// <param name="username">
        /// The username of the user who rolled back the project, when the principal was a user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared15ac57d28c37cbda(
            double createdAt,
            string description,
            global::Vercel.AutoSDKShared2899f8f1b76807ed? principal,
            string? userId,
            string? username)
        {
            this.CreatedAt = createdAt;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Principal = principal;
            this.UserId = userId;
            this.Username = username;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared15ac57d28c37cbda" /> class.
        /// </summary>
        public AutoSDKShared15ac57d28c37cbda()
        {
        }

    }
}