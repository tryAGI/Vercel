
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant255
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedUser")]
        public global::Vercel.UserEventPayloadVariant255DeletedUser? DeletedUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedUid")]
        public string? DeletedUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("githubUsername")]
        public string? GithubUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitlabUsername")]
        public string? GitlabUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitbucketUsername")]
        public string? BitbucketUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directoryType")]
        public string? DirectoryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant255RoleJsonConverter))]
        public global::Vercel.UserEventPayloadVariant255Role? Role { get; set; }

        /// <summary>
        /// Why the member was removed. When removed due to a plan downgrade, this is a {@link DowngradeReason} from `@api/pubsub-types` (e.g. `trial_expired`, `user_downgrade`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousPlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant255PreviousPlanJsonConverter))]
        public global::Vercel.UserEventPayloadVariant255PreviousPlan? PreviousPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newPlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant255NewPlanJsonConverter))]
        public global::Vercel.UserEventPayloadVariant255NewPlan? NewPlan { get; set; }

        /// <summary>
        /// Whether the removal was system-initiated rather than human-initiated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automated")]
        public bool? Automated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant255" /> class.
        /// </summary>
        /// <param name="deletedUser"></param>
        /// <param name="deletedUid"></param>
        /// <param name="githubUsername"></param>
        /// <param name="gitlabUsername"></param>
        /// <param name="bitbucketUsername"></param>
        /// <param name="directoryType"></param>
        /// <param name="role"></param>
        /// <param name="reason">
        /// Why the member was removed. When removed due to a plan downgrade, this is a {@link DowngradeReason} from `@api/pubsub-types` (e.g. `trial_expired`, `user_downgrade`).
        /// </param>
        /// <param name="previousPlan"></param>
        /// <param name="newPlan"></param>
        /// <param name="automated">
        /// Whether the removal was system-initiated rather than human-initiated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant255(
            global::Vercel.UserEventPayloadVariant255DeletedUser? deletedUser,
            string? deletedUid,
            string? githubUsername,
            string? gitlabUsername,
            string? bitbucketUsername,
            string? directoryType,
            global::Vercel.UserEventPayloadVariant255Role? role,
            string? reason,
            global::Vercel.UserEventPayloadVariant255PreviousPlan? previousPlan,
            global::Vercel.UserEventPayloadVariant255NewPlan? newPlan,
            bool? automated)
        {
            this.DeletedUser = deletedUser;
            this.DeletedUid = deletedUid;
            this.GithubUsername = githubUsername;
            this.GitlabUsername = gitlabUsername;
            this.BitbucketUsername = bitbucketUsername;
            this.DirectoryType = directoryType;
            this.Role = role;
            this.Reason = reason;
            this.PreviousPlan = previousPlan;
            this.NewPlan = newPlan;
            this.Automated = automated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant255" /> class.
        /// </summary>
        public UserEventPayloadVariant255()
        {
        }
    }
}