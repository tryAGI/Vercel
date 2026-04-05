
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Description of why a project was rolled back, and by whom. Note that lastAliasRequest contains the from/to details of the rollback.
    /// </summary>
    public sealed partial class UpdateMicrofrontendsResponseRollbackDescription
    {
        /// <summary>
        /// The user who rolled back the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The username of the user who rolled back the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// User-supplied explanation of why they rolled back the project. Limited to 250 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Timestamp of when the rollback was requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseRollbackDescription" /> class.
        /// </summary>
        /// <param name="userId">
        /// The user who rolled back the project.
        /// </param>
        /// <param name="username">
        /// The username of the user who rolled back the project.
        /// </param>
        /// <param name="description">
        /// User-supplied explanation of why they rolled back the project. Limited to 250 characters.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of when the rollback was requested.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMicrofrontendsResponseRollbackDescription(
            string userId,
            string username,
            string description,
            double createdAt)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseRollbackDescription" /> class.
        /// </summary>
        public UpdateMicrofrontendsResponseRollbackDescription()
        {
        }
    }
}