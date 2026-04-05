
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWebhooksResponseVariant2Item
    {
        /// <summary>
        /// The webhooks events<br/>
        /// Example: deployment.created
        /// </summary>
        /// <example>deployment.created</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetWebhooksResponseVariant2ItemEvent> Events { get; set; }

        /// <summary>
        /// The webhook id<br/>
        /// Example: account_hook_GflD6EYyo7F4ViYS
        /// </summary>
        /// <example>account_hook_GflD6EYyo7F4ViYS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A string with the URL of the webhook<br/>
        /// Example: https://my-webhook.com
        /// </summary>
        /// <example>https://my-webhook.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The unique ID of the team the webhook belongs to<br/>
        /// Example: ZspSRT4ljIEEmMHgoDwKWDei
        /// </summary>
        /// <example>ZspSRT4ljIEEmMHgoDwKWDei</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// A number containing the date when the webhook was created in in milliseconds<br/>
        /// Example: 1567024758130L
        /// </summary>
        /// <example>1567024758130L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// A number containing the date when the webhook was updated in in milliseconds<br/>
        /// Example: 1567024758130L
        /// </summary>
        /// <example>1567024758130L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// The ID of the projects the webhook is associated with<br/>
        /// Example: [prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB]
        /// </summary>
        /// <example>[prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIds")]
        public global::System.Collections.Generic.IList<string>? ProjectIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWebhooksResponseVariant2Item" /> class.
        /// </summary>
        /// <param name="events">
        /// The webhooks events<br/>
        /// Example: deployment.created
        /// </param>
        /// <param name="id">
        /// The webhook id<br/>
        /// Example: account_hook_GflD6EYyo7F4ViYS
        /// </param>
        /// <param name="url">
        /// A string with the URL of the webhook<br/>
        /// Example: https://my-webhook.com
        /// </param>
        /// <param name="ownerId">
        /// The unique ID of the team the webhook belongs to<br/>
        /// Example: ZspSRT4ljIEEmMHgoDwKWDei
        /// </param>
        /// <param name="createdAt">
        /// A number containing the date when the webhook was created in in milliseconds<br/>
        /// Example: 1567024758130L
        /// </param>
        /// <param name="updatedAt">
        /// A number containing the date when the webhook was updated in in milliseconds<br/>
        /// Example: 1567024758130L
        /// </param>
        /// <param name="projectIds">
        /// The ID of the projects the webhook is associated with<br/>
        /// Example: [prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWebhooksResponseVariant2Item(
            global::System.Collections.Generic.IList<global::Vercel.GetWebhooksResponseVariant2ItemEvent> events,
            string id,
            string url,
            string ownerId,
            double createdAt,
            double updatedAt,
            global::System.Collections.Generic.IList<string>? projectIds)
        {
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectIds = projectIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWebhooksResponseVariant2Item" /> class.
        /// </summary>
        public GetWebhooksResponseVariant2Item()
        {
        }
    }
}