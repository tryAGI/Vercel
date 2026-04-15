
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant247
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string By { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byUid")]
        public string? ByUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasons")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant247Reason>? Reasons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedUsers")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.UserEventPayloadVariant247RemovedUsers2>? RemovedUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedMemberCount")]
        public double? RemovedMemberCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant247" /> class.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="teamId"></param>
        /// <param name="by"></param>
        /// <param name="byUid"></param>
        /// <param name="reasons"></param>
        /// <param name="removedUsers"></param>
        /// <param name="removedMemberCount"></param>
        /// <param name="timestamp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant247(
            string slug,
            string teamId,
            string by,
            string? byUid,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant247Reason>? reasons,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UserEventPayloadVariant247RemovedUsers2>? removedUsers,
            double? removedMemberCount,
            double? timestamp)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.By = by ?? throw new global::System.ArgumentNullException(nameof(by));
            this.ByUid = byUid;
            this.Reasons = reasons;
            this.RemovedUsers = removedUsers;
            this.RemovedMemberCount = removedMemberCount;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant247" /> class.
        /// </summary>
        public UserEventPayloadVariant247()
        {
        }
    }
}