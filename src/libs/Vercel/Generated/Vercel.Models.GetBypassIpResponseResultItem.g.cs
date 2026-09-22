
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetBypassIpResponseResultItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetBypassIpResponseResultItemActionJsonConverter))]
        public global::Vercel.GetBypassIpResponseResultItemAction? Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ActorId")]
        public string? ActorId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("CreatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("DeletedAt")]
        public string? DeletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ExpiresAt")]
        public double? ExpiresAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Ip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ip { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("IsProjectRule")]
        public bool? IsProjectRule { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Note")]
        public string? Note { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("OwnerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ProjectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("UpdatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("UpdatedAtHour")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAtHour { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBypassIpResponseResultItem" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="domain"></param>
        /// <param name="id"></param>
        /// <param name="ip"></param>
        /// <param name="ownerId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedAtHour"></param>
        /// <param name="action"></param>
        /// <param name="actorId"></param>
        /// <param name="deletedAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="isProjectRule"></param>
        /// <param name="note"></param>
        /// <param name="projectId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBypassIpResponseResultItem(
            string createdAt,
            string domain,
            string id,
            string ip,
            string ownerId,
            string updatedAt,
            string updatedAtHour,
            global::Vercel.GetBypassIpResponseResultItemAction? action,
            string? actorId,
            string? deletedAt,
            double? expiresAt,
            bool? isProjectRule,
            string? note,
            string? projectId)
        {
            this.Action = action;
            this.ActorId = actorId;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.DeletedAt = deletedAt;
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.ExpiresAt = expiresAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Ip = ip ?? throw new global::System.ArgumentNullException(nameof(ip));
            this.IsProjectRule = isProjectRule;
            this.Note = note;
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.ProjectId = projectId;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.UpdatedAtHour = updatedAtHour ?? throw new global::System.ArgumentNullException(nameof(updatedAtHour));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBypassIpResponseResultItem" /> class.
        /// </summary>
        public GetBypassIpResponseResultItem()
        {
        }

    }
}