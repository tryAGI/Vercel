
#nullable enable

namespace Vercel
{
    /// <summary>
    /// GitLab
    /// </summary>
    public sealed partial class UserEventPayloadVariant68JobVariant7HeadInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant68JobVariant7HeadInfoProject Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant68JobVariant7HeadInfo" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="ref"></param>
        /// <param name="sha"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant68JobVariant7HeadInfo(
            global::Vercel.UserEventPayloadVariant68JobVariant7HeadInfoProject project,
            string @ref,
            string sha)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant68JobVariant7HeadInfo" /> class.
        /// </summary>
        public UserEventPayloadVariant68JobVariant7HeadInfo()
        {
        }
    }
}