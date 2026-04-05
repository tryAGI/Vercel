
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant105OldEnvVar
    {
        /// <summary>
        /// The date when the Shared Env Var was created.<br/>
        /// Example: 2021-02-10T13:11:49.180Z
        /// </summary>
        /// <example>2021-02-10T13:11:49.180Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// The name of the Shared Env Var.<br/>
        /// Example: my-api-key
        /// </summary>
        /// <example>my-api-key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The unique identifier of the owner (team) the Shared Env Var was created for.<br/>
        /// Example: team_LLHUOMOoDlqOp8wPE4kFo9pE
        /// </summary>
        /// <example>team_LLHUOMOoDlqOp8wPE4kFo9pE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// The unique identifier of the Shared Env Var.<br/>
        /// Example: env_XCG7t7AIHuO2SBA8667zNUiM
        /// </summary>
        /// <example>env_XCG7t7AIHuO2SBA8667zNUiM</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The unique identifier of the user who created the Shared Env Var.<br/>
        /// Example: 2qDDuGFTWXBLDNnqZfWPDp1A
        /// </summary>
        /// <example>2qDDuGFTWXBLDNnqZfWPDp1A</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// The unique identifier of the user who deleted the Shared Env Var.<br/>
        /// Example: 2qDDuGFTWXBLDNnqZfWPDp1A
        /// </summary>
        /// <example>2qDDuGFTWXBLDNnqZfWPDp1A</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedBy")]
        public string? DeletedBy { get; set; }

        /// <summary>
        /// The unique identifier of the user who last updated the Shared Env Var.<br/>
        /// Example: 2qDDuGFTWXBLDNnqZfWPDp1A
        /// </summary>
        /// <example>2qDDuGFTWXBLDNnqZfWPDp1A</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// Timestamp for when the Shared Env Var was created.<br/>
        /// Example: 1609492210000L
        /// </summary>
        /// <example>1609492210000L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp for when the Shared Env Var was (soft) deleted.<br/>
        /// Example: 1609492210000L
        /// </summary>
        /// <example>1609492210000L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        public double? DeletedAt { get; set; }

        /// <summary>
        /// Timestamp for when the Shared Env Var was last updated.<br/>
        /// Example: 1609492210000L
        /// </summary>
        /// <example>1609492210000L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// The value of the Shared Env Var.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// The unique identifiers of the projects which the Shared Env Var is linked to.<br/>
        /// Example: [prj_2WjyKQmM8ZnGcJsPWMrHRHrE, prj_2WjyKQmM8ZnGcJsPWMrasEFg]
        /// </summary>
        /// <example>[prj_2WjyKQmM8ZnGcJsPWMrHRHrE, prj_2WjyKQmM8ZnGcJsPWMrasEFg]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public global::System.Collections.Generic.IList<string>? ProjectId { get; set; }

        /// <summary>
        /// The type of this cosmos doc instance, if blank, assume secret.<br/>
        /// Example: encrypted
        /// </summary>
        /// <example>encrypted</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant105OldEnvVarTypeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant105OldEnvVarType? Type { get; set; }

        /// <summary>
        /// environments this env variable targets<br/>
        /// Example: production
        /// </summary>
        /// <example>production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant105OldEnvVarTargetItem>? Target { get; set; }

        /// <summary>
        /// whether or not this env varible applies to custom environments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applyToAllCustomEnvironments")]
        public bool? ApplyToAllCustomEnvironments { get; set; }

        /// <summary>
        /// whether or not this env variable is decrypted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decrypted")]
        public bool? Decrypted { get; set; }

        /// <summary>
        /// A user provided comment that describes what this Shared Env Var is for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// The last editor full name or username.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastEditedByDisplayName")]
        public string? LastEditedByDisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant105OldEnvVar" /> class.
        /// </summary>
        /// <param name="created">
        /// The date when the Shared Env Var was created.<br/>
        /// Example: 2021-02-10T13:11:49.180Z
        /// </param>
        /// <param name="key">
        /// The name of the Shared Env Var.<br/>
        /// Example: my-api-key
        /// </param>
        /// <param name="ownerId">
        /// The unique identifier of the owner (team) the Shared Env Var was created for.<br/>
        /// Example: team_LLHUOMOoDlqOp8wPE4kFo9pE
        /// </param>
        /// <param name="id">
        /// The unique identifier of the Shared Env Var.<br/>
        /// Example: env_XCG7t7AIHuO2SBA8667zNUiM
        /// </param>
        /// <param name="createdBy">
        /// The unique identifier of the user who created the Shared Env Var.<br/>
        /// Example: 2qDDuGFTWXBLDNnqZfWPDp1A
        /// </param>
        /// <param name="deletedBy">
        /// The unique identifier of the user who deleted the Shared Env Var.<br/>
        /// Example: 2qDDuGFTWXBLDNnqZfWPDp1A
        /// </param>
        /// <param name="updatedBy">
        /// The unique identifier of the user who last updated the Shared Env Var.<br/>
        /// Example: 2qDDuGFTWXBLDNnqZfWPDp1A
        /// </param>
        /// <param name="createdAt">
        /// Timestamp for when the Shared Env Var was created.<br/>
        /// Example: 1609492210000L
        /// </param>
        /// <param name="deletedAt">
        /// Timestamp for when the Shared Env Var was (soft) deleted.<br/>
        /// Example: 1609492210000L
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp for when the Shared Env Var was last updated.<br/>
        /// Example: 1609492210000L
        /// </param>
        /// <param name="value">
        /// The value of the Shared Env Var.
        /// </param>
        /// <param name="projectId">
        /// The unique identifiers of the projects which the Shared Env Var is linked to.<br/>
        /// Example: [prj_2WjyKQmM8ZnGcJsPWMrHRHrE, prj_2WjyKQmM8ZnGcJsPWMrasEFg]
        /// </param>
        /// <param name="type">
        /// The type of this cosmos doc instance, if blank, assume secret.<br/>
        /// Example: encrypted
        /// </param>
        /// <param name="target">
        /// environments this env variable targets<br/>
        /// Example: production
        /// </param>
        /// <param name="applyToAllCustomEnvironments">
        /// whether or not this env varible applies to custom environments
        /// </param>
        /// <param name="decrypted">
        /// whether or not this env variable is decrypted
        /// </param>
        /// <param name="comment">
        /// A user provided comment that describes what this Shared Env Var is for.
        /// </param>
        /// <param name="lastEditedByDisplayName">
        /// The last editor full name or username.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant105OldEnvVar(
            global::System.DateTime? created,
            string? key,
            string? ownerId,
            string? id,
            string? createdBy,
            string? deletedBy,
            string? updatedBy,
            double? createdAt,
            double? deletedAt,
            double? updatedAt,
            string? value,
            global::System.Collections.Generic.IList<string>? projectId,
            global::Vercel.UserEventPayloadVariant105OldEnvVarType? type,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant105OldEnvVarTargetItem>? target,
            bool? applyToAllCustomEnvironments,
            bool? decrypted,
            string? comment,
            string? lastEditedByDisplayName)
        {
            this.Created = created;
            this.Key = key;
            this.OwnerId = ownerId;
            this.Id = id;
            this.CreatedBy = createdBy;
            this.DeletedBy = deletedBy;
            this.UpdatedBy = updatedBy;
            this.CreatedAt = createdAt;
            this.DeletedAt = deletedAt;
            this.UpdatedAt = updatedAt;
            this.Value = value;
            this.ProjectId = projectId;
            this.Type = type;
            this.Target = target;
            this.ApplyToAllCustomEnvironments = applyToAllCustomEnvironments;
            this.Decrypted = decrypted;
            this.Comment = comment;
            this.LastEditedByDisplayName = lastEditedByDisplayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant105OldEnvVar" /> class.
        /// </summary>
        public UserEventPayloadVariant105OldEnvVar()
        {
        }
    }
}