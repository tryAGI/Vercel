
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant14
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AliasCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public global::Vercel.UserEventPayloadVariant14Deployment? Deployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant14" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="aliasCount"></param>
        /// <param name="deployment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant14(
            string projectId,
            double aliasCount,
            global::Vercel.UserEventPayloadVariant14Deployment? deployment)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.AliasCount = aliasCount;
            this.Deployment = deployment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant14" /> class.
        /// </summary>
        public UserEventPayloadVariant14()
        {
        }
    }
}